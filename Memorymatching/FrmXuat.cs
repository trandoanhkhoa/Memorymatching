using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        public List<string> images = new List<string>()
            {"A.png", "B.png","C.png","D.png","E.png","G.png","H.png","I.png","K.png","L,png","M.png","N.png" };
        List<string> result = new List<string>();
        int CountEnd = 0;
        public FrmXuat(int dong = 0 , int cot = 0)
        {
            //Dùng tên ảnh
            
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
                    btn.Name = "btn" + (i * SoCot + j + 1).ToString();
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



            string rootDirectory = "E:\\Democracy\\Memorymatching\\Memorymatching\\";
            
            //Lấy vị trí của ảnh 
            int vtanh = int.Parse((sender as Button).Tag.ToString());
            
            //Hiển thị ảnh trong mảng images
            string imagePath = Path.Combine(rootDirectory, "Images", images[vtanh]);
            (sender as Button).Image = Image.FromFile(imagePath);
            string tmp = (sender as Button).Tag.ToString();
            //Có ảnh trong mảng result
            
            if (result.Count()>0)
            {
                int index = result.FindIndex(item => item.Equals(tmp));
                //Không giống ảnh
                if (index==-1)
                {
                    result.Add((sender as Button).Tag.ToString());
                    result.Add((sender as Button).Name);

                    // Khởi tạo Timer
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 500; // Đặt khoảng thời gian là 2 giây

                    // Sự kiện Tick cho Timer
                    timer.Tick += (timerSender, ev) =>
                    {
                        // Logic khi Timer kết thúc
                        if(result.Count()>0)
                        {
                            foreach (Button btn in this.Controls)
                            {
                                if (btn.Name == result[1] || btn.Name == result[3])
                                {
                                    btn.Image = null; // hoặc btn.Enabled = false tùy vào yêu cầu cụ thể của bạn
                                }
                            }
                        }    
                        

                        // Dừng và xóa Timer sau khi đã sử dụng
                        timer.Stop();
                        
                        timer.Dispose();

                        // Xóa danh sách kết quả sau khi đã xử lý xong
                        result.Clear();
                    };
                    // Khởi động Timer ngay sau khi hiển thị ảnh
                    timer.Start();
                    
                }
                //giống ảnh
                else
                {
                    result.Add((sender as Button).Tag.ToString());
                    result.Add((sender as Button).Name);
                    foreach (Button btn in this.Controls)
                    {
                        if(btn.Name == result[1] || btn.Name== result[3])
                        {
                            btn.Enabled= false;
                        }    
                    }
                    result.Clear();
                    CountEnd++;
                    if(CountEnd==(SoDong*SoCot)/2)
                    {
                        MessageBox.Show("Bạn đã chiến thắng");
                    }    

                }
                

            }
            else 
            {
                result.Add((sender as Button).Tag.ToString());
                result.Add((sender as Button).Name);
            }




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
