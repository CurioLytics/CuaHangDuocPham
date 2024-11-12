using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Khám_chữa_bệnh
{
    public partial class FRMDMTHUOC : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, connstr;
        public FRMDMTHUOC()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Dock = DockStyle.Fill;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtLuongTon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FRMDMTHUOC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHieuThuoc.QL_Thuoc' table. You can move, or remove it, as needed.
            this.qL_ThuocTableAdapter.Fill(this.qLHieuThuoc.QL_Thuoc);

        }
    }
}
