using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicDates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lbl_msg.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime chosenDate = dateTimePicker1.Value;

            int day = chosenDate.Day;
            int month = chosenDate.Month;  
            int year = chosenDate.Year %100 ;

            // check if if it's a magic date 
            if (day + month == year)
            {
                lbl_msg.ForeColor = Color.Green;
                lbl_msg.Text = "Magic Number!!";
            }
            else
            {
                lbl_msg.ForeColor = Color.Blue;

                lbl_msg.Text = "Nothing Special";
            }

            // update all labels
            lbl_day.Text = "Day: " + day;
            lbl_month.Text = "Month: " + month;
            lbl_year.Text = "Year: " + year;
            lbl_sum.Text = "Sum: " + (day + month);

        }
    }
}
