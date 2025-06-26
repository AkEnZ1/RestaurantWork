using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurant
{
    public partial class LoginForm : Form
    {
        public static List<User> Users = new List<User>();
        public static List<Employee> Employees = new List<Employee>();
        public LoginForm()
        {
            InitializeComponent();
            SetupEmployees();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void authentication_Click(object sender, EventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Text;

            foreach (var emp in Employees)
            {
                if (emp.Login == login && emp.Password == password)
                {
                    EmployeeForm empForm = new EmployeeForm();
                    empForm.Show();
                    this.Hide();
                    return;
                }
            }

            foreach (var user in Users)
            {
                if (user.Login == login && user.Password == password)
                {
                    ClientForm clientForm = new ClientForm();
                    clientForm.Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Неверный логин или пароль");
        }

        private void SetupEmployees()
        {
            Employees.Add(new Employee { Login = "pPetrov", Password = "emp_5678" });
            Employees.Add(new Employee { Login = "sSidorov", Password = "emp_1234" });
        }
        public class User
        {
            public string Login { get; set; } = "";
            public string Password { get; set; } = "";
        }

        public class Employee : User { }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
