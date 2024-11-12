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
    public partial class frmncc : Form
    {
        SqlConnection conn = new SqlConnection();
        string ketnoi = "Data Source=DESKTOP-5EDT0LC;Initial Catalog=QLHT;Integrated Security=True;Encrypt=False";
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, connstr;
        public frmncc()
        {
            InitializeComponent();
        }

        private void frmncc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHieuThuoc.QuyDoiDonVi' table. You can move, or remove it, as needed.
            this.quyDoiDonViTableAdapter.Fill(this.qLHieuThuoc.QuyDoiDonVi);
            // TODO: This line of code loads data into the 'qLHieuThuoc.ncc' table. You can move, or remove it, as needed.
            this.nccTableAdapter.Fill(this.qLHieuThuoc.ncc);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            /*
             grdmncc.ClearSelection();
             grdmncc.CurrentCell=grdmncc[0,0];
             napCT();
             */

        }
    }
}
