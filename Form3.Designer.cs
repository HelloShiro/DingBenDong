namespace Dingbendong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.btnKillAll = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnKakuNin = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPaid = new System.Windows.Forms.Button();
            this.cbStu = new System.Windows.Forms.ComboBox();
            this.lblNotPaid = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv2
            // 
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv2.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv2.Location = new System.Drawing.Point(0, 0);
            this.dgv2.Name = "dgv2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv2.RowHeadersWidth = 50;
            this.dgv2.RowTemplate.Height = 35;
            this.dgv2.Size = new System.Drawing.Size(1270, 452);
            this.dgv2.TabIndex = 0;
            this.dgv2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellEndEdit);
            // 
            // btnKillAll
            // 
            this.btnKillAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKillAll.Font = new System.Drawing.Font("新細明體", 15F);
            this.btnKillAll.Location = new System.Drawing.Point(952, 529);
            this.btnKillAll.Name = "btnKillAll";
            this.btnKillAll.Size = new System.Drawing.Size(84, 41);
            this.btnKillAll.TabIndex = 25;
            this.btnKillAll.Text = "清空";
            this.btnKillAll.UseVisualStyleBackColor = true;
            this.btnKillAll.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("新細明體", 15F);
            this.btnSave.Location = new System.Drawing.Point(1042, 529);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 41);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnKakuNin
            // 
            this.btnKakuNin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKakuNin.Font = new System.Drawing.Font("新細明體", 15F);
            this.btnKakuNin.Location = new System.Drawing.Point(1131, 529);
            this.btnKakuNin.Name = "btnKakuNin";
            this.btnKakuNin.Size = new System.Drawing.Size(127, 41);
            this.btnKakuNin.TabIndex = 27;
            this.btnKakuNin.Text = "預覽訂單";
            this.btnKakuNin.UseVisualStyleBackColor = true;
            this.btnKakuNin.Click += new System.EventHandler(this.btnKakuNin_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.PowderBlue;
            this.lblTotal.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotal.Location = new System.Drawing.Point(685, 475);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 38);
            this.lblTotal.TabIndex = 49;
            this.lblTotal.Text = "總計:";
            // 
            // btnPaid
            // 
            this.btnPaid.BackColor = System.Drawing.Color.Transparent;
            this.btnPaid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaid.Font = new System.Drawing.Font("新細明體", 13F);
            this.btnPaid.Location = new System.Drawing.Point(1206, 12);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(52, 25);
            this.btnPaid.TabIndex = 50;
            this.btnPaid.Text = "全選";
            this.btnPaid.UseVisualStyleBackColor = false;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // cbStu
            // 
            this.cbStu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStu.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbStu.FormattingEnabled = true;
            this.cbStu.Location = new System.Drawing.Point(12, 458);
            this.cbStu.Name = "cbStu";
            this.cbStu.Size = new System.Drawing.Size(180, 42);
            this.cbStu.TabIndex = 52;
            this.cbStu.Visible = false;
            this.cbStu.SelectionChangeCommitted += new System.EventHandler(this.cbStu_SelectionChangeCommitted);
            // 
            // lblNotPaid
            // 
            this.lblNotPaid.AutoSize = true;
            this.lblNotPaid.BackColor = System.Drawing.Color.PowderBlue;
            this.lblNotPaid.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.lblNotPaid.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNotPaid.Location = new System.Drawing.Point(686, 528);
            this.lblNotPaid.Name = "lblNotPaid";
            this.lblNotPaid.Size = new System.Drawing.Size(103, 35);
            this.lblNotPaid.TabIndex = 56;
            this.lblNotPaid.Text = "待收款:";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 15F);
            this.btnAdd.Location = new System.Drawing.Point(12, 458);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 42);
            this.btnAdd.TabIndex = 57;
            this.btnAdd.Text = "新增訂單";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbItems
            // 
            this.cbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItems.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(12, 506);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(203, 42);
            this.cbItems.TabIndex = 58;
            this.cbItems.Visible = false;
            this.cbItems.SelectionChangeCommitted += new System.EventHandler(this.cbItems_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1114, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 28);
            this.label2.TabIndex = 59;
            this.label2.Text = "點選更改數量";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1270, 582);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNotPaid);
            this.Controls.Add(this.cbStu);
            this.Controls.Add(this.btnPaid);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnKakuNin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnKillAll);
            this.Controls.Add(this.dgv2);
            this.Name = "Form3";
            this.Text = "值日生管理";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button btnKillAll;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnKakuNin;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.ComboBox cbStu;
        private System.Windows.Forms.Label lblNotPaid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.Label label2;
    }
}