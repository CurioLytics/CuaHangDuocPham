namespace Khám_chữa_bệnh
{
    partial class frmloaithuoc
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txttenloaithuoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.grloaithuoc = new System.Windows.Forms.DataGridView();
            this.tenloaithuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaithuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHieuThuoc = new Khám_chữa_bệnh.QLHieuThuoc();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btn3last = new System.Windows.Forms.Button();
            this.btn3next = new System.Windows.Forms.Button();
            this.btn3prv = new System.Windows.Forms.Button();
            this.btn3first = new System.Windows.Forms.Button();
            this.txttendonvi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grdtendonvi = new System.Windows.Forms.DataGridView();
            this.tendonviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTyLeQuyDoi = new System.Windows.Forms.TextBox();
            this.txtDonViQuyDoi = new System.Windows.Forms.TextBox();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprv = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.grquydoidv = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViQuyDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyLeQuyDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaithuocTableAdapter = new Khám_chữa_bệnh.QLHieuThuocTableAdapters.LoaithuocTableAdapter();
            this.donviTableAdapter = new Khám_chữa_bệnh.QLHieuThuocTableAdapters.donviTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grloaithuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaithuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHieuThuoc)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdtendonvi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donviBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grquydoidv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1143, 632);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txttenloaithuoc);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btntimkiem);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtKeyword);
            this.tabPage1.Controls.Add(this.grloaithuoc);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1135, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Loại thuốc";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txttenloaithuoc
            // 
            this.txttenloaithuoc.Location = new System.Drawing.Point(472, 186);
            this.txttenloaithuoc.Name = "txttenloaithuoc";
            this.txttenloaithuoc.Size = new System.Drawing.Size(187, 22);
            this.txttenloaithuoc.TabIndex = 6;
            this.txttenloaithuoc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên loại thuốc";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Location = new System.Drawing.Point(1, 528);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1131, 75);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(983, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 59);
            this.button1.TabIndex = 28;
            this.button1.Text = "Kết thúc";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(831, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 59);
            this.button2.TabIndex = 27;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(679, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 59);
            this.button3.TabIndex = 26;
            this.button3.Text = "Xóa ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(527, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 59);
            this.button4.TabIndex = 25;
            this.button4.Text = "Thêm mới";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Location = new System.Drawing.Point(226, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "Cuối ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button10.Location = new System.Drawing.Point(152, 31);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(68, 23);
            this.button10.TabIndex = 23;
            this.button10.Text = "Sau ";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button11.Location = new System.Drawing.Point(78, 31);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(68, 23);
            this.button11.TabIndex = 22;
            this.button11.Text = "Trước ";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button12.Location = new System.Drawing.Point(5, 31);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(67, 23);
            this.button12.TabIndex = 21;
            this.button12.Text = "Đầu";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(626, 38);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 3;
            this.btntimkiem.Text = "Tìm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(419, 41);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(187, 22);
            this.txtKeyword.TabIndex = 1;
            // 
            // grloaithuoc
            // 
            this.grloaithuoc.AutoGenerateColumns = false;
            this.grloaithuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grloaithuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenloaithuocDataGridViewTextBoxColumn});
            this.grloaithuoc.DataSource = this.loaithuocBindingSource;
            this.grloaithuoc.Location = new System.Drawing.Point(7, 4);
            this.grloaithuoc.Name = "grloaithuoc";
            this.grloaithuoc.RowHeadersWidth = 51;
            this.grloaithuoc.RowTemplate.Height = 24;
            this.grloaithuoc.Size = new System.Drawing.Size(248, 416);
            this.grloaithuoc.TabIndex = 0;
            this.grloaithuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grloaithuoc_CellContentClick);
            // 
            // tenloaithuocDataGridViewTextBoxColumn
            // 
            this.tenloaithuocDataGridViewTextBoxColumn.DataPropertyName = "tenloaithuoc";
            this.tenloaithuocDataGridViewTextBoxColumn.HeaderText = "Tên loại thuốc";
            this.tenloaithuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenloaithuocDataGridViewTextBoxColumn.Name = "tenloaithuocDataGridViewTextBoxColumn";
            this.tenloaithuocDataGridViewTextBoxColumn.Width = 125;
            // 
            // loaithuocBindingSource
            // 
            this.loaithuocBindingSource.DataMember = "Loaithuoc";
            this.loaithuocBindingSource.DataSource = this.qLHieuThuoc;
            // 
            // qLHieuThuoc
            // 
            this.qLHieuThuoc.DataSetName = "QLHieuThuoc";
            this.qLHieuThuoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.txttendonvi);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button13);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.grdtendonvi);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1135, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đơn vị tính";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.button14);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Controls.Add(this.button16);
            this.groupBox4.Controls.Add(this.button17);
            this.groupBox4.Controls.Add(this.btn3last);
            this.groupBox4.Controls.Add(this.btn3next);
            this.groupBox4.Controls.Add(this.btn3prv);
            this.groupBox4.Controls.Add(this.btn3first);
            this.groupBox4.Location = new System.Drawing.Point(1, 532);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1131, 75);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.Location = new System.Drawing.Point(983, 11);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(146, 59);
            this.button14.TabIndex = 28;
            this.button14.Text = "Kết thúc";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.Location = new System.Drawing.Point(831, 11);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(146, 59);
            this.button15.TabIndex = 27;
            this.button15.Text = "Cập nhật";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.Location = new System.Drawing.Point(679, 11);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(146, 59);
            this.button16.TabIndex = 26;
            this.button16.Text = "Xóa ";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.Location = new System.Drawing.Point(527, 11);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(146, 59);
            this.button17.TabIndex = 25;
            this.button17.Text = "Thêm mới";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // btn3last
            // 
            this.btn3last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn3last.Location = new System.Drawing.Point(226, 31);
            this.btn3last.Name = "btn3last";
            this.btn3last.Size = new System.Drawing.Size(61, 23);
            this.btn3last.TabIndex = 24;
            this.btn3last.Text = "Cuối ";
            this.btn3last.UseVisualStyleBackColor = true;
            this.btn3last.Click += new System.EventHandler(this.btn3last_Click);
            // 
            // btn3next
            // 
            this.btn3next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn3next.Location = new System.Drawing.Point(152, 31);
            this.btn3next.Name = "btn3next";
            this.btn3next.Size = new System.Drawing.Size(68, 23);
            this.btn3next.TabIndex = 23;
            this.btn3next.Text = "Sau ";
            this.btn3next.UseVisualStyleBackColor = true;
            this.btn3next.Click += new System.EventHandler(this.btn3next_Click);
            // 
            // btn3prv
            // 
            this.btn3prv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn3prv.Location = new System.Drawing.Point(78, 31);
            this.btn3prv.Name = "btn3prv";
            this.btn3prv.Size = new System.Drawing.Size(68, 23);
            this.btn3prv.TabIndex = 22;
            this.btn3prv.Text = "Trước ";
            this.btn3prv.UseVisualStyleBackColor = true;
            this.btn3prv.Click += new System.EventHandler(this.btn3prv_Click);
            // 
            // btn3first
            // 
            this.btn3first.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn3first.Location = new System.Drawing.Point(5, 31);
            this.btn3first.Name = "btn3first";
            this.btn3first.Size = new System.Drawing.Size(67, 23);
            this.btn3first.TabIndex = 21;
            this.btn3first.Text = "Đầu";
            this.btn3first.UseVisualStyleBackColor = true;
            this.btn3first.Click += new System.EventHandler(this.btn3first_Click);
            // 
            // txttendonvi
            // 
            this.txttendonvi.Location = new System.Drawing.Point(381, 318);
            this.txttendonvi.Name = "txttendonvi";
            this.txttendonvi.Size = new System.Drawing.Size(187, 22);
            this.txttendonvi.TabIndex = 11;
            this.txttendonvi.TextChanged += new System.EventHandler(this.txttendonvi_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Đơn vị tính";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(535, 170);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 9;
            this.button13.Text = "Tìm";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nhập";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(328, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 22);
            this.textBox2.TabIndex = 7;
            // 
            // grdtendonvi
            // 
            this.grdtendonvi.AutoGenerateColumns = false;
            this.grdtendonvi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdtendonvi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tendonviDataGridViewTextBoxColumn});
            this.grdtendonvi.DataSource = this.donviBindingSource;
            this.grdtendonvi.Location = new System.Drawing.Point(3, 3);
            this.grdtendonvi.Name = "grdtendonvi";
            this.grdtendonvi.RowHeadersWidth = 51;
            this.grdtendonvi.RowTemplate.Height = 24;
            this.grdtendonvi.Size = new System.Drawing.Size(248, 416);
            this.grdtendonvi.TabIndex = 1;
            this.grdtendonvi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdtendonvi_CellContentClick);
            // 
            // tendonviDataGridViewTextBoxColumn
            // 
            this.tendonviDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tendonviDataGridViewTextBoxColumn.DataPropertyName = "tendonvi";
            this.tendonviDataGridViewTextBoxColumn.HeaderText = "Danh sách đơn vị tính";
            this.tendonviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tendonviDataGridViewTextBoxColumn.Name = "tendonviDataGridViewTextBoxColumn";
            this.tendonviDataGridViewTextBoxColumn.Width = 119;
            // 
            // donviBindingSource
            // 
            this.donviBindingSource.DataMember = "donvi";
            this.donviBindingSource.DataSource = this.qLHieuThuoc;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.grquydoidv);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1135, 603);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quy đổi ĐVT";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtTyLeQuyDoi);
            this.groupBox2.Controls.Add(this.txtDonViQuyDoi);
            this.groupBox2.Controls.Add(this.txtMaThuoc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(530, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 519);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtTyLeQuyDoi
            // 
            this.txtTyLeQuyDoi.Location = new System.Drawing.Point(153, 268);
            this.txtTyLeQuyDoi.Name = "txtTyLeQuyDoi";
            this.txtTyLeQuyDoi.Size = new System.Drawing.Size(236, 22);
            this.txtTyLeQuyDoi.TabIndex = 5;
            // 
            // txtDonViQuyDoi
            // 
            this.txtDonViQuyDoi.Location = new System.Drawing.Point(153, 207);
            this.txtDonViQuyDoi.Name = "txtDonViQuyDoi";
            this.txtDonViQuyDoi.Size = new System.Drawing.Size(236, 22);
            this.txtDonViQuyDoi.TabIndex = 4;
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Location = new System.Drawing.Point(153, 145);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(236, 22);
            this.txtMaThuoc.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tỷ lệ quy đổi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đơn vị quy đổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Thuốc";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.btnlast);
            this.groupBox1.Controls.Add(this.btnnext);
            this.groupBox1.Controls.Add(this.btnprv);
            this.groupBox1.Controls.Add(this.btnfirst);
            this.groupBox1.Location = new System.Drawing.Point(3, 527);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Location = new System.Drawing.Point(983, 11);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(146, 59);
            this.button9.TabIndex = 28;
            this.button9.Text = "Kết thúc";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(831, 11);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(146, 59);
            this.button8.TabIndex = 27;
            this.button8.Text = "Cập nhật";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(679, 11);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(146, 59);
            this.button7.TabIndex = 26;
            this.button7.Text = "Xóa ";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(527, 11);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 59);
            this.button6.TabIndex = 25;
            this.button6.Text = "Thêm mới";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnlast
            // 
            this.btnlast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnlast.Location = new System.Drawing.Point(226, 31);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(61, 23);
            this.btnlast.TabIndex = 24;
            this.btnlast.Text = "Cuối ";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnnext
            // 
            this.btnnext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnnext.Location = new System.Drawing.Point(152, 31);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(68, 23);
            this.btnnext.TabIndex = 23;
            this.btnnext.Text = "Sau ";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprv
            // 
            this.btnprv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnprv.Location = new System.Drawing.Point(78, 31);
            this.btnprv.Name = "btnprv";
            this.btnprv.Size = new System.Drawing.Size(68, 23);
            this.btnprv.TabIndex = 22;
            this.btnprv.Text = "Trước ";
            this.btnprv.UseVisualStyleBackColor = true;
            this.btnprv.Click += new System.EventHandler(this.btnprv_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnfirst.Location = new System.Drawing.Point(5, 31);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(67, 23);
            this.btnfirst.TabIndex = 21;
            this.btnfirst.Text = "Đầu";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // grquydoidv
            // 
            this.grquydoidv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grquydoidv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grquydoidv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grquydoidv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.DonViQuyDoi,
            this.TyLeQuyDoi});
            this.grquydoidv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grquydoidv.Location = new System.Drawing.Point(3, 3);
            this.grquydoidv.Name = "grquydoidv";
            this.grquydoidv.RowHeadersWidth = 51;
            this.grquydoidv.RowTemplate.Height = 24;
            this.grquydoidv.Size = new System.Drawing.Size(1129, 597);
            this.grquydoidv.TabIndex = 0;
            this.grquydoidv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grquydoidv_CellClick);
            // 
            // MaThuoc
            // 
            this.MaThuoc.DataPropertyName = "MaThuoc";
            this.MaThuoc.HeaderText = "Mã Thuốc";
            this.MaThuoc.MinimumWidth = 6;
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.ReadOnly = true;
            this.MaThuoc.Width = 96;
            // 
            // DonViQuyDoi
            // 
            this.DonViQuyDoi.DataPropertyName = "DonViQuyDoi";
            this.DonViQuyDoi.HeaderText = "Đơn vị quy đổi";
            this.DonViQuyDoi.MinimumWidth = 6;
            this.DonViQuyDoi.Name = "DonViQuyDoi";
            this.DonViQuyDoi.Width = 120;
            // 
            // TyLeQuyDoi
            // 
            this.TyLeQuyDoi.DataPropertyName = "TyLeQuyDoi";
            this.TyLeQuyDoi.HeaderText = "Tỷ Lệ Quy Đổi";
            this.TyLeQuyDoi.MinimumWidth = 6;
            this.TyLeQuyDoi.Name = "TyLeQuyDoi";
            this.TyLeQuyDoi.Width = 120;
            // 
            // loaithuocTableAdapter
            // 
            this.loaithuocTableAdapter.ClearBeforeFill = true;
            // 
            // donviTableAdapter
            // 
            this.donviTableAdapter.ClearBeforeFill = true;
            // 
            // frmloaithuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 632);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmloaithuoc";
            this.Text = "frmloaithuoc";
            this.Load += new System.EventHandler(this.frmloaithuoc_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grloaithuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaithuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHieuThuoc)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdtendonvi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donviBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grquydoidv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView grloaithuoc;
        private QLHieuThuoc qLHieuThuoc;
        private System.Windows.Forms.BindingSource loaithuocBindingSource;
        private QLHieuThuocTableAdapters.LoaithuocTableAdapter loaithuocTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridView grquydoidv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViQuyDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyLeQuyDoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTyLeQuyDoi;
        private System.Windows.Forms.TextBox txtDonViQuyDoi;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprv;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource donviBindingSource;
        private QLHieuThuocTableAdapters.donviTableAdapter donviTableAdapter;
        private System.Windows.Forms.TextBox txttenloaithuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaithuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button btn3last;
        private System.Windows.Forms.Button btn3next;
        private System.Windows.Forms.Button btn3prv;
        private System.Windows.Forms.Button btn3first;
        private System.Windows.Forms.TextBox txttendonvi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView grdtendonvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendonviDataGridViewTextBoxColumn;
    }
}