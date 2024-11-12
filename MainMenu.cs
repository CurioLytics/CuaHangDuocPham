using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khám_chữa_bệnh
{
    public partial class MainMenu : Form
    {
        FRMNHANVIEN nhanvien;
        FRMBENHNHAN benhnhan;
        FRMDMTHUOC dmthuoc;
        FRMHOADON hoadon;
        FRMBAOCAO baocao;
        FRMLOGIN login;
        frmnccfull ncc;
        frmloaithuoc loaithuoc;


        public MainMenu()
        {
            InitializeComponent();
        }
        bool menuExpand = false;
        private void MENUTRANSITION_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                CTN_CHUCNANG.Height += 10;

                if (CTN_CHUCNANG.Height >= 192)
                {
                    MENUTRANSITION.Stop();
                    menuExpand = true;
                }

            }
            else
            {
                CTN_CHUCNANG.Height -= 10;

                if (CTN_CHUCNANG.Height <= 48)
                {
                    MENUTRANSITION.Stop();
                    menuExpand = false;
                }

            }

        }


        private void BTN_QLDM_Click(object sender, EventArgs e)
        {
            MENUTRANSITION.Start();
        }
        bool sidebarExpand = true;
        private void sidebartransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pnl_sidebar.Width -= 7;
                if (pnl_sidebar.Width <= 52)
                {
                    sidebarExpand = false;
                    sidebartransition.Stop();

                    CTN_TRANGCHU.Width = pnl_sidebar.Width;
                    CTN_CHUCNANG.Width = pnl_sidebar.Width;
                    CTN_HoaDon.Width = pnl_sidebar.Width;
                    CTN_BAOCAO.Width = pnl_sidebar.Width;
                    CTN_LOGOUT.Width = pnl_sidebar.Width;
                }
            }
            else
            {
                pnl_sidebar.Width += 7;
                if (pnl_sidebar.Width >= 295)
                {
                    sidebarExpand = true;
                    sidebartransition.Stop();

                    CTN_TRANGCHU.Width = pnl_sidebar.Width;
                    CTN_CHUCNANG.Width = pnl_sidebar.Width;
                    CTN_HoaDon.Width = pnl_sidebar.Width;
                    CTN_BAOCAO.Width = pnl_sidebar.Width;
                    CTN_LOGOUT.Width = pnl_sidebar.Width;

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
        }

        private void BTN_HOADON_Click(object sender, EventArgs e)
        {
            if (hoadon == null)
            {
                hoadon = new FRMHOADON();
                hoadon.FormClosed += Hoadon_FormClosed;
                hoadon.MdiParent = this;
                hoadon.Show();
            }
            else
            {
                hoadon.Activate();
            }
        }

        private void Hoadon_FormClosed(object sender, FormClosedEventArgs e)
        {
            hoadon = null;
        }

        private void BTN_NhanVien_Click(object sender, EventArgs e)
        {
            if (nhanvien == null)
            {
                nhanvien = new FRMNHANVIEN();
                nhanvien.FormClosed += Nhanvien_FormClosed;
                nhanvien.MdiParent = this;
                nhanvien.Dock = DockStyle.Fill;
                nhanvien.Show();
            }
            else
            {
                nhanvien.Activate();
            }
        }

        private void Nhanvien_FormClosed(object sender, FormClosedEventArgs e)
        {
            nhanvien = null;
        }

        private void BTN_TrangChu_Click(object sender, EventArgs e)
        {

        }

        private void BTN_XetNghiem_Click(object sender, EventArgs e)
        {

        }

        private void CTN_TRANGCHU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTN_BenhNhan_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ctndanhmuc_Paint(object sender, PaintEventArgs e)
        {

        }
        bool menutrans2Expand = false;
        private void menutrans2_Tick(object sender, EventArgs e)
        {
            if (menutrans2Expand == false)
            {
                ctndanhmuc.Height += 10;

                if (ctndanhmuc.Height >= 239)
                {
                    menutrans2.Stop();
                    menutrans2Expand = true;
                }

            }
            else
            {
                ctndanhmuc.Height -= 10;

                if (ctndanhmuc.Height <= 48)
                {
                    menutrans2.Stop();
                    menutrans2Expand = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menutrans2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BTN_KhamBenh_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Thuoc_Click(object sender, EventArgs e)
        {
            
            if (dmthuoc == null)
            {
                dmthuoc = new FRMDMTHUOC();
                dmthuoc.FormClosed += dmthuoc_FormClosed;
                dmthuoc.MdiParent = this;
                dmthuoc.Dock = DockStyle.Fill;
                dmthuoc.Show();
            }
            else
            {
                dmthuoc.Activate();
            }

        }

        private void dmthuoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            dmthuoc = null;
        }
        private void BTN_Login_Click(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnncc_Click(object sender, EventArgs e)
        {

            if (ncc == null)
            {
                ncc = new frmnccfull();
                ncc.FormClosed += ncc_FormClosed;
                ncc.MdiParent = this;
                ncc.Dock = DockStyle.Fill;
                ncc.Show();
            }
            else
            {
                ncc.Activate();
            }
        }
        private void ncc_FormClosed(object sender, FormClosedEventArgs e)
        {
            ncc = null;
        }

        private void QLBanThuoc_Click(object sender, EventArgs e)
        {
            if (loaithuoc == null)
            {
                loaithuoc = new frmloaithuoc();
                loaithuoc.FormClosed += dmthuoc_FormClosed;
                loaithuoc.MdiParent = this;
                loaithuoc.Dock = DockStyle.Fill;
                loaithuoc.Show();
            }
            else
            {
                loaithuoc.Activate();
            }
        }
        private void loaithuoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            loaithuoc = null;
        }

        private void pnl_sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
