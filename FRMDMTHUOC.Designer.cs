namespace Khám_chữa_bệnh
{
    partial class FRMDMTHUOC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLuongTon = new System.Windows.Forms.ComboBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.txthangsx = new System.Windows.Forms.TextBox();
            this.qLThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHieuThuoc = new Khám_chữa_bệnh.QLHieuThuoc();
            this.txtdvcoso = new System.Windows.Forms.TextBox();
            this.txttenloaithuoc = new System.Windows.Forms.TextBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.button1 = new ReaLTaiizor.Controls.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LuongTon = new System.Windows.Forms.Label();
            this.hangsx = new System.Windows.Forms.Label();
            this.dvcoso = new System.Windows.Forms.Label();
            this.tenloaithuoc = new System.Windows.Forms.Label();
            this.TenThuoc = new System.Windows.Forms.Label();
            this.MaThuoc = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new ReaLTaiizor.Controls.Button();
            this.button5 = new ReaLTaiizor.Controls.Button();
            this.button4 = new ReaLTaiizor.Controls.Button();
            this.button3 = new ReaLTaiizor.Controls.Button();
            this.button2 = new ReaLTaiizor.Controls.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaithuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvcosoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangsxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qL_ThuocTableAdapter = new Khám_chữa_bệnh.QLHieuThuocTableAdapters.QL_ThuocTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHieuThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.txtLuongTon);
            this.groupBox1.Controls.Add(this.txtghichu);
            this.groupBox1.Controls.Add(this.txthangsx);
            this.groupBox1.Controls.Add(this.txtdvcoso);
            this.groupBox1.Controls.Add(this.txttenloaithuoc);
            this.groupBox1.Controls.Add(this.txtTenThuoc);
            this.groupBox1.Controls.Add(this.txtMaThuoc);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LuongTon);
            this.groupBox1.Controls.Add(this.hangsx);
            this.groupBox1.Controls.Add(this.dvcoso);
            this.groupBox1.Controls.Add(this.tenloaithuoc);
            this.groupBox1.Controls.Add(this.TenThuoc);
            this.groupBox1.Controls.Add(this.MaThuoc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1125, 381);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thuốc";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtLuongTon
            // 
            this.txtLuongTon.DropDownWidth = 377;
            this.txtLuongTon.FormattingEnabled = true;
            this.txtLuongTon.ItemHeight = 25;
            this.txtLuongTon.Location = new System.Drawing.Point(161, 321);
            this.txtLuongTon.Name = "txtLuongTon";
            this.txtLuongTon.Size = new System.Drawing.Size(377, 33);
            this.txtLuongTon.TabIndex = 16;
            this.txtLuongTon.SelectedIndexChanged += new System.EventHandler(this.txtLuongTon_SelectedIndexChanged);
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(726, 257);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(377, 106);
            this.txtghichu.TabIndex = 15;
            // 
            // txthangsx
            // 
            this.txthangsx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qLThuocBindingSource, "hangsx", true));
            this.txthangsx.Location = new System.Drawing.Point(161, 254);
            this.txthangsx.Multiline = true;
            this.txthangsx.Name = "txthangsx";
            this.txthangsx.Size = new System.Drawing.Size(377, 50);
            this.txthangsx.TabIndex = 13;
            // 
            // qLThuocBindingSource
            // 
            this.qLThuocBindingSource.DataMember = "QL_Thuoc";
            this.qLThuocBindingSource.DataSource = this.qLHieuThuoc;
            // 
            // qLHieuThuoc
            // 
            this.qLHieuThuoc.DataSetName = "QLHieuThuoc";
            this.qLHieuThuoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtdvcoso
            // 
            this.txtdvcoso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qLThuocBindingSource, "dvcoso", true));
            this.txtdvcoso.Location = new System.Drawing.Point(161, 198);
            this.txtdvcoso.Multiline = true;
            this.txtdvcoso.Name = "txtdvcoso";
            this.txtdvcoso.Size = new System.Drawing.Size(377, 50);
            this.txtdvcoso.TabIndex = 12;
            // 
            // txttenloaithuoc
            // 
            this.txttenloaithuoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qLThuocBindingSource, "tenloaithuoc", true));
            this.txttenloaithuoc.Location = new System.Drawing.Point(161, 142);
            this.txttenloaithuoc.Multiline = true;
            this.txttenloaithuoc.Name = "txttenloaithuoc";
            this.txttenloaithuoc.Size = new System.Drawing.Size(377, 50);
            this.txttenloaithuoc.TabIndex = 11;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qLThuocBindingSource, "TenThuoc", true));
            this.txtTenThuoc.Location = new System.Drawing.Point(161, 86);
            this.txtTenThuoc.Multiline = true;
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(377, 50);
            this.txtTenThuoc.TabIndex = 10;
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qLThuocBindingSource, "MaThuoc", true));
            this.txtMaThuoc.Location = new System.Drawing.Point(161, 30);
            this.txtMaThuoc.Multiline = true;
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(377, 50);
            this.txtMaThuoc.TabIndex = 9;
            this.txtMaThuoc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Image = null;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Location = new System.Drawing.Point(600, 30);
            this.button1.Name = "button1";
            this.button1.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ảnh";
            this.button1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(726, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 204);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(615, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ghi chú";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LuongTon
            // 
            this.LuongTon.AutoSize = true;
            this.LuongTon.Location = new System.Drawing.Point(19, 324);
            this.LuongTon.Name = "LuongTon";
            this.LuongTon.Size = new System.Drawing.Size(90, 25);
            this.LuongTon.TabIndex = 5;
            this.LuongTon.Text = "Số lượng";
            this.LuongTon.Click += new System.EventHandler(this.label6_Click);
            // 
            // hangsx
            // 
            this.hangsx.AutoSize = true;
            this.hangsx.Location = new System.Drawing.Point(19, 270);
            this.hangsx.Name = "hangsx";
            this.hangsx.Size = new System.Drawing.Size(138, 25);
            this.hangsx.TabIndex = 4;
            this.hangsx.Text = "Hãng sản xuất";
            // 
            // dvcoso
            // 
            this.dvcoso.AutoSize = true;
            this.dvcoso.Location = new System.Drawing.Point(19, 219);
            this.dvcoso.Name = "dvcoso";
            this.dvcoso.Size = new System.Drawing.Size(97, 25);
            this.dvcoso.TabIndex = 3;
            this.dvcoso.Text = "DV Cơ sở";
            // 
            // tenloaithuoc
            // 
            this.tenloaithuoc.AutoSize = true;
            this.tenloaithuoc.Location = new System.Drawing.Point(19, 160);
            this.tenloaithuoc.Name = "tenloaithuoc";
            this.tenloaithuoc.Size = new System.Drawing.Size(102, 25);
            this.tenloaithuoc.TabIndex = 2;
            this.tenloaithuoc.Text = "Loại thuốc";
            // 
            // TenThuoc
            // 
            this.TenThuoc.AutoSize = true;
            this.TenThuoc.Location = new System.Drawing.Point(19, 102);
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.Size = new System.Drawing.Size(100, 25);
            this.TenThuoc.TabIndex = 1;
            this.TenThuoc.Text = "Tên thuốc";
            // 
            // MaThuoc
            // 
            this.MaThuoc.AutoSize = true;
            this.MaThuoc.Location = new System.Drawing.Point(19, 48);
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.Size = new System.Drawing.Size(93, 25);
            this.MaThuoc.TabIndex = 0;
            this.MaThuoc.Text = "Mã thuốc";
            this.MaThuoc.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 698);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1125, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button6.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button6.Image = null;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button6.Location = new System.Drawing.Point(574, 13);
            this.button6.Name = "button6";
            this.button6.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button6.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button6.Size = new System.Drawing.Size(120, 40);
            this.button6.TabIndex = 4;
            this.button6.Text = "Thoát";
            this.button6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button5.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.Image = null;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button5.Location = new System.Drawing.Point(431, 13);
            this.button5.Name = "button5";
            this.button5.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button5.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button5.Size = new System.Drawing.Size(120, 40);
            this.button5.TabIndex = 3;
            this.button5.Text = "Bỏ qua";
            this.button5.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button4.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Image = null;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button4.Location = new System.Drawing.Point(291, 13);
            this.button4.Name = "button4";
            this.button4.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button4.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button4.Size = new System.Drawing.Size(120, 40);
            this.button4.TabIndex = 2;
            this.button4.Text = "Xóa";
            this.button4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button3.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Image = null;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button3.Location = new System.Drawing.Point(146, 13);
            this.button3.Name = "button3";
            this.button3.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button3.Size = new System.Drawing.Size(120, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "Sửa";
            this.button3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button2.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Image = null;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button2.Location = new System.Drawing.Point(6, 13);
            this.button2.Name = "button2";
            this.button2.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Thêm ";
            this.button2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThuocDataGridViewTextBoxColumn,
            this.tenThuocDataGridViewTextBoxColumn,
            this.tenloaithuocDataGridViewTextBoxColumn,
            this.dvcosoDataGridViewTextBoxColumn,
            this.hangsxDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.qLThuocBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 381);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1125, 317);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maThuocDataGridViewTextBoxColumn
            // 
            this.maThuocDataGridViewTextBoxColumn.DataPropertyName = "MaThuoc";
            this.maThuocDataGridViewTextBoxColumn.HeaderText = "MaThuoc";
            this.maThuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maThuocDataGridViewTextBoxColumn.Name = "maThuocDataGridViewTextBoxColumn";
            this.maThuocDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenThuocDataGridViewTextBoxColumn
            // 
            this.tenThuocDataGridViewTextBoxColumn.DataPropertyName = "TenThuoc";
            this.tenThuocDataGridViewTextBoxColumn.HeaderText = "TenThuoc";
            this.tenThuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenThuocDataGridViewTextBoxColumn.Name = "tenThuocDataGridViewTextBoxColumn";
            this.tenThuocDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenloaithuocDataGridViewTextBoxColumn
            // 
            this.tenloaithuocDataGridViewTextBoxColumn.DataPropertyName = "tenloaithuoc";
            this.tenloaithuocDataGridViewTextBoxColumn.HeaderText = "tenloaithuoc";
            this.tenloaithuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenloaithuocDataGridViewTextBoxColumn.Name = "tenloaithuocDataGridViewTextBoxColumn";
            this.tenloaithuocDataGridViewTextBoxColumn.Width = 125;
            // 
            // dvcosoDataGridViewTextBoxColumn
            // 
            this.dvcosoDataGridViewTextBoxColumn.DataPropertyName = "dvcoso";
            this.dvcosoDataGridViewTextBoxColumn.HeaderText = "dvcoso";
            this.dvcosoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dvcosoDataGridViewTextBoxColumn.Name = "dvcosoDataGridViewTextBoxColumn";
            this.dvcosoDataGridViewTextBoxColumn.Width = 125;
            // 
            // hangsxDataGridViewTextBoxColumn
            // 
            this.hangsxDataGridViewTextBoxColumn.DataPropertyName = "hangsx";
            this.hangsxDataGridViewTextBoxColumn.HeaderText = "hangsx";
            this.hangsxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hangsxDataGridViewTextBoxColumn.Name = "hangsxDataGridViewTextBoxColumn";
            this.hangsxDataGridViewTextBoxColumn.Width = 125;
            // 
            // qL_ThuocTableAdapter
            // 
            this.qL_ThuocTableAdapter.ClearBeforeFill = true;
            // 
            // FRMDMTHUOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 787);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMDMTHUOC";
            this.Text = "Danh mục thuốc";
            this.Load += new System.EventHandler(this.FRMDMTHUOC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHieuThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private ReaLTaiizor.Controls.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LuongTon;
        private System.Windows.Forms.Label hangsx;
        private System.Windows.Forms.Label dvcoso;
        private System.Windows.Forms.Label tenloaithuoc;
        private System.Windows.Forms.Label TenThuoc;
        private System.Windows.Forms.Label MaThuoc;
        private System.Windows.Forms.TextBox txthangsx;
        private System.Windows.Forms.TextBox txtdvcoso;
        private System.Windows.Forms.TextBox txttenloaithuoc;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.ComboBox txtLuongTon;
        private ReaLTaiizor.Controls.Button button6;
        private ReaLTaiizor.Controls.Button button5;
        private ReaLTaiizor.Controls.Button button4;
        private ReaLTaiizor.Controls.Button button3;
        private ReaLTaiizor.Controls.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLHieuThuoc qLHieuThuoc;
        private System.Windows.Forms.BindingSource qLThuocBindingSource;
        private QLHieuThuocTableAdapters.QL_ThuocTableAdapter qL_ThuocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaithuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvcosoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangsxDataGridViewTextBoxColumn;
    }
}