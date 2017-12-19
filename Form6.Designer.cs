namespace Dingbendong
{
    partial class Form6
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv5 = new System.Windows.Forms.DataGridView();
            this.btnKillClass = new System.Windows.Forms.Button();
            this.btnKillStu = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv5)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv5
            // 
            this.dgv5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv5.Location = new System.Drawing.Point(12, 12);
            this.dgv5.Name = "dgv5";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv5.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgv5.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv5.RowTemplate.Height = 30;
            this.dgv5.Size = new System.Drawing.Size(923, 704);
            this.dgv5.TabIndex = 1;
            this.dgv5.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv5_CellClick);
            this.dgv5.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv5_CellEndEdit);
            // 
            // btnKillClass
            // 
            this.btnKillClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKillClass.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnKillClass.Location = new System.Drawing.Point(1035, 319);
            this.btnKillClass.Name = "btnKillClass";
            this.btnKillClass.Size = new System.Drawing.Size(208, 88);
            this.btnKillClass.TabIndex = 36;
            this.btnKillClass.Text = "刪除整班";
            this.btnKillClass.UseVisualStyleBackColor = true;
            this.btnKillClass.Click += new System.EventHandler(this.btnKillClass_Click);
            // 
            // btnKillStu
            // 
            this.btnKillStu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKillStu.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnKillStu.Location = new System.Drawing.Point(1035, 426);
            this.btnKillStu.Name = "btnKillStu";
            this.btnKillStu.Size = new System.Drawing.Size(208, 88);
            this.btnKillStu.TabIndex = 37;
            this.btnKillStu.Text = "刪除學員";
            this.btnKillStu.UseVisualStyleBackColor = true;
            this.btnKillStu.Click += new System.EventHandler(this.btnKillStu_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClass.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddClass.Location = new System.Drawing.Point(1035, 207);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(208, 88);
            this.btnAddClass.TabIndex = 38;
            this.btnAddClass.Text = "新增";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // cbClass
            // 
            this.cbClass.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(1055, 45);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(208, 39);
            this.cbClass.TabIndex = 39;
            this.cbClass.SelectionChangeCommitted += new System.EventHandler(this.cbClass_SelectionChangeCommitted);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClass.Location = new System.Drawing.Point(964, 49);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(69, 35);
            this.lblClass.TabIndex = 42;
            this.lblClass.Text = "班級";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(964, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 35);
            this.label1.TabIndex = 44;
            this.label1.Text = "學員";
            // 
            // cbStu
            // 
            this.cbStu.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbStu.FormattingEnabled = true;
            this.cbStu.Location = new System.Drawing.Point(1055, 119);
            this.cbStu.Name = "cbStu";
            this.cbStu.Size = new System.Drawing.Size(208, 39);
            this.cbStu.TabIndex = 43;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 728);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStu);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.btnKillStu);
            this.Controls.Add(this.btnKillClass);
            this.Controls.Add(this.dgv5);
            this.Name = "Form6";
            this.Text = "班級管理";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv5;
        private System.Windows.Forms.Button btnKillClass;
        private System.Windows.Forms.Button btnKillStu;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStu;
    }
}