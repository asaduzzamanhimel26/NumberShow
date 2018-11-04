using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberStorage
{
    public partial class NumberStorageUI : Form
    {
        public NumberStorageUI()
        {
            InitializeComponent();
        }
        List<int> numbers = new List<int>();
        private void insertButton_Click(object sender, EventArgs e)
        {
            if(numberTextBox.Text!="")
                {
                numberListBox.DataSource = null;
                int number = Convert.ToInt32(numberTextBox.Text);
                numberTextBox.Text = "";
                numbers.Add(number);
                numbers.Sort();
                numberListBox.DataSource = numbers;
            }
            //MessageBox.Show("Please insert the number in the correct fill");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showNumberComboBox.Items.Clear();
            int fromNumber = Convert.ToInt32(fromTextBox.Text);
            int toNumber = Convert.ToInt32(toTextBox.Text);
            foreach (var number in numbers)
            {
                if(number>=fromNumber && number<=toNumber)
                {
                    showNumberComboBox.Items.Add(number);
                }
            }
        }
    }
}
