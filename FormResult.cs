using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertsCalculator
{
    public partial class FormResult : Form
    {
        String nameMetod;
        object[,] dataArray;
        public FormResult(object[,] dataArray, String nameMetod)
        {
            InitializeComponent();
            this.dataArray = dataArray;
            this.nameMetod = nameMetod;
        }
    }
}
