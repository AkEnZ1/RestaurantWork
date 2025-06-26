using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Restaurant.LoginForm;

namespace Restaurant
{
    public partial class RegisterForm : Form
    {
        private Label reg_Error;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string login = log_reg.Text.Trim();
            string password = pass_reg.Text;

            if (string.IsNullOrWhiteSpace(login))
            {
                MessageBox.Show("Пожалуйста, введите логин");
                                                             
                log_reg.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, введите пароль");
                                                              
                pass_reg.Focus();
                return;
            }

            foreach (var user in LoginForm.Users)
            {
                if (user.Login.Equals(login, StringComparison.OrdinalIgnoreCase))
                {

                    MessageBox.Show("Этот логин уже есть в системе");
                                                                     
                    log_reg.Focus();
                    pass_reg.SelectAll();
                    return;
                }
            }

            LoginForm.Users.Add(new User
            {
                Login = login,
                Password = password
            });

            reg_Error.Visible = false;
            MessageBox.Show("Регистрация успешна!");
            this.Close();
        }
    }
}
