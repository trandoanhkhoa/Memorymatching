using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorymatching
{
    public partial class FrmXuat : Form
    {
        public int SoDong { get; set; }
        public int SoCot {get; set; }

        int h = 80, margin = 5;
        public FrmXuat(int dong = 0 , int cot = 0)
        {
            InitializeComponent();

            //Lấy giá trị truyền từ form Nhập liệu
            SoDong = dong;
            SoCot = cot;

            Button btn = null;
            for(int i=0;i<SoDong;i++)
            {
                for(int j=0;j<SoCot;j++)
                {
                    btn = new Button();
                    btn.Width = h ; btn.Height = h;
                    btn.Text = (i * SoCot + j + 1).ToString();
                    btn.Left = margin * (j + 1) + h * j;
                    btn.Top = margin * (i + 1) + h * i;
                    btn.Click += btn_Click;
                    btn.Tag = string.Format("Dòng {0} cột {1}", i, j);
                    //Thêm button vào form Xuất
                    this.Controls.Add(btn);
                }
            }
            //Thiết lập lại kích thước của form Xuat
            this.ClientSize = new Size(SoCot * (h + margin + 1), SoDong * (h + margin + 1));
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Text);
            //throw new NotImplementedException();
        }
    }
}
