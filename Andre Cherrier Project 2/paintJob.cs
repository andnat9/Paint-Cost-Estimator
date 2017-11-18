/*Program Name: Paint Job Estimator
 * Description: A program to estimate how much a paint job will cost in material and labor.
 * Author: Andre Cherrier
 * Date: September 15, 2017
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Andre_Cherrier_Project_1;

namespace Andre_Cherrier_Project_2
{
    public partial class paintJob : Form
    {
        //creating the variables to be used in calculating the paint job
        private double wallSpace;
        private double paintPrice;
        private double gallonsAmount;
        private double laborHours;
        private double totalPaintCost;
        private double laborCost;
        private double totalPaintJob;
        public paintJob()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {   try
            {
                //setting wallSpace and paintPrice equal to the value of their respective textboxes
                wallSpace = double.Parse(wallSpaceTextbox.Text);
                paintPrice = double.Parse(paintPriceTextbox.Text);
                //figuring out and displaying amount of paint needed.
                gallonsAmount = Math.Ceiling(wallSpace / 115);
                paintAmountTextbox.Text = gallonsAmount.ToString("n0");
                //figuring out and displaying amount of labor hours needed
                laborHours = (gallonsAmount * 8);
                laborhoursTextbox.Text = laborHours.ToString("n2");
                //figuring out and displaying total paint cost
                totalPaintCost = gallonsAmount * paintPrice;
                totalPaintCostTextbox.Text = totalPaintCost.ToString("c");
                //figuring out and displaying total labor cost
                laborCost = laborHours * 20;
                laborCostTextbox.Text = laborCost.ToString("c");
                //adding total labor cost and total paint cost to display total paint job cost
                totalPaintJob = laborCost + totalPaintCost;
                totalJobCostTextbox.Text = totalPaintJob.ToString("c");
                
            }
            catch
            {
                MessageBox.Show("Invalid data entered. Please try again.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {   //setting all text in textboxes equal to nothing, thus "resetting" all textboxes
            wallSpaceTextbox.Text = "";
            paintPriceTextbox.Text = "";
            laborCostTextbox.Text = "";
            totalJobCostTextbox.Text = "";
            totalPaintCostTextbox.Text = "";
            laborhoursTextbox.Text = "";
            paintAmountTextbox.Text = "";
            //setting all variables equal to zero, resetting the messageBox
            wallSpace = 0;
            paintPrice = 0;
            gallonsAmount = 0;
            laborHours = 0;
            totalPaintCost = 0;
            laborCost = 0;
            totalPaintJob = 0;
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            //messageBox showing totals
            MessageBox.Show("The amount of gallons required: " + gallonsAmount.ToString("n2") + Environment.NewLine + Environment.NewLine + "The amount of labor hours required: " + laborHours.ToString("n2") + Environment.NewLine + Environment.NewLine + "The total cost of paint required: " + totalPaintCost.ToString("c") + Environment.NewLine + Environment.NewLine + "The total cost of labor required: " + laborCost.ToString("c") + Environment.NewLine + Environment.NewLine + "The total job cost amount: " + totalPaintJob.ToString("c"));
        }
        
        private void doNotPushButton_Click(object sender, EventArgs e)
        {
            //revert back to tic-tac-toe
            this.Visible = false;
            ticTacToeBoard ticTacToe = new ticTacToeBoard();
            ticTacToe.Show();
        }
    }
}
