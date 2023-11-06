using System.Data;
using System.Windows.Forms;
using Task3_SalaryCalculator.Models;

namespace Task3_SalaryCalculator
{
    public partial class MainForm : Form
    {
        private List<Employee> employees = new List<Employee>();
        public MainForm()
        {
            InitializeComponent();
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            decimal hours = WorkHoursNumeric.Value;
            decimal rate = HourlyRateNumeric.Value;

            Employee newEmployee = new Employee(name, hours, rate);

            employees.Add(newEmployee);

            NameTextBox.Text = string.Empty;
            WorkHoursNumeric.Value = 0;
            HourlyRateNumeric.Value = 0;

            DataGridView.DataSource = null;
            DataGridView.DataSource = employees;
        }
    }
}