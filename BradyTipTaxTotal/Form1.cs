using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : Tip, Tax, and Total Program
* Author      : Kabrina Brady
* Created     : 9/10/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : Program asks for cost of food from user, adds 15% tip and 7% sales tax, and displays the result
*               Input:  Cost of food
*               Output: Cost of food plus tax and tip
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace BradyTipTaxTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //exit button terminates program
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double foodPrice;
            double SALES_TAX = 0.07;
            double thisFoodSalesTax; //holds value of tax for this specific meal
            double TIP = 0.15;
            double thisFoodTip; //holds value of tip for this specific meal
            double totalCost;

            //get the cost of food and convert to double
            foodPrice = double.Parse(txtInput.Text);

            //calculate sales tax of this specific meal
            thisFoodSalesTax = foodPrice * SALES_TAX;

            //calculate tip for this specific meal
            thisFoodTip = foodPrice * TIP;

            //add original price, sales tax, and tip
            totalCost = foodPrice + thisFoodSalesTax + thisFoodTip;

            //convert totalCost to string and display in label
            lblOutput.Text = totalCost.ToString("c");
        }
    }
}
