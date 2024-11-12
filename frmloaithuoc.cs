using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khám_chữa_bệnh
{
    public partial class frmloaithuoc : Form
    {
        SqlConnection conn = new SqlConnection();
        string ketnoi = "Data Source=DESKTOP-5EDT0LC;Initial Catalog=QLHT;Integrated Security=True;Encrypt=False";
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, connstr;
        public frmloaithuoc()
        {
            InitializeComponent();
        }

        private void frmloaithuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHieuThuoc.donvi' table. You can move, or remove it, as needed.
            this.donviTableAdapter.Fill(this.qLHieuThuoc.donvi);
            // TODO: This line of code loads data into the 'qLHieuThuoc.Loaithuoc' table. You can move, or remove it, as needed.
            this.loaithuocTableAdapter.Fill(this.qLHieuThuoc.Loaithuoc);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void LoadGridByKeyword()
        {
            //SqlConnection ketnoi = new SqlConnection();
            //dataGridView1.DataSource=ketnoi.


        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            connstr = ketnoi;
            conn.ConnectionString = connstr;
            conn.Open();
            sql = "Select*From dbo.QuyDoiDonVi order by MaThuoc";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grquydoidv.DataSource = dt;
            grquydoidv.Refresh();
            NapCT();
        }

        private void grquydoidv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            grquydoidv.ClearSelection();
            grquydoidv.CurrentCell = grquydoidv[0,0];
            NapCT();
        }

        private void btnprv_Click(object sender, EventArgs e)
        {
            int i = grquydoidv.CurrentRow.Index;
            if (i > 0)
            {
                grquydoidv.CurrentCell = grquydoidv[0, i-1];
                NapCT();
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            int i = grquydoidv.CurrentRow.Index;
            if (i < grquydoidv.RowCount - 1 )
            {
                grquydoidv.CurrentCell = grquydoidv[0, i + 1];
                NapCT();
            }
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            grquydoidv.ClearSelection();
            grquydoidv.CurrentCell = grquydoidv[0, grquydoidv.RowCount - 1];
            NapCT();
        }
        public void Naploaithuoc()
        {
            int i = grloaithuoc.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txttenloaithuoc.Text = grloaithuoc.Rows[i].Cells["tenloaithuoc"].Value.ToString();
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Naploaithuoc();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            grloaithuoc.ClearSelection();
            grloaithuoc.CurrentCell = grloaithuoc[0, 0];
            Naploaithuoc();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int i = grloaithuoc.CurrentRow.Index;
            if (i > 0)
            {
                grloaithuoc.CurrentCell = grloaithuoc[0, i - 1];
                Naploaithuoc();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int i = grloaithuoc.CurrentRow.Index;
            if (i < grloaithuoc.RowCount - 1)
            {
                grloaithuoc.CurrentCell = grloaithuoc[0, i + 1];
                Naploaithuoc();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            grloaithuoc.ClearSelection();
            grloaithuoc.CurrentCell = grloaithuoc[0, grloaithuoc.RowCount - 1];
            Naploaithuoc();
        }
        public void Napdonvi()
        {
            int i = grdtendonvi.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txttendonvi.Text = grdtendonvi.Rows[i].Cells["tendonvi"].Value.ToString();

        }
        private void grdtendonvi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grloaithuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttendonvi_TextChanged(object sender, EventArgs e)
        {
            Napdonvi();
        }

        private void btn3first_Click(object sender, EventArgs e)
        {
            grdtendonvi.ClearSelection();
            grdtendonvi.CurrentCell = grdtendonvi[0, 0];
            Napdonvi();
        }

        private void btn3prv_Click(object sender, EventArgs e)
        {
            int i = grdtendonvi.CurrentRow.Index;
            if (i > 0)
            {
                grdtendonvi.CurrentCell = grdtendonvi[0, i - 1];
                Napdonvi();
            }
        }

        private void btn3next_Click(object sender, EventArgs e)
        {
            int i = grdtendonvi.CurrentRow.Index;
            if (i < grdtendonvi.RowCount - 1)
            {
                grdtendonvi.CurrentCell = grdtendonvi[0, i + 1];
                Napdonvi();
            }
        }

        private void btn3last_Click(object sender, EventArgs e)
        {
            grdtendonvi.ClearSelection();
            grdtendonvi.CurrentCell = grdtendonvi[0, grdtendonvi.RowCount - 1];
            Napdonvi();
        }

        public void NapCT()
        {
            int i = grquydoidv.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtMaThuoc.Text = grquydoidv.Rows[i].Cells["MaThuoc"].Value.ToString();
            txtDonViQuyDoi.Text = grquydoidv.Rows[i].Cells["DonViQuyDoi"].Value.ToString();
            txtTyLeQuyDoi.Text = grquydoidv.Rows[i].Cells["TyLeQuyDoi"].Value.ToString();
            
        }
    }
}
