using System;

namespace kyrsova1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkOriginal = new System.Windows.Forms.CheckBox();
            this.chkDorm = new System.Windows.Forms.CheckBox();
            this.chkPaid = new System.Windows.Forms.CheckBox();
            this.chkBenefits = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtAttestat = new System.Windows.Forms.TextBox();
            this.txtExam = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbSpec = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Специальность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Группа:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Аттестат:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Экзамен:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Общий балл:";
            // 
            // chkOriginal
            // 
            this.chkOriginal.AutoSize = true;
            this.chkOriginal.Location = new System.Drawing.Point(10, 297);
            this.chkOriginal.Name = "chkOriginal";
            this.chkOriginal.Size = new System.Drawing.Size(102, 17);
            this.chkOriginal.TabIndex = 12;
            this.chkOriginal.Text = "Оригинал сдан";
            this.chkOriginal.UseVisualStyleBackColor = true;
            // 
            // chkDorm
            // 
            this.chkDorm.AutoSize = true;
            this.chkDorm.Location = new System.Drawing.Point(10, 320);
            this.chkDorm.Name = "chkDorm";
            this.chkDorm.Size = new System.Drawing.Size(118, 17);
            this.chkDorm.TabIndex = 13;
            this.chkDorm.Text = "нужно общежитие";
            this.chkDorm.UseVisualStyleBackColor = true;
            // 
            // chkPaid
            // 
            this.chkPaid.AutoSize = true;
            this.chkPaid.Location = new System.Drawing.Point(10, 343);
            this.chkPaid.Name = "chkPaid";
            this.chkPaid.Size = new System.Drawing.Size(116, 17);
            this.chkPaid.TabIndex = 14;
            this.chkPaid.Text = "платное обучение";
            this.chkPaid.UseVisualStyleBackColor = true;
            // 
            // chkBenefits
            // 
            this.chkBenefits.AutoSize = true;
            this.chkBenefits.Location = new System.Drawing.Point(10, 366);
            this.chkBenefits.Name = "chkBenefits";
            this.chkBenefits.Size = new System.Drawing.Size(88, 17);
            this.chkBenefits.TabIndex = 15;
            this.chkBenefits.Text = "есть льготы";
            this.chkBenefits.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "сохранить";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(93, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(12, 154);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(100, 20);
            this.txtGroup.TabIndex = 8;
            // 
            // txtAttestat
            // 
            this.txtAttestat.Location = new System.Drawing.Point(12, 193);
            this.txtAttestat.Name = "txtAttestat";
            this.txtAttestat.Size = new System.Drawing.Size(100, 20);
            this.txtAttestat.TabIndex = 9;
            // 
            // txtExam
            // 
            this.txtExam.Location = new System.Drawing.Point(12, 232);
            this.txtExam.Name = "txtExam";
            this.txtExam.Size = new System.Drawing.Size(100, 20);
            this.txtExam.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(12, 271);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 11;
            // 
            // cmbSpec
            // 
            this.cmbSpec.FormattingEnabled = true;
            this.cmbSpec.Items.AddRange(new object[] {
            "Программист",
            "Юрист",
            "Повар"});
            this.cmbSpec.Location = new System.Drawing.Point(12, 114);
            this.cmbSpec.Name = "cmbSpec";
            this.cmbSpec.Size = new System.Drawing.Size(121, 21);
            this.cmbSpec.TabIndex = 18;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 580);
            this.Controls.Add(this.cmbSpec);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkBenefits);
            this.Controls.Add(this.chkPaid);
            this.Controls.Add(this.chkDorm);
            this.Controls.Add(this.chkOriginal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtExam);
            this.Controls.Add(this.txtAttestat);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Здесь ничего не должно быть
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkOriginal;
        private System.Windows.Forms.CheckBox chkDorm;
        private System.Windows.Forms.CheckBox chkPaid;
        private System.Windows.Forms.CheckBox chkBenefits;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtAttestat;
        private System.Windows.Forms.TextBox txtExam;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbSpec;
    }
}