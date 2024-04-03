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

        private void button3_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridView1.Rows.Count;
            int columnCount = dataGridView1.Columns.Count;
            object[,] dataArray = new object[rowCount, columnCount];

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    dataArray[i, j] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }


            FormResult formResult = new FormResult(dataArray, comboBox1.SelectedItem.ToString());
            formResult.Show();
        }
    }
}
