using EF2.Models;
using Microsoft.EntityFrameworkCore;
namespace EF2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDepartments();
            button3.Enabled = false;
            button4.Enabled = false;
        }
        private void LoadDepartments()
        {
            using (var context = new CompanySdContext())
            {
                var depts = context.Departments.ToList();
                comboBox1.DataSource = depts;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
            }
        }
        private void LoadEmployees()
        {
            using (var repo = new EmployeeRepository(new CompanySdContext()))
            {
                var employees = repo.GetAllEmployees()
                    .Include(e => e.Department)
                    .Select(e => new
                    {
                        e.Ssn,
                        e.Fname,
                        e.Lname,
                        e.Address,
                        e.Salary,
                        Department = e.Department != null ? e.Department.Name : ""
                    })
                    .ToList();

                dataGridView1.DataSource = employees;
                dataGridView1.Columns["Ssn"].Visible = false;
                dataGridView1.ClearSelection();
            }
        }
        // search
        private void button1_Click(object sender, EventArgs e)
        {
            using (var repo = new EmployeeRepository(new CompanySdContext()))
            {
                var name = textBox1.Text;
                var employees = repo.SearchByName(name);
                dataGridView1.DataSource = employees
                    .Select(e => new
                    {
                        e.Ssn,
                        e.Fname,
                        e.Lname,
                        e.Address,
                        e.Salary,
                        Department = e.Department != null ? e.Department.Name : ""
                    })
                    .ToList();
                dataGridView1.ClearSelection();
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }
        //create
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) &&
                string.IsNullOrWhiteSpace(textBox3.Text) &&
                string.IsNullOrWhiteSpace(textBox4.Text) &&
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please fill at least one field before creating an employee.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var repo = new EmployeeRepository(new CompanySdContext()))
            {
                var newEmployee = new Employee
                {
                    Fname = textBox2.Text,
                    Lname = textBox3.Text,
                    Address = textBox4.Text,
                    Salary = int.TryParse(textBox5.Text, out var salary) ? salary : 0,
                    DepartmentId = (int?)comboBox1.SelectedValue
                };

                repo.AddEmployee(newEmployee);
                MessageBox.Show("Employee added successfully!");
            }
            LoadEmployees();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            bool rowSelected = dataGridView1.CurrentRow != null;
            button3.Enabled = rowSelected;
            button4.Enabled = rowSelected;

            if (!rowSelected) return;

            var row = dataGridView1.CurrentRow;
            textBox2.Text = row.Cells["Fname"].Value?.ToString();
            textBox3.Text = row.Cells["Lname"].Value?.ToString();
            textBox4.Text = row.Cells["Address"].Value?.ToString();
            textBox5.Text = row.Cells["Salary"].Value?.ToString();

            var deptName = row.Cells["Department"].Value?.ToString();
            comboBox1.SelectedIndex = comboBox1.FindStringExact(deptName);
        }
        // update
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var ssn = (int)dataGridView1.CurrentRow.Cells["Ssn"].Value;

            using (var repo = new EmployeeRepository(new CompanySdContext()))
            {
                var employee = repo.GetAllEmployees().FirstOrDefault(emp => emp.Ssn == ssn);
                if (employee != null)
                {
                    employee.Fname = textBox2.Text;
                    employee.Lname = textBox3.Text;
                    employee.Address = textBox4.Text;
                    employee.Salary = int.TryParse(textBox5.Text, out var salary) ? salary : 0;
                    employee.DepartmentId = (int?)comboBox1.SelectedValue;

                    repo.UpdateEmployee(employee);
                    MessageBox.Show("Employee updated successfully!");
                    LoadEmployees();
                }
            }
        }
        // get all employees
        private void button5_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }
        // delete
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var ssn = (int)dataGridView1.CurrentRow.Cells["Ssn"].Value;

            using (var repo = new EmployeeRepository(new CompanySdContext()))
            {
                var employee = repo.GetAllEmployees().FirstOrDefault(emp => emp.Ssn == ssn);
                if (employee != null)
                {
                    var confirm = MessageBox.Show(
                        $"Are you sure you want to delete {employee.Fname} {employee.Lname}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        repo.DeleteEmployee(employee);
                        MessageBox.Show("Employee deleted successfully!");
                        LoadEmployees();
                    }
                }
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dataGridView1.HitTest(e.X, e.Y);
            if (hit.RowIndex < 0)
            {
                dataGridView1.ClearSelection();
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }
    }
}
