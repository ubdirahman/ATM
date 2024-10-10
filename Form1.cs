using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //bank account fields with a $0 starting balance
        private Overload myaccount = new Overload(0);

        private void Form1_Load(object sender, EventArgs e)
        {
            // display the starting balance
            balancetxt.Text = myaccount.Balance.ToString("c");
        }

        private void depositbtn_Click(object sender, EventArgs e)
        {
            // desimal amonut // to hold the amount of deposit
            decimal amount;

            // convet the amount to decimal
            if (decimal.TryParse(depositetxt.Text, out amount))
            {
                if (myaccount.Balance <= amount)
                {


                    // deposit the amount into the account 
                    myaccount.Deposit(amount);

                    // display the new balance 
                    depositetxt.Text = myaccount.Balance.ToString("c");

                    // clear the text box
                    depositetxt.Text = string.Empty;
                    balancetxt.Text = myaccount.Balance.ToString("c");
                }
                else
                {
                    MessageBox.Show("Invalid Balance");
                    widthrawtxt.Text = string.Empty;


                }
            }
            else
            {
                // display the error message 
                MessageBox.Show("Invalid Amouny");
            }
        }

        private void withdrawbtn_Click(object sender, EventArgs e)
        {

            // desimal amonut // to hold the amount of wirhdraw
            decimal amount;
           

            // convet the amount to decimal
            if (decimal.TryParse(widthrawtxt.Text, out amount))
            {
                if (myaccount.Balance >= amount)
                {
                    // withdraw the amount into the account 
                    myaccount.Withdraw(amount);

                    // display the new balance 
                    widthrawtxt.Text = myaccount.Balance.ToString("c");

                    // clear the text box
                    widthrawtxt.Text = string.Empty;

                    balancetxt.Text = myaccount.Balance.ToString("c");
                 
                }
                else
                {
                    MessageBox.Show("Invalid Balance");
                    widthrawtxt.Text = string.Empty;

                }

            }
            else
            {
                // display the error message 
                MessageBox.Show("Invalid Amouny");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}