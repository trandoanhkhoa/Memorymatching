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
        //Mảng chứa ảnh 
        
        
        public int SoDong { get; set; }
        public int SoCot {get; set; }

        int h = 80, margin = 5;
        public FrmXuat(int dong = 0 , int cot = 0)
        {
            //Dùng tên ảnh
            List<string> images = new List<string>() 
            {"A.png", "B.png","C.png","D.png","E.png","G.png","H.png","I.png","K.png","L,png","M.png","N.png" };
            //Dùng để đánh dấu button
            List<int> dsso = new List<int>();
            
            InitializeComponent();

            //Lấy giá trị truyền từ form Nhập liệu
            SoDong = dong;
            SoCot = cot;

            //Thiết lập đánh dấu số cho button

            int soluong = SoDong * SoCot;
            for (int i = 0; i < soluong/2; i++)
            {
                dsso.Add(i);
                dsso.Add(i);
            }
            //{0,0,1,1,2,2,3,3}
            Shuffle(dsso);
            //{1,2,0,0,1,3,2,3}


            int vitri = 0;
            Button btn = null;
            for(int i=0;i<SoDong;i++)
            {
                for(int j=0;j<SoCot;j++)
                {
                    btn = new Button();
                    btn.Width = h ; btn.Height = h;
                    //btn.Text = dsso[vitri].ToString();
                    btn.Left = margin * (j + 1) + h * j;
                    btn.Top = margin * (i + 1) + h * i;
                    btn.Click += btn_Click;
                    btn.Tag = dsso[vitri].ToString();
                    //Thêm button vào form Xuất
                    vitri++;
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


        private static void Shuffle<T>(IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
