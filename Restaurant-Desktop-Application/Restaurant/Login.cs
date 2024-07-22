using BoomRestaurant;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        static List<Employee> emp = new List<Employee>();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }







        private void btn_login_Click(object sender, EventArgs e)
        {

            bool Successed = true;
            bool admin = false;




            for (int i = 0; i < emp.Count; i++)
            {


                if (emp[i].Equal(new Employee(txt_username.Text, txt_password.Text)))
                {
                    if (txt_username.Text == "Admin" && txt_password.Text == "123456")
                    {
                        Successed = false;
                        admin = true;
                        break;
                    }
                    Successed = true;
                    break;
                }
                Successed = false;
            }

            if (Successed == true)
            {
                Menu form1 = new Menu();
                form1.Show();
                this.Hide();
            }
            if (Successed == false && admin == false)
            {
                MessageBox.Show($"Username or Password is Wrong !!! ", "Error !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if (admin == true)
            {
                pan.Visible = false;

                gb_emp.Visible = true;
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {
            txt_username.Enabled = false;
            txt_username.Text = "Admin";
            txt_password.Clear();
            MessageBox.Show("Please, Enter Password for Admin .");

        }
        private void Login_Load(object sender, EventArgs e)
        {

            emp.Add(new Employee("Admin", "123456"));
            emp.Add(new Employee("Mahmoud", "55555"));
            emp.Add(new Employee("Ahmed", "111111"));




        }

        private void btn_add_emp_Click(object sender, EventArgs e)
        {
            if (txt_newpassword.Text == "" || txt_newusername.Text == "")
            {

                MessageBox.Show("Failed to add Employee !!! \n", " Error !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txt_newusername.Clear();
                txt_newpassword.Clear();
            }
            else
            {
                emp.Add(new Employee(txt_newusername.Text, txt_newpassword.Text));

                MessageBox.Show("Adding an Employee Succeeded", " Done Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_newusername.Clear();
                txt_newpassword.Clear();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            gb_emp.Visible = false;
            pan.Visible = true;
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Enabled = true;
            txt_password.Enabled = true;
            //Login login = new Login();
            //login.Show();
            //this.Hide();
        }

        private void btn_login_MouseMove(object sender, MouseEventArgs e)
        {
            btn_login.BackColor = Color.Red;
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.BackColor= Color.ForestGreen;
        }
    }
}
