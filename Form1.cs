using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ExpertsCalculator.EditGridEl;

namespace ExpertsCalculator
{
    public partial class Form1 : Form
    {
        int numEx = 1;
        int numTur = 0;


        public Form1()
        {
            InitializeComponent();
            AddColumn(dataGridView1);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "":

                    return;


                default:
                    return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numTur++;
            lbNumTur.Text = numTur.ToString();
            AddRow(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numEx++;
            lbNumEx.Text = numEx.ToString();
            AddColumn(dataGridView1);
        }

        private void bntDelRow_Click(object sender, EventArgs e)
        {
            numTur--;
            lbNumTur.Text = numTur.ToString();
            RemoveRow(dataGridView1);
        }

        private void btnDelCol_Click(object sender, EventArgs e)
        {
            if(numEx > 1) 
            {
                numEx--;
                lbNumEx.Text = numEx.ToString();
            }
            
            RemoveColumn(dataGridView1);
        }
    }
}
