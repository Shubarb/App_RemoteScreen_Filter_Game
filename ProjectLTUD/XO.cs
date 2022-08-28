using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectLTUD
{
    public partial class XO : Form
    {
        public static int ChieuRongBanCo;
        public static int ChieuCaoBanCo;
        private Graphics grp;
        private Controls DieuKhien;
 
        public XO()
        {
            InitializeComponent();
            //vẽ nên pnlBanCo
            grp = pnlBanCo.CreateGraphics();

            //lấy chiều rộng và chiều cao pnBanCo để vẽ bàn cờ
            ChieuCaoBanCo = pnlBanCo.Height;
            ChieuRongBanCo = pnlBanCo.Width;

            //khởi tạo đối tượng điều khiển trò chơi
            DieuKhien = new Controls();
        }
        private void pnlBanCo_Paint(object sender, PaintEventArgs e)
        {
            if (DieuKhien.SanSang)
            {
                //vẽ bàn cờ
                DieuKhien.veBanCo(grp);
                //vẽ lại các quân cờ trong stack
                DieuKhien.veLaiQuanCo(grp);
            }
        }

        private void chơiVớiNgườiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DieuKhien.choiVoiNguoi(grp);

            grp.Clear(pnlBanCo.BackColor);
            Image image = new Bitmap(Properties.Resources.nen);
            pnlBanCo.BackgroundImage = image;
            //xóa tất cả các hình đã vẽ trên panel chỉ giữ lại màu nền panel
        }

        private void pnlBanCo_MouseClick(object sender, MouseEventArgs e)
        {
            if (DieuKhien.SanSang)
            {
                //chơi với người
                if (DieuKhien.CheDoChoi == 1)
                {
                    //đánh cờ với tọa độ chuột khi lick vào panel bàn cờ
                    DieuKhien.danhCo(grp, e.Location.X, e.Location.Y);
                    //sau khi đánh cờ thì kiểm tra chiến thắng luôn
                    DieuKhien.kiemTraChienThang(grp);
                }
                //chơi với máy
                else
                {
                    //người chơi đánh
                    DieuKhien.danhCo(grp, e.Location.X, e.Location.Y);
                    //kiểm tra người chơi chưa chiến thắng thì cho máy đánh
                    if (!DieuKhien.kiemTraChienThang(grp))
                    {
                        //máy đánh
                        DieuKhien.mayDanh(grp);
                        DieuKhien.kiemTraChienThang(grp);
                    }
                }
            }
        }

        private void chơiVớiMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DieuKhien.choiVoiMay(grp);

            grp.Clear(pnlBanCo.BackColor);
            Image image = new Bitmap(Properties.Resources.nen);
            pnlBanCo.BackgroundImage = image;
            //xóa tất cả các hình đã vẽ trên panel chỉ giữ lại màu nền panel

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoshizona fh = new Hoshizona();
            this.Hide();
            fh.ShowDialog();
        }

    }
}
