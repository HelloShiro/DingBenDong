namespace Dingbendong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbStore_products = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKill = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbQuantity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lbProduct_price = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKillProducts = new System.Windows.Forms.Button();
            this.btnUpdatePrice = new System.Windows.Forms.Button();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.lblCal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStore_products
            // 
            this.lbStore_products.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbStore_products.FormattingEnabled = true;
            this.lbStore_products.ItemHeight = 31;
            this.lbStore_products.Location = new System.Drawing.Point(10, 152);
            this.lbStore_products.Name = "lbStore_products";
            this.lbStore_products.Size = new System.Drawing.Size(166, 345);
            this.lbStore_products.TabIndex = 22;
            this.lbStore_products.SelectedIndexChanged += new System.EventHandler(this.lbStore_products_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKill);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 15F);
            this.groupBox2.Location = new System.Drawing.Point(794, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 211);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "訂單";
            // 
            // btnKill
            // 
            this.btnKill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKill.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnKill.Location = new System.Drawing.Point(6, 121);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(208, 84);
            this.btnKill.TabIndex = 24;
            this.btnKill.Text = "刪除";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(6, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(208, 88);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "加入";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(800, 608);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(214, 46);
            this.btnConfirm.TabIndex = 25;
            this.btnConfirm.Text = "送出訂單";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbProduct);
            this.groupBox3.Controls.Add(this.tbPrice);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbQuantity);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 15F);
            this.groupBox3.Location = new System.Drawing.Point(299, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 211);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "訂購資訊";
            // 
            // tbProduct
            // 
            this.tbProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProduct.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbProduct.Location = new System.Drawing.Point(79, 34);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(404, 43);
            this.tbProduct.TabIndex = 34;
            this.tbProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPrice
            // 
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrice.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPrice.Location = new System.Drawing.Point(313, 92);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(170, 43);
            this.tbPrice.TabIndex = 33;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 19F);
            this.label2.Location = new System.Drawing.Point(250, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "NT$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 34);
            this.label3.TabIndex = 27;
            this.label3.Text = "價格";
            // 
            // cbQuantity
            // 
            this.cbQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantity.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbQuantity.FormattingEnabled = true;
            this.cbQuantity.Location = new System.Drawing.Point(313, 151);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(170, 42);
            this.cbQuantity.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 34);
            this.label7.TabIndex = 10;
            this.label7.Text = "產品";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(6, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 34);
            this.label9.TabIndex = 12;
            this.label9.Text = "數量";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(354, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 40);
            this.label1.TabIndex = 21;
            this.label1.Text = "歡迎您~";
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Font = new System.Drawing.Font("微軟正黑體", 55F, System.Drawing.FontStyle.Bold);
            this.lblStore.Location = new System.Drawing.Point(12, 9);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(336, 93);
            this.lblStore.TabIndex = 24;
            this.lblStore.Text = "店家名稱";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(513, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 40);
            this.label8.TabIndex = 25;
            this.label8.Text = "嗨!";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.BackColor = System.Drawing.Color.SkyBlue;
            this.lblStudent.Font = new System.Drawing.Font("微軟正黑體", 35F, System.Drawing.FontStyle.Bold);
            this.lblStudent.Location = new System.Drawing.Point(602, 35);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(302, 60);
            this.lblStudent.TabIndex = 26;
            this.lblStudent.Text = "snoopy king";
            // 
            // lbProduct_price
            // 
            this.lbProduct_price.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbProduct_price.Enabled = false;
            this.lbProduct_price.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbProduct_price.FormattingEnabled = true;
            this.lbProduct_price.ItemHeight = 31;
            this.lbProduct_price.Location = new System.Drawing.Point(182, 152);
            this.lbProduct_price.Name = "lbProduct_price";
            this.lbProduct_price.Size = new System.Drawing.Size(111, 345);
            this.lbProduct_price.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(4, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 34);
            this.label11.TabIndex = 38;
            this.label11.Text = "店家產品";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(176, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 34);
            this.label10.TabIndex = 37;
            this.label10.Text = "價格";
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.Location = new System.Drawing.Point(299, 371);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 45;
            this.dgv1.Size = new System.Drawing.Size(715, 235);
            this.dgv1.TabIndex = 39;
            this.dgv1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellEndEdit);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKillProducts);
            this.groupBox1.Controls.Add(this.btnUpdatePrice);
            this.groupBox1.Controls.Add(this.btnAddProducts);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 15F);
            this.groupBox1.Location = new System.Drawing.Point(10, 503);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 151);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "產品";
            // 
            // btnKillProducts
            // 
            this.btnKillProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKillProducts.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnKillProducts.Location = new System.Drawing.Point(6, 63);
            this.btnKillProducts.Name = "btnKillProducts";
            this.btnKillProducts.Size = new System.Drawing.Size(271, 40);
            this.btnKillProducts.TabIndex = 44;
            this.btnKillProducts.Text = "刪除產品";
            this.btnKillProducts.UseVisualStyleBackColor = true;
            this.btnKillProducts.Click += new System.EventHandler(this.btnKillProducts_Click);
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePrice.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdatePrice.Location = new System.Drawing.Point(6, 105);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(271, 40);
            this.btnUpdatePrice.TabIndex = 45;
            this.btnUpdatePrice.Text = "修改價格";
            this.btnUpdatePrice.UseVisualStyleBackColor = true;
            this.btnUpdatePrice.Click += new System.EventHandler(this.btnUpdatePrice_Click);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProducts.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddProducts.Location = new System.Drawing.Point(6, 22);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(272, 40);
            this.btnAddProducts.TabIndex = 43;
            this.btnAddProducts.Text = "新增產品";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // lblCal
            // 
            this.lblCal.AutoSize = true;
            this.lblCal.BackColor = System.Drawing.Color.PowderBlue;
            this.lblCal.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Bold);
            this.lblCal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCal.Location = new System.Drawing.Point(572, 616);
            this.lblCal.Name = "lblCal";
            this.lblCal.Size = new System.Drawing.Size(85, 38);
            this.lblCal.TabIndex = 48;
            this.lblCal.Text = "小計:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(299, 609);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 28);
            this.label4.TabIndex = 49;
            this.label4.Text = "點選更改數量";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1026, 666);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbProduct_price);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.lbStore_products);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "產品選擇";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbStore_products;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ListBox lbProduct_price;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKillProducts;
        private System.Windows.Forms.Button btnUpdatePrice;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.Label lblCal;
        private System.Windows.Forms.Label label4;
    }
}