using Restaurant;

namespace BoomRestaurant
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToLongTimeString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            lbl_day.Text = DateTime.Now.ToShortDateString();
            timer2.Start();
        }

        private void cb_fries_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_fries.Checked == true)
            {
                txt_fries.Enabled = true;
            }
            if (cb_fries.Checked == false)
            {
                txt_fries.Enabled = false;
                txt_fries.Text = "0";
            }
        }

        private void cb_burger_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_burger.Checked == true)
            {
                txt_burger.Enabled = true;
            }
            if (cb_burger.Checked == false)
            {
                txt_burger.Enabled = false;
                txt_burger.Text = "0";
            }
        }

        private void cb_pizza_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_pizza.Checked == true)
            {
                txt_pizza.Enabled = true;
            }
            if (cb_pizza.Checked == false)
            {
                txt_pizza.Enabled = false;
                txt_pizza.Text = "0";
            }
        }

        private void cb_chicken_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_chicken.Checked == true)
            {
                txt_chicken.Enabled = true;
            }
            if (cb_chicken.Checked == false)
            {
                txt_chicken.Enabled = false;
                txt_chicken.Text = "0";
            }
        }

        private void cb_sandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_sandwich.Checked == true)
            {
                txt_sandwich.Enabled = true;
            }
            if (cb_sandwich.Checked == false)
            {
                txt_sandwich.Enabled = false;
                txt_sandwich.Text = "0";
            }
        }

        private void cb_orange_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_orange.Checked == true)
            {
                txt_orange.Enabled = true;
            }
            if (cb_orange.Checked == false)
            {
                txt_orange.Enabled = false;
                txt_orange.Text = "0";
            }
        }

        private void cb_lemon_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_lemon.Checked == true)
            {
                txt_lemon.Enabled = true;
            }
            if (cb_lemon.Checked == false)
            {
                txt_lemon.Enabled = false;
                txt_lemon.Text = "0";
            }
        }

        private void cb_cola_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_cola.Checked == true)
            {
                txt_cola.Enabled = true;
            }
            if (cb_cola.Checked == false)
            {
                txt_cola.Enabled = false;
                txt_cola.Text = "0";
            }
        }

        private void cb_tea_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_tea.Checked == true)
            {
                txt_tea.Enabled = true;
            }
            if (cb_tea.Checked == false)
            {
                txt_tea.Enabled = false;
                txt_tea.Text = "0";
            }
        }

        private void cb_cake_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_cake.Checked == true)
            {
                txt_cake.Enabled = true;
            }
            if (cb_cake.Checked == false)
            {
                txt_cake.Enabled = false;
                txt_cake.Text = "0";
            }
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {

        }
        double friesup = 30, burgerup = 80, pizzaup = 100, chickenup = 120, sandwichup = 110;
        double orangeup = 35, lemonup = 40, colaup = 25, teaup = 10, cakeup = 50;
        // variables to hold Total Price for each drink and meal
        double friestp, burgertp, pizzatp, chickentp, sandwichtp, orangetp, lemontp, colatp, teatp, caketp;


        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                friestp = friesup * Convert.ToDouble(txt_fries.Text);
                burgertp = burgerup * Convert.ToDouble(txt_burger.Text);
                pizzatp = pizzaup * Convert.ToDouble(txt_pizza.Text);
                chickentp = chickenup * Convert.ToDouble(txt_chicken.Text);
                sandwichtp = sandwichup * Convert.ToDouble(txt_sandwich.Text);

                orangetp = orangeup * Convert.ToDouble(txt_orange.Text);
                lemontp = lemonup * Convert.ToDouble(txt_lemon.Text);
                colatp = colaup * Convert.ToDouble(txt_cola.Text);
                teatp = teaup * Convert.ToDouble(txt_tea.Text);
                caketp = cakeup * Convert.ToDouble(txt_cake.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You are Trying to Enter Text !!! \nPlease, You Must Enter Number Between 1 to 99", " Error !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }


            txt_receipt.Clear();
            txt_receipt.AppendText(Environment.NewLine);
            txt_receipt.AppendText("\t\t\tEngineer's Restaurant\t" + lbl_date.Text + Environment.NewLine);
            txt_receipt.AppendText("\t\t\t*********************\t\t" + lbl_day.Text + Environment.NewLine);

            double suptotal = 0, tax = 0, total = 0;
            if (cb_fries.Checked == true)
            {
                txt_receipt.AppendText("\tFries: " + friestp + " EGP" + Environment.NewLine);
                suptotal = suptotal + friestp;
                lbl_suptotal.Text = suptotal + " EGP";
            }
            if (cb_burger.Checked == true)
            {
                txt_receipt.AppendText("\tBurger: " + burgertp + " EGP" + Environment.NewLine);
                suptotal = suptotal + burgertp;
                lbl_suptotal.Text = suptotal + " EGP";
            }
            if (cb_pizza.Checked == true)
            {
                txt_receipt.AppendText("\tPizza: " + pizzatp + " EGP" + Environment.NewLine);
                suptotal = suptotal + pizzatp;
                lbl_suptotal.Text = suptotal + " EGP";
            }
            if (cb_chicken.Checked == true)
            {
                txt_receipt.AppendText("\tChicken: " + chickentp + " EGP" + Environment.NewLine);
                suptotal = suptotal + chickentp;
                lbl_suptotal.Text = suptotal + " EGP";
            }
            if (cb_sandwich.Checked == true)
            {
                txt_receipt.AppendText("\tSandwich: " + sandwichtp + " EGP" + Environment.NewLine);
                suptotal = suptotal + sandwichtp;
                lbl_suptotal.Text = suptotal + " EGP";
            }
            //drinks 
            if (cb_orange.Checked == true)
            {
                txt_receipt.AppendText("\tOrange: " + orangetp + " EGP" + Environment.NewLine);
                suptotal = suptotal + orangetp;
                lbl_suptotal.Text = suptotal + " EGP";
            }
            if (cb_lemon.Checked == true)
            {
                txt_receipt.AppendText("\tLemon: " + lemontp + " EGP" + Environment.NewLine);
                suptotal = suptotal + lemontp;
                lbl_suptotal.Text = suptotal + " EGP";
            }
            if (cb_cola.Checked == true)
            {
                txt_receipt.AppendText("\tCola: " + colatp + " EGP" + Environment.NewLine);
                suptotal = suptotal + colatp;
                lbl_suptotal.Text = suptotal + " EGP";
            }
            if (cb_tea.Checked == true)
            {
                txt_receipt.AppendText("\tTea: " + teatp + " EGP" + Environment.NewLine);
                suptotal = suptotal + teatp;
                lbl_suptotal.Text = suptotal + " EGP";
            }
            if (cb_cake.Checked == true)
            {
                txt_receipt.AppendText("\tCake: " + caketp + " EGP" + Environment.NewLine);
                suptotal = suptotal + caketp;
                lbl_suptotal.Text = suptotal + " EGP";
            }
            tax = Math.Round(suptotal * 0.14, 2);
            total = suptotal + tax;
            lbl_tax.Text = tax + " EGP";
            lbl_total.Text = total + " EGP";


        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cb_fries.Checked = false;
            cb_burger.Checked = false;
            cb_pizza.Checked = false;
            cb_chicken.Checked = false;
            cb_sandwich.Checked = false;

            cb_cake.Checked = false;
            cb_tea.Checked = false;
            cb_orange.Checked = false;
            cb_lemon.Checked = false;
            cb_cola.Checked = false;
            txt_receipt.Clear();
            lbl_suptotal.Text = "---/EGP";
            lbl_tax.Text = "---/EGP";
            lbl_total.Text = "---/EGP";

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txt_receipt.Text + "\nSubtoltal: " + lbl_suptotal.Text + "\tTax: " + lbl_tax.Text + "\tTotal: " + lbl_total.Text, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Blue, new Point(130));
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            lbl_day.Text = DateTime.Now.ToShortDateString();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_print_MouseMove(object sender, MouseEventArgs e)
        {
            btn_print.Size = new Size(95, 50);
            btn_print.BackColor = Color.Yellow;
        }

        private void btn_print_MouseLeave(object sender, EventArgs e)
        {
            btn_print.Size = new Size(87, 43);
            btn_print.BackColor = Color.DeepSkyBlue;
        }

        private void btn_add_MouseMove(object sender, MouseEventArgs e)
        {
            btn_add.Size = new Size(95, 50);
            btn_add.BackColor = Color.Yellow;
        }

        private void btn_add_MouseLeave(object sender, EventArgs e)
        {
            btn_add.Size = new Size(87, 43);
            btn_add.BackColor = Color.Lime;
        }

        private void btn_reset_MouseMove(object sender, MouseEventArgs e)
        {
            btn_reset.Size = new Size(95, 50);
            btn_reset.BackColor = Color.Yellow;
        }

        private void btn_reset_MouseLeave(object sender, EventArgs e)
        {
            btn_reset.Size = new Size(87, 43);
            btn_reset.BackColor = Color.Red;
        }
    }
}
