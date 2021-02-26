using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithms
{
    public partial class Form1 : Form
    {
        int[] arrayOfNumbers;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBubbleS_Click(object sender, EventArgs e)
        {
            arrayOfNumbers = Utilities.CreateRandomArrayOfNumbers((int)numericUpDownNumbers.Value);
            Utilities.PrintArray(arrayOfNumbers);
        }

        private void buttonInsertionS_Click(object sender, EventArgs e)
        {

        }
    }
}
