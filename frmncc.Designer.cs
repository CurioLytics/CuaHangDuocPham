namespace Khám_chữa_bệnh
{
    partial class frmncc
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
            this.grdmncc = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViQuyDoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyLeQuyDoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyDoiDonViBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHieuThuoc = new Khám_chữa_bệnh.QLHieuThuoc();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprv = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.nccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nccTableAdapter = new Khám_chữa_bệnh.QLHieuThuocTableAdapters.nccTableAdapter();
            this.quyDoiDonViTableAdapter = new Khám_chữa_bệnh.QLHieuThuocTableAdapters.QuyDoiDonViTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grdmncc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyDoiDonViBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHieuThuoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nccBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdmncc
            // 
            this.grdmncc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdmncc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdmncc.Controls.Add(this.dataGridView1);
            this.grdmncc.Location = new System.Drawing.Point(0, 3);
            this.grdmncc.Name = "grdmncc";
            this.grdmncc.Size = new System.Drawing.Size(810, 505);
            this.grdmncc.TabIndex = 1;
            this.grdmncc.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThuocDataGridViewTextBoxColumn,
            this.donViQuyDoiDataGridViewTextBoxColumn,
            this.tyLeQuyDoiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.quyDoiDonViBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 484);
            this.dataGridView1.TabIndex = 0;
            // 
            // maThuocDataGridViewTextBoxColumn
            // 
            this.maThuocDataGridViewTextBoxColumn.DataPropertyName = "MaThuoc";
            this.maThuocDataGridViewTextBoxColumn.HeaderText = "MaThuoc";
            this.maThuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maThuocDataGridViewTextBoxColumn.Name = "maThuocDataGridViewTextBoxColumn";
            this.maThuocDataGridViewTextBoxColumn.Width = 125;
            // 
            // donViQuyDoiDataGridViewTextBoxColumn
            // 
            this.donViQuyDoiDataGridViewTextBoxColumn.DataPropertyName = "DonViQuyDoi";
            this.donViQuyDoiDataGridViewTextBoxColumn.HeaderText = "DonViQuyDoi";
            this.donViQuyDoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donViQuyDoiDataGridViewTextBoxColumn.Name = "donViQuyDoiDataGridViewTextBoxColumn";
            this.donViQuyDoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tyLeQuyDoiDataGridViewTextBoxColumn
            // 
            this.tyLeQuyDoiDataGridViewTextBoxColumn.DataPropertyName = "TyLeQuyDoi";
            this.tyLeQuyDoiDataGridViewTextBoxColumn.HeaderText = "TyLeQuyDoi";
            this.tyLeQuyDoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tyLeQuyDoiDataGridViewTextBoxColumn.Name = "tyLeQuyDoiDataGridViewTextBoxColumn";
            this.tyLeQuyDoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // quyDoiDonViBindingSource
            // 
            this.quyDoiDonViBindingSource.DataMember = "QuyDoiDonVi";
            this.quyDoiDonViBindingSource.DataSource = this.qLHieuThuoc;
            // 
            // qLHieuThuoc
            // 
            this.qLHieuThuoc.DataSetName = "QLHieuThuoc";
            this.qLHieuThuoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.btnlast);
            this.groupBox2.Controls.Add(this.btnnext);
            this.groupBox2.Controls.Add(this.btnprv);
            this.groupBox2.Controls.Add(this.btnfirst);
            this.groupBox2.Location = new System.Drawing.Point(0, 511);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1410, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Location = new System.Drawing.Point(1256, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(146, 59);
            this.button9.TabIndex = 24;
            this.button9.Text = "Kết thúc";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(1104, 7);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(146, 59);
            this.button8.TabIndex = 23;
            this.button8.Text = "Cập nhật";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(952, 7);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(146, 59);
            this.button7.TabIndex = 22;
            this.button7.Text = "Xóa ";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(800, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 59);
            this.button6.TabIndex = 21;
            this.button6.Text = "Thêm mới";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnlast
            // 
            this.btnlast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnlast.Location = new System.Drawing.Point(227, 21);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(61, 23);
            this.btnlast.TabIndex = 20;
            this.btnlast.Text = "Cuối ";
            this.btnlast.UseVisualStyleBackColor = true;
            // 
            // btnnext
            // 
            this.btnnext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnnext.Location = new System.Drawing.Point(153, 21);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(68, 23);
            this.btnnext.TabIndex = 19;
            this.btnnext.Text = "Sau ";
            this.btnnext.UseVisualStyleBackColor = true;
            // 
            // btnprv
            // 
            this.btnprv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnprv.Location = new System.Drawing.Point(79, 21);
            this.btnprv.Name = "btnprv";
            this.btnprv.Size = new System.Drawing.Size(68, 23);
            this.btnprv.TabIndex = 18;
            this.btnprv.Text = "Trước ";
            this.btnprv.UseVisualStyleBackColor = true;
            // 
            // btnfirst
            // 
            this.btnfirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnfirst.Location = new System.Drawing.Point(6, 21);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(67, 23);
            this.btnfirst.TabIndex = 17;
            this.btnfirst.Text = "Đầu";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(816, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(597, 501);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nccBindingSource, "email", true));
            this.textBox7.Location = new System.Drawing.Point(136, 452);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(295, 22);
            this.textBox7.TabIndex = 14;
            // 
            // nccBindingSource
            // 
            this.nccBindingSource.DataMember = "ncc";
            this.nccBindingSource.DataSource = this.qLHieuThuoc;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nccBindingSource, "sodienthoai", true));
            this.textBox6.Location = new System.Drawing.Point(136, 412);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(295, 22);
            this.textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nccBindingSource, "diachi", true));
            this.textBox5.Location = new System.Drawing.Point(136, 364);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(295, 22);
            this.textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nccBindingSource, "tenloai", true));
            this.textBox4.Location = new System.Drawing.Point(136, 320);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(295, 22);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nccBindingSource, "tenncc", true));
            this.textBox3.Location = new System.Drawing.Point(136, 280);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(295, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nccBindingSource, "mancc", true));
            this.textBox2.Location = new System.Drawing.Point(136, 237);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hình ảnh minh họa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại NCC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên NCC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NCC";
            // 
            // nccTableAdapter
            // 
            this.nccTableAdapter.ClearBeforeFill = true;
            // 
            // quyDoiDonViTableAdapter
            // 
            this.quyDoiDonViTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(165, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 97);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmncc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 580);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grdmncc);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmncc";
            this.Text = "frmncc";
            this.Load += new System.EventHandler(this.frmncc_Load);
            this.grdmncc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyDoiDonViBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHieuThuoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nccBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grdmncc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLHieuThuoc qLHieuThuoc;
        private System.Windows.Forms.BindingSource nccBindingSource;
        private QLHieuThuocTableAdapters.nccTableAdapter nccTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprv;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.BindingSource quyDoiDonViBindingSource;
        private QLHieuThuocTableAdapters.QuyDoiDonViTableAdapter quyDoiDonViTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViQuyDoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyLeQuyDoiDataGridViewTextBoxColumn;
    }
}