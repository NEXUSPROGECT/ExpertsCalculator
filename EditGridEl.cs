using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertsCalculator
{
    internal class EditGridEl
    {
        public static void AddColumn(DataGridView gridView) 
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = "";
            column.Name = "ColumnName";
            column.Width = 25;
            column.ValueType = typeof(string);
            gridView.Columns.Add(column);
        }

        public static void AddRow(DataGridView gridView) 
        {
            gridView.Rows.Add();
        }

        public static void RemoveColumn(DataGridView gridView) 
        {
            if (gridView.Columns.Count != 1)
            {
                int lastIndex = gridView.Columns.Count - 1;
                gridView.Columns.RemoveAt(lastIndex);
            }
        }

        public static void RemoveRow(DataGridView gridView) 
        {
            gridView.CancelEdit();
            gridView.EndEdit();
            if (gridView.Rows.Count > 0)
            {
                int lastIndex = gridView.Rows.Count - 1;
                gridView.Rows.RemoveAt(lastIndex);
            }
        }
    }
}
