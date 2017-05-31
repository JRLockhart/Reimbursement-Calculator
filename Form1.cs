﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reimbursementCalculator
{
    public partial class Form1 : Form
    {

        //declare fields
        int startingMileage, endingMileage;

        double milesTraveled, amountOwed, reimburseRate = .39;

        public Form1()
        {
            InitializeComponent();
        }

        //when button is clicked performed desired action
        private void calButton_Click(object sender, EventArgs e)
        {

            //assign value of number box to fields declared
            startingMileage = (int) numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;

            //check that mileage isn't negative
            if (endingMileage < startingMileage)
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage", "Cannot Calculate Mileage");
            }
            else //calculate the amount owed
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = "$" + amountOwed;
            }
        }

        //display the miles traveled to the user
        private void displayMiles_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " miles", "Miles Traveled");
        }
    }
}
