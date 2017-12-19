namespace Dingbendong
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.chkStar = new System.Windows.Forms.CheckBox();
            this.lblStoreChoosed = new System.Windows.Forms.Label();
            this.lblChoosed = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.lblStar = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbStores = new System.Windows.Forms.ListBox();
            this.lbProduct_price = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbStore_products = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStudents = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbStore = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMaintain = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.timerStar = new System.Windows.Forms.Timer(this.components);
            this.lblCut = new System.Windows.Forms.Label();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.btnLeast = new System.Windows.Forms.Button();
            this.lblOr = new System.Windows.Forms.Label();
            this.btnSeZtuMe = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.picIntro = new System.Windows.Forms.PictureBox();
            this.gbMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIntro)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.chkStar);
            this.gbMain.Controls.Add(this.lblStoreChoosed);
            this.gbMain.Controls.Add(this.lblChoosed);
            this.gbMain.Controls.Add(this.btnSub);
            this.gbMain.Controls.Add(this.lblStar);
            this.gbMain.Controls.Add(this.label11);
            this.gbMain.Controls.Add(this.label3);
            this.gbMain.Controls.Add(this.label10);
            this.gbMain.Controls.Add(this.lbStores);
            this.gbMain.Controls.Add(this.lbProduct_price);
            this.gbMain.Controls.Add(this.label8);
            this.gbMain.Controls.Add(this.tbAddress);
            this.gbMain.Controls.Add(this.lbStore_products);
            this.gbMain.Controls.Add(this.label6);
            this.gbMain.Controls.Add(this.cbStudents);
            this.gbMain.Controls.Add(this.groupBox2);
            this.gbMain.Controls.Add(this.label4);
            this.gbMain.Controls.Add(this.tbNote);
            this.gbMain.Controls.Add(this.tbTel);
            this.gbMain.Controls.Add(this.label2);
            this.gbMain.Controls.Add(this.lblID);
            this.gbMain.Controls.Add(this.cbType);
            this.gbMain.Controls.Add(this.cbStore);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.Controls.Add(this.label5);
            this.gbMain.Controls.Add(this.label7);
            this.gbMain.Controls.Add(this.label9);
            this.gbMain.Font = new System.Drawing.Font("新細明體", 15F);
            this.gbMain.Location = new System.Drawing.Point(12, 58);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(785, 763);
            this.gbMain.TabIndex = 16;
            this.gbMain.TabStop = false;
            // 
            // chkStar
            // 
            this.chkStar.AutoSize = true;
            this.chkStar.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkStar.Location = new System.Drawing.Point(449, 49);
            this.chkStar.Name = "chkStar";
            this.chkStar.Size = new System.Drawing.Size(51, 20);
            this.chkStar.TabIndex = 42;
            this.chkStar.Text = "我來";
            this.chkStar.UseVisualStyleBackColor = true;
            this.chkStar.CheckedChanged += new System.EventHandler(this.chkStar_CheckedChanged);
            // 
            // lblStoreChoosed
            // 
            this.lblStoreChoosed.AutoSize = true;
            this.lblStoreChoosed.BackColor = System.Drawing.Color.Khaki;
            this.lblStoreChoosed.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStoreChoosed.ForeColor = System.Drawing.Color.Blue;
            this.lblStoreChoosed.Location = new System.Drawing.Point(283, 208);
            this.lblStoreChoosed.Name = "lblStoreChoosed";
            this.lblStoreChoosed.Size = new System.Drawing.Size(86, 24);
            this.lblStoreChoosed.TabIndex = 41;
            this.lblStoreChoosed.Text = "已選擇：";
            // 
            // lblChoosed
            // 
            this.lblChoosed.AutoSize = true;
            this.lblChoosed.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblChoosed.Location = new System.Drawing.Point(266, 204);
            this.lblChoosed.Name = "lblChoosed";
            this.lblChoosed.Size = new System.Drawing.Size(0, 21);
            this.lblChoosed.TabIndex = 40;
            // 
            // btnSub
            // 
            this.btnSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSub.Font = new System.Drawing.Font("微軟正黑體", 35F, System.Drawing.FontStyle.Bold);
            this.btnSub.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSub.Location = new System.Drawing.Point(353, 348);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(188, 131);
            this.btnSub.TabIndex = 28;
            this.btnSub.Text = "訂購";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // lblStar
            // 
            this.lblStar.BackColor = System.Drawing.Color.LightGray;
            this.lblStar.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStar.Location = new System.Drawing.Point(323, 30);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(120, 39);
            this.lblStar.TabIndex = 39;
            this.lblStar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(541, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 35);
            this.label11.TabIndex = 36;
            this.label11.Text = "店家產品";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 35);
            this.label3.TabIndex = 33;
            this.label3.Text = "所有店家";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(689, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 35);
            this.label10.TabIndex = 35;
            this.label10.Text = "價格";
            // 
            // lbStores
            // 
            this.lbStores.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbStores.FormattingEnabled = true;
            this.lbStores.ItemHeight = 37;
            this.lbStores.Location = new System.Drawing.Point(6, 386);
            this.lbStores.Name = "lbStores";
            this.lbStores.Size = new System.Drawing.Size(218, 374);
            this.lbStores.TabIndex = 30;
            this.lbStores.SelectedIndexChanged += new System.EventHandler(this.lbStores_SelectedIndexChanged);
            // 
            // lbProduct_price
            // 
            this.lbProduct_price.Enabled = false;
            this.lbProduct_price.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbProduct_price.FormattingEnabled = true;
            this.lbProduct_price.ItemHeight = 31;
            this.lbProduct_price.Location = new System.Drawing.Point(695, 55);
            this.lbProduct_price.Name = "lbProduct_price";
            this.lbProduct_price.Size = new System.Drawing.Size(84, 562);
            this.lbProduct_price.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(221, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 35);
            this.label8.TabIndex = 38;
            this.label8.Text = "值日生";
            // 
            // tbAddress
            // 
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddress.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbAddress.Location = new System.Drawing.Point(145, 292);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(285, 39);
            this.tbAddress.TabIndex = 37;
            // 
            // lbStore_products
            // 
            this.lbStore_products.Enabled = false;
            this.lbStore_products.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbStore_products.FormattingEnabled = true;
            this.lbStore_products.ItemHeight = 31;
            this.lbStore_products.Location = new System.Drawing.Point(547, 55);
            this.lbStore_products.Name = "lbStore_products";
            this.lbStore_products.Size = new System.Drawing.Size(147, 562);
            this.lbStore_products.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(6, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 35);
            this.label6.TabIndex = 36;
            this.label6.Text = "地址";
            // 
            // cbStudents
            // 
            this.cbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudents.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbStudents.FormattingEnabled = true;
            this.cbStudents.Location = new System.Drawing.Point(80, 30);
            this.cbStudents.Name = "cbStudents";
            this.cbStudents.Size = new System.Drawing.Size(123, 39);
            this.cbStudents.TabIndex = 35;
            this.cbStudents.SelectionChangeCommitted += new System.EventHandler(this.cbStudents_SelectionChangeCommitted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 15F);
            this.groupBox2.Location = new System.Drawing.Point(547, 621);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 132);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "店家操作";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(6, 77);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(220, 39);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(6, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(220, 41);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(16, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 35);
            this.label4.TabIndex = 34;
            this.label4.Text = "學員";
            // 
            // tbNote
            // 
            this.tbNote.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbNote.Location = new System.Drawing.Point(230, 485);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNote.Size = new System.Drawing.Size(304, 275);
            this.tbNote.TabIndex = 32;
            this.tbNote.Text = "添加評論......";
            // 
            // tbTel
            // 
            this.tbTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbTel.Location = new System.Drawing.Point(145, 242);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(285, 39);
            this.tbTel.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(224, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 35);
            this.label2.TabIndex = 29;
            this.label2.Text = "店家介紹";
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblID.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblID.Location = new System.Drawing.Point(145, 101);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(132, 29);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "0";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.SystemColors.Control;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbType.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(145, 148);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(132, 39);
            this.cbType.TabIndex = 23;
            this.cbType.SelectionChangeCommitted += new System.EventHandler(this.cbType_SelectionChangeCommitted);
            // 
            // cbStore
            // 
            this.cbStore.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbStore.FormattingEnabled = true;
            this.cbStore.Location = new System.Drawing.Point(145, 193);
            this.cbStore.Name = "cbStore";
            this.cbStore.Size = new System.Drawing.Size(132, 39);
            this.cbStore.TabIndex = 22;
            this.cbStore.SelectedIndexChanged += new System.EventHandler(this.cbStore_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 35);
            this.label1.TabIndex = 21;
            this.label1.Text = "店家";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 35);
            this.label5.TabIndex = 14;
            this.label5.Text = "店家編號";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(6, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 35);
            this.label7.TabIndex = 10;
            this.label7.Text = "類別";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(6, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 35);
            this.label9.TabIndex = 12;
            this.label9.Text = "電話";
            // 
            // btnMaintain
            // 
            this.btnMaintain.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMaintain.Location = new System.Drawing.Point(682, 16);
            this.btnMaintain.Name = "btnMaintain";
            this.btnMaintain.Size = new System.Drawing.Size(118, 47);
            this.btnMaintain.TabIndex = 30;
            this.btnMaintain.Text = "管理";
            this.btnMaintain.UseVisualStyleBackColor = true;
            this.btnMaintain.Click += new System.EventHandler(this.btnMaintain_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoose.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChoose.Location = new System.Drawing.Point(521, 16);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(155, 47);
            this.btnChoose.TabIndex = 29;
            this.btnChoose.Text = "選擇店家";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // timerStar
            // 
            this.timerStar.Tick += new System.EventHandler(this.timerStar_Tick);
            // 
            // lblCut
            // 
            this.lblCut.AutoSize = true;
            this.lblCut.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCut.Location = new System.Drawing.Point(1289, 747);
            this.lblCut.Name = "lblCut";
            this.lblCut.Size = new System.Drawing.Size(130, 35);
            this.lblCut.TabIndex = 41;
            this.lblCut.Text = "結單時間:";
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.AutoSize = true;
            this.lblTimeNow.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTimeNow.Location = new System.Drawing.Point(1289, 782);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(130, 35);
            this.lblTimeNow.TabIndex = 42;
            this.lblTimeNow.Text = "目前時間:";
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(92, 16);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(123, 39);
            this.cbClass.TabIndex = 42;
            this.cbClass.SelectionChangeCommitted += new System.EventHandler(this.cbClass_SelectionChangeCommitted);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClass.Location = new System.Drawing.Point(28, 20);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(69, 35);
            this.lblClass.TabIndex = 41;
            this.lblClass.Text = "班級";
            // 
            // btnLeast
            // 
            this.btnLeast.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLeast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeast.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLeast.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLeast.Location = new System.Drawing.Point(221, 8);
            this.btnLeast.Name = "btnLeast";
            this.btnLeast.Size = new System.Drawing.Size(160, 47);
            this.btnLeast.TabIndex = 43;
            this.btnLeast.Text = "櫃台管理";
            this.btnLeast.UseVisualStyleBackColor = false;
            this.btnLeast.Click += new System.EventHandler(this.btnLeast_Click);
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOr.Location = new System.Drawing.Point(387, 20);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(43, 35);
            this.lblOr.TabIndex = 44;
            this.lblOr.Text = "or";
            // 
            // btnSeZtuMe
            // 
            this.btnSeZtuMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeZtuMe.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSeZtuMe.Location = new System.Drawing.Point(1411, 2);
            this.btnSeZtuMe.Name = "btnSeZtuMe";
            this.btnSeZtuMe.Size = new System.Drawing.Size(97, 44);
            this.btnSeZtuMe.TabIndex = 45;
            this.btnSeZtuMe.Text = "說明";
            this.btnSeZtuMe.UseVisualStyleBackColor = true;
            this.btnSeZtuMe.Click += new System.EventHandler(this.btnSeZtuMe_Click);
            // 
            // image
            // 
            this.image.Image = global::Dingbendong.Properties.Resources.dandanHamburger;
            this.image.Location = new System.Drawing.Point(806, 2);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(705, 809);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 29;
            this.image.TabStop = false;
            // 
            // picIntro
            // 
            this.picIntro.Image = global::Dingbendong.Properties.Resources.intro;
            this.picIntro.Location = new System.Drawing.Point(461, 705);
            this.picIntro.Name = "picIntro";
            this.picIntro.Size = new System.Drawing.Size(623, 110);
            this.picIntro.TabIndex = 43;
            this.picIntro.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1520, 823);
            this.Controls.Add(this.picIntro);
            this.Controls.Add(this.btnSeZtuMe);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.btnLeast);
            this.Controls.Add(this.btnMaintain);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.lblTimeNow);
            this.Controls.Add(this.lblCut);
            this.Controls.Add(this.image);
            this.Controls.Add(this.gbMain);
            this.Name = "Form1";
            this.Text = "歡喜選午餐";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIntro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbStore_products;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbStores;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStudents;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbProduct_price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timerStar;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnMaintain;
        private System.Windows.Forms.Label lblChoosed;
        private System.Windows.Forms.Label lblCut;
        private System.Windows.Forms.Label lblTimeNow;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblStoreChoosed;
        private System.Windows.Forms.CheckBox chkStar;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.Button btnLeast;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Button btnSeZtuMe;
        private System.Windows.Forms.PictureBox picIntro;
        public System.Windows.Forms.Button btnSub;
    }
}

