using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NikitosBank
{
    partial class CalculateIncome : Form
    {
        string login;
        string password;
        double stableTotal;
        double optimalTotal;
        double standardTotal;
        double stableTotalIncome;
        double optimalTotalIncome;
        double standartTotalIncome;

        int months;
        double monthDeposit;

        readonly Database db;
        public CalculateIncome(string _login, string _password, Database database)
        {
            InitializeComponent();
            this.login = _login;
            this.password = _password;

            this.db = database;
        }

        private void Calculate()
        {
            Debug.WriteLine("calculation");
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                return;
            }
            double principal = Convert.ToDouble(textBox1.Text);
            int monthsCount = Convert.ToInt32(textBox2.Text);
            double monthlyDeposit = Convert.ToDouble(textBox3.Text);
            monthDeposit = monthlyDeposit;

            double stableInterestRate = 0.08;
            double optimalInterestRate = 0.05;
            double standardInterestRate = 0.06;

            stableTotal = CalculateTotal(principal, monthsCount, 0, stableInterestRate);
            optimalTotal = CalculateTotal(principal, monthsCount, monthlyDeposit, optimalInterestRate);
            standardTotal = CalculateTotal(principal, monthsCount, monthlyDeposit, standardInterestRate);

            stableTotalIncome = stableTotal - principal;
            optimalTotalIncome = optimalTotal - principal;
            standartTotalIncome = standardTotal - principal;
            DisplayResults(stableTotalIncome, optimalTotalIncome, standartTotalIncome);
        }

        private double CalculateTotal(double principal, int _months, double monthlyDeposit, double interestRate)
        {
            double total = principal;
            months = _months;
            for (int i = 0; i < _months; i++)
            {
                total += monthlyDeposit;
                total *= (1 + interestRate / 12);
            }

            return total;
        }

        private void DisplayResults(double stableTotal, double optimalTotal, double standardTotal)
        {
            textStable.Text = $"{stableTotal:C2} rub."; 
            textOptymal.Text = $"{optimalTotal:C2} rub.";
            textStandart.Text = $"{standardTotal:C2} rub.";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)) { e.Handled = true;  }
            if(e.KeyChar == ((char)Keys.Back)) { textBox1.Text = null; }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)) { e.Handled = true;  }
            if (e.KeyChar == ((char)Keys.Back)) { textBox2.Text = null; }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)) { e.Handled = true; }
            if (e.KeyChar == ((char)Keys.Back)) { textBox3.Text = null; }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            switch (trackBar1.Value)
            {
                case 0:
                    textBox1.Text = null;
                    break;
                case 1: textBox1.Text = 100_000.ToString();
                    break;
                case 2:
                    textBox1.Text = 500_000.ToString();
                    break;
                case 3:
                    textBox1.Text = 1_000_000.ToString();
                    break;
                case 4:
                    textBox1.Text = 2_000_000.ToString();
                    break;
                case 5:
                    textBox1.Text = 3_000_000.ToString();
                    break;
                case 6:
                    textBox1.Text = 4_000_000.ToString();
                    break;
                case 7:
                    textBox1.Text = 5_000_000.ToString();
                    break;
                case 8:
                    textBox1.Text = 6_000_000.ToString();
                    break;
                case 9:
                    textBox1.Text = 7_000_000.ToString();
                    break;
                case 10:
                    textBox1.Text = 8_000_000.ToString();
                    break;
                case 11:
                    textBox1.Text = 9_000_000.ToString();
                    break;
                case 12:
                    textBox1.Text = 10_000_000.ToString();
                    break;

            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            switch (trackBar2.Value)
            {
                case 0:
                    textBox2.Text = null;
                    break;
                case 1:
                    textBox2.Text = 3.ToString();
                    break;
                case 2:
                    textBox2.Text = 6.ToString();
                    break;
                case 3:
                    textBox2.Text = 12.ToString();
                    break;
                case 4:
                    textBox2.Text = 24.ToString();
                    break;
                case 5:
                    textBox2.Text = 36.ToString();
                    break;
                case 6:
                    textBox2.Text = 48.ToString();
                    break;
                case 7:
                    textBox2.Text = 60.ToString();
                    break;
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            switch (trackBar3.Value)
            {
                case 0:
                    textBox3.Text = 1000.ToString();
                    break;
                case 1:
                    textBox3.Text = 100_000.ToString();
                    break;
                case 2:
                        textBox3.Text = 500_000.ToString();
                    break;
                case 3:
                    textBox3.Text = 1_000_000.ToString();
                    break;
                case 4:
                    textBox3.Text = 3_000_000.ToString();
                    break;
                case 5:
                    textBox3.Text = 5_000_000.ToString();
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int textNum = 0;
            if(textBox1.TextLength != 0)
            {
                textNum = int.Parse(textBox1.Text);
                if (textNum > 10_000_000)
                {
                    countTriggerLabel.Enabled = true;
                }
                else
                {
                    countTriggerLabel.Enabled = false;
                }
            }
            else
            {
                countTriggerLabel.Enabled = false;
            }
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Calculate();
            }
        }
       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int textNum = 0;
            if (textBox2.TextLength != 0)
            {
                textNum = int.Parse(textBox2.Text);
                if (textNum > 60)
                {
                    trigger2.Enabled = true;
                }
                else
                {
                    trigger2.Enabled = false;
                }
            }
            else
            {
                trigger2.Enabled = false;
            }
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                Calculate();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int textNum = 0;
            if (textBox3.TextLength != 0)
            {
                textNum = int.Parse(textBox3.Text);
                if (textNum > 5_000_000)
                {
                    trigger3.Enabled = true;
                }
                else
                {
                    trigger3.Enabled = false;
                }
            }
            else
            {
                trigger3.Enabled = false;
            }
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                Calculate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountDeposits countDeposits = new CountDeposits(stableTotalIncome, optimalTotalIncome, standartTotalIncome, 
                stableTotal, optimalTotal, standardTotal, login, password, months, monthDeposit, db);
            countDeposits.Show();
            this.Close();
        }
    }
}
