using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace ExpertsCalculator
{
    partial class Experts
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Experts));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDelCol = new System.Windows.Forms.Button();
            this.bntDelRow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNumEx = new System.Windows.Forms.Label();
            this.lbNumTur = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTreshHold = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(189, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(350, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DarkGray;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Items.AddRange(new object[] {
            "Согласование",
            "Рассогласование"});
            this.comboBox1.Location = new System.Drawing.Point(30, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // btnAddRow
            // 
            this.btnAddRow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRow.BackgroundImage")));
            this.btnAddRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddRow.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRow.Location = new System.Drawing.Point(11, 28);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(35, 35);
            this.btnAddRow.TabIndex = 2;
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.BackColor = System.Drawing.Color.Gray;
            this.btnAddColumn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddColumn.BackgroundImage")));
            this.btnAddColumn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddColumn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAddColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddColumn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddColumn.Location = new System.Drawing.Point(11, 28);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(35, 35);
            this.btnAddColumn.TabIndex = 3;
            this.btnAddColumn.UseVisualStyleBackColor = false;
            this.btnAddColumn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(34, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 24);
            this.button3.TabIndex = 4;
            this.button3.Text = "Вычислить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDelCol
            // 
            this.btnDelCol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelCol.BackgroundImage")));
            this.btnDelCol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelCol.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDelCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelCol.Location = new System.Drawing.Point(50, 28);
            this.btnDelCol.Name = "btnDelCol";
            this.btnDelCol.Size = new System.Drawing.Size(35, 35);
            this.btnDelCol.TabIndex = 5;
            this.btnDelCol.UseVisualStyleBackColor = true;
            this.btnDelCol.Click += new System.EventHandler(this.btnDelCol_Click);
            // 
            // bntDelRow
            // 
            this.bntDelRow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntDelRow.BackgroundImage")));
            this.bntDelRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntDelRow.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bntDelRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntDelRow.Location = new System.Drawing.Point(50, 28);
            this.bntDelRow.Name = "bntDelRow";
            this.bntDelRow.Size = new System.Drawing.Size(35, 35);
            this.bntDelRow.TabIndex = 6;
            this.bntDelRow.UseVisualStyleBackColor = true;
            this.bntDelRow.Click += new System.EventHandler(this.bntDelRow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Количество экспертов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Количество туров";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Способ вычисления";
            // 
            // lbNumEx
            // 
            this.lbNumEx.AutoSize = true;
            this.lbNumEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumEx.Location = new System.Drawing.Point(124, 35);
            this.lbNumEx.Name = "lbNumEx";
            this.lbNumEx.Size = new System.Drawing.Size(25, 25);
            this.lbNumEx.TabIndex = 11;
            this.lbNumEx.Text = "1";
            // 
            // lbNumTur
            // 
            this.lbNumTur.AutoSize = true;
            this.lbNumTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumTur.Location = new System.Drawing.Point(124, 35);
            this.lbNumTur.Name = "lbNumTur";
            this.lbNumTur.Size = new System.Drawing.Size(25, 25);
            this.lbNumTur.TabIndex = 12;
            this.lbNumTur.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbNumEx);
            this.panel1.Controls.Add(this.btnDelCol);
            this.panel1.Controls.Add(this.btnAddColumn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 77);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bntDelRow);
            this.panel2.Controls.Add(this.btnAddRow);
            this.panel2.Controls.Add(this.lbNumTur);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 77);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(3, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 77);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtTreshHold);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(3, 252);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 71);
            this.panel4.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Пороговое значение";
            // 
            // txtTreshHold
            // 
            this.txtTreshHold.BackColor = System.Drawing.Color.Gray;
            this.txtTreshHold.Location = new System.Drawing.Point(28, 30);
            this.txtTreshHold.Name = "txtTreshHold";
            this.txtTreshHold.Size = new System.Drawing.Size(122, 20);
            this.txtTreshHold.TabIndex = 10;
            // 
            // Experts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(542, 356);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Experts";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Button btnAddRow;
        private Button btnAddColumn;
        private Button button3;
        private Button btnDelCol;
        private Button bntDelRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNumEx;
        private System.Windows.Forms.Label lbNumTur;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtTreshHold;
        private System.Windows.Forms.Label label4;
    }
}

