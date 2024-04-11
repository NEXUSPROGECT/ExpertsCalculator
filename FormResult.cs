using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace ExpertsCalculator
{
    public partial class FormResult : Form
    {
        String nameMetod;
        double[,] dataArray;
        double tHold;
        public FormResult(double[,] dataArray, String nameMetod, double tHold)
        {
            InitializeComponent();
            this.dataArray = dataArray;
            this.nameMetod = nameMetod;
            this.tHold = tHold;
            calculate(nameMetod);
            
        }

        private void calculate(string metod)
        {
            if (metod == "Согласование") 
            {
                Matching.MainCalculate(dataArray, dataGridView1, tHold, zedGraphControl1);
            }

            if (metod == "Рассогласование") 
            {
               //рассоглдасование
            }
        }
    }
}
