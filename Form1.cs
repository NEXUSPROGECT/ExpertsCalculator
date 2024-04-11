using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static ExpertsCalculator.EditGridEl;

namespace ExpertsCalculator
{
    public partial class Experts : Form
    {
        int numEx = 1;
        int numTur = 0;


        public Experts()
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
            if(comboBox1.SelectedItem == null) {return; }


            int rowCount = dataGridView1.Rows.Count;
            int columnCount = dataGridView1.Columns.Count;
            object[,] dataArray = new object[rowCount, columnCount];
            double[,] doubleArray = new double[rowCount, columnCount];

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    dataArray[i, j] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            // Преобразуем каждый элемент массива object в double
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    // Используем метод Convert.ToDouble для преобразования
                    doubleArray[i, j] = Convert.ToDouble(dataArray[i, j]);
                }
            }

            FormResult formResult = new FormResult(doubleArray, comboBox1.SelectedItem.ToString(), Convert.ToDouble(txtTreshHold.Text));
            formResult.Show();
        }
    }
}
