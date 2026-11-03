using System;
using System.Windows.Forms;

namespace kyrsova1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.pnlTop2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            this.pnlTop2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAll
            // 
            this.dgvAll.AllowUserToAddRows = false;
            this.dgvAll.AllowUserToDeleteRows = false;
            this.dgvAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAll.Location = new System.Drawing.Point(0, 0);
            this.dgvAll.MultiSelect = false;
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.ReadOnly = true;
            this.dgvAll.RowHeadersVisible = false;
            this.dgvAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAll.Size = new System.Drawing.Size(800, 450);
            this.dgvAll.TabIndex = 0;
            // 
            // pnlTop2
            // 
            this.pnlTop2.Controls.Add(this.btnBack);
            this.pnlTop2.Controls.Add(this.comboBox1);
            this.pnlTop2.Controls.Add(this.label1);
            this.pnlTop2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop2.Location = new System.Drawing.Point(0, 0);
            this.pnlTop2.Name = "pnlTop2";
            this.pnlTop2.Size = new System.Drawing.Size(800, 70);
            this.pnlTop2.TabIndex = 1;
            this.pnlTop2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop2_Paint);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Все",
            "Программист",
            "Повар",
            "Юрист"});
            this.comboBox1.Location = new System.Drawing.Point(106, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Специальность:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Зачислено: 0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlTop2);
            this.Controls.Add(this.dgvAll);
            this.Name = "Form2";
            this.Text = "Зачисленные (оригиналы)";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            this.pnlTop2.ResumeLayout(false);
            this.pnlTop2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pnlTop2_Paint(object sender, PaintEventArgs e)
        {
            //Здесь ничего не должно быть
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAll;
        private System.Windows.Forms.Panel pnlTop2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
    }
}