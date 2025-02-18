﻿
namespace CarHub
{
    partial class FormIncome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSellRecord = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDaily = new System.Windows.Forms.TextBox();
            this.txtWeekly = new System.Windows.Forms.TextBox();
            this.txtMonthly = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lbYear = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.lbday = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lbMonth = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePickerIncome = new System.Windows.Forms.DateTimePicker();
            this.btPrint = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSellRecord)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 48);
            this.label1.TabIndex = 140;
            this.label1.Text = "Income";
            // 
            // dataGridViewSellRecord
            // 
            this.dataGridViewSellRecord.AllowUserToAddRows = false;
            this.dataGridViewSellRecord.AllowUserToDeleteRows = false;
            this.dataGridViewSellRecord.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSellRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSellRecord.ColumnHeadersHeight = 26;
            this.dataGridViewSellRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSellRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewSellRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewSellRecord.GridColor = System.Drawing.Color.White;
            this.dataGridViewSellRecord.Location = new System.Drawing.Point(-2, 222);
            this.dataGridViewSellRecord.Name = "dataGridViewSellRecord";
            this.dataGridViewSellRecord.ReadOnly = true;
            this.dataGridViewSellRecord.RowHeadersWidth = 82;
            this.dataGridViewSellRecord.RowTemplate.Height = 30;
            this.dataGridViewSellRecord.Size = new System.Drawing.Size(813, 348);
            this.dataGridViewSellRecord.TabIndex = 141;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "InID";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "InDate";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "InTime";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Discount";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "SName";
            this.Column6.MinimumWidth = 10;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-6, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 142;
            this.label3.Text = "> Daily sales record";
            // 
            // txtDaily
            // 
            this.txtDaily.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtDaily.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDaily.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaily.ForeColor = System.Drawing.Color.White;
            this.txtDaily.Location = new System.Drawing.Point(68, 36);
            this.txtDaily.Margin = new System.Windows.Forms.Padding(2);
            this.txtDaily.Name = "txtDaily";
            this.txtDaily.Size = new System.Drawing.Size(117, 20);
            this.txtDaily.TabIndex = 143;
            // 
            // txtWeekly
            // 
            this.txtWeekly.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtWeekly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWeekly.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeekly.ForeColor = System.Drawing.Color.White;
            this.txtWeekly.Location = new System.Drawing.Point(71, 35);
            this.txtWeekly.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeekly.Name = "txtWeekly";
            this.txtWeekly.Size = new System.Drawing.Size(117, 20);
            this.txtWeekly.TabIndex = 146;
            // 
            // txtMonthly
            // 
            this.txtMonthly.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtMonthly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonthly.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthly.ForeColor = System.Drawing.Color.White;
            this.txtMonthly.Location = new System.Drawing.Point(69, 35);
            this.txtMonthly.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonthly.Name = "txtMonthly";
            this.txtMonthly.Size = new System.Drawing.Size(117, 20);
            this.txtMonthly.TabIndex = 149;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 150;
            this.label4.Text = "Monthly :";
            // 
            // txtYear
            // 
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Location = new System.Drawing.Point(41, 42);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(72, 20);
            this.txtYear.TabIndex = 158;
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(3, 42);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(35, 13);
            this.lbYear.TabIndex = 159;
            this.lbYear.Text = "Year :";
            // 
            // txtDay
            // 
            this.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDay.Location = new System.Drawing.Point(41, 0);
            this.txtDay.Margin = new System.Windows.Forms.Padding(2);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(72, 20);
            this.txtDay.TabIndex = 152;
            // 
            // lbday
            // 
            this.lbday.AutoSize = true;
            this.lbday.Location = new System.Drawing.Point(6, 0);
            this.lbday.Name = "lbday";
            this.lbday.Size = new System.Drawing.Size(32, 13);
            this.lbday.TabIndex = 153;
            this.lbday.Text = "Day :";
            // 
            // txtMonth
            // 
            this.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonth.Location = new System.Drawing.Point(41, 21);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(72, 20);
            this.txtMonth.TabIndex = 155;
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Location = new System.Drawing.Point(-5, 21);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(43, 13);
            this.lbMonth.TabIndex = 156;
            this.lbMonth.Text = "Month :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(421, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 31);
            this.btnSearch.TabIndex = 161;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateTimePickerIncome
            // 
            this.dateTimePickerIncome.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIncome.Location = new System.Drawing.Point(110, 64);
            this.dateTimePickerIncome.Name = "dateTimePickerIncome";
            this.dateTimePickerIncome.Size = new System.Drawing.Size(305, 31);
            this.dateTimePickerIncome.TabIndex = 162;
            // 
            // btPrint
            // 
            this.btPrint.BackColor = System.Drawing.Color.DodgerBlue;
            this.btPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrint.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.ForeColor = System.Drawing.Color.White;
            this.btPrint.Location = new System.Drawing.Point(559, 64);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(125, 31);
            this.btPrint.TabIndex = 163;
            this.btPrint.Text = "Print";
            this.btPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPrint.UseVisualStyleBackColor = false;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.txtMonthly);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(518, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 76);
            this.panel3.TabIndex = 164;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDaily);
            this.panel2.Location = new System.Drawing.Point(94, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 76);
            this.panel2.TabIndex = 165;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 150;
            this.label5.Text = "Daily :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtWeekly);
            this.panel1.Location = new System.Drawing.Point(306, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 76);
            this.panel1.TabIndex = 166;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 150;
            this.label2.Text = "Weekly :";
            // 
            // FormIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.dateTimePickerIncome);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.lbday);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.dataGridViewSellRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIncome";
            this.Text = "FormIncome";
            this.Load += new System.EventHandler(this.FormIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSellRecord)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSellRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDaily;
        private System.Windows.Forms.TextBox txtWeekly;
        private System.Windows.Forms.TextBox txtMonthly;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label lbday;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}