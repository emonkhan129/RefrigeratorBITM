using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refrigerator
{
    public partial class Form1 : Form
    {
        Refrigerator aRefrigerator = new Refrigerator();
         
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            double maximumWeightItCanTake = Convert.ToDouble(maximumWeightTextBox.Text);

             aRefrigerator.MaximumWeightItCanTake = maximumWeightItCanTake;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {

           
            double numberOfItems = Convert.ToDouble(noOfItemsEntryTextBox.Text);
            double weightPerUnit = Convert.ToDouble(weightEntryTextBox.Text);

            double getCurrentWeight = aRefrigerator.GetCurrentWeight(numberOfItems, weightPerUnit);
            double getRemainingWeight = aRefrigerator.GetRemainingWeight();

            currentWeightTextBox.Text = getCurrentWeight.ToString();
            remainingWeightTextBox.Text = getRemainingWeight.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
