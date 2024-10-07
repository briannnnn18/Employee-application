using EmployeeNamespace;

namespace Employee_application
{
    public partial class frmEmployeeDatabase : Form
    {
        private Employee employee;
        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            employee = new Employee(
                    int.Parse(TextEmployeeId.Text),
                    TextFirstName.Text,
                    TextLastName.Text,
                    TextPosition.Text);

            dataGridView1.Rows.Add(
            employee.EmployeeId,
            employee.FirstName,
            employee.LastName,
            employee.Position);
        }
        private void frmEmployeeDatabase_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Employee ID", "Employee ID");
            dataGridView1.Columns.Add("First Name", "First Name");
            dataGridView1.Columns.Add("Last Name", "Last Name");
            dataGridView1.Columns.Add("Position", "Position");
        }

    }
}
namespace EmployeeNamespace
{
    public class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string position;

        
        public Employee()
        {
            employeeId = 0;
            firstName = string.Empty;
            lastName = string.Empty;
            position = string.Empty;
        }

        
        public Employee(int employeeId, string firstName, string lastName, string position)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }

        
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}

