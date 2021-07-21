using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tip_calculTOR
{
    public partial class Form1 : Form
    {  
        double tippercent=0;
        double bills;
        double calculatetips = 0;
        double numofPeople;
        double total = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {   if (tippercent<100)
            {
                tippercent = Convert.ToDouble(tippercent) + 10;
                Tip.Text = Convert.ToString(tippercent + "%");
            }
        }
        private void SubButton_Click(object sender, EventArgs e)
        {
            if(tippercent>0)
            {
                {          
                    tippercent = Convert.ToDouble(tippercent) - 10;
                    Tip.Text = Convert.ToString(tippercent + "%");
                }
            }
        }
        private void NumPeople_Click(object sender, EventArgs e)
        {
            if (numofPeople > 0)
            {   
                numofPeople = Convert.ToDouble(numofPeople) - 1;
                People.Text = Convert.ToString(numofPeople);
            }
        }
        private void AddNumPeople_Click(object sender, EventArgs e)
        {
            if (numofPeople < 50)
            {
                numofPeople = Convert.ToDouble(numofPeople) + 1;
                People.Text = Convert.ToString(numofPeople);
            }
        }
        public double Calculate_tips()
        {   if (string.IsNullOrEmpty(Bill.Text))
            {
                Bill.Text = "0";
                MessageBox.Show("Enter Bill First");
            }
            bills = Convert.ToDouble(Bill.Text);
            calculatetips = ((bills * tippercent / 100) / numofPeople);
            calculatetips = Math.Round((Double)calculatetips, 2);
            return calculatetips;
        }
        public double Calculate_total()
        {
            if (string.IsNullOrEmpty(Bill.Text))
            {
                Bill.Text = "0";
                MessageBox.Show("Enter Bill First");
            }
            bills = Convert.ToDouble(Bill.Text);
            total = Calculate_tips() + bills / numofPeople;
            total =  Math.Round((Double)total, 2);
            return total;
        }
       
        private void BillTextBox_TextChanged(object sender, EventArgs e)
        {
            label7.Text = "$" + Convert.ToString(Calculate_tips());
        }
        private void TipTextBox_TextChanged(object sender, EventArgs e)
        {
            label7.Text = "$" + Convert.ToString(Calculate_tips());
        }
        private void PeopleTextBox_TextChanged(object sender, EventArgs e)
        {
            label7.Text = "$"+Convert.ToString(Calculate_tips());
        }
        private void TipPerPerson_TextChanged_1(object sender, EventArgs e)
        {
            label8.Text = "$" + Convert.ToString(Calculate_total());
        }

       
    }
}


