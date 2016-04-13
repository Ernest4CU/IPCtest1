using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace IPCtest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(ipc_run);
            th.Start();
        }

        private void ipc_run()
        {
            string sourceURL = "http://192.168.1.100/videostream.cgi?loginuse=admin&amp;loginpas=";
            byte[] buffer = new byte[100000];
            byte[] unbuffer = new byte[60];       
            string str_length = "";
            int num_cnt = 0;
            Image image_s = null;
            // create HTTP request  
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(sourceURL);
            // get response  
            WebResponse resp = req.GetResponse();
            // get response stream  
            Stream stream = resp.GetResponseStream();
            int cur_num = 0;
            
            while (true)
            {
                try
                {
                    for (int i = 0; i < 59; i++)
                    {
                        unbuffer[i] = (byte)stream.ReadByte();
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        str_length += (char)stream.ReadByte();
                    }
                    num_cnt = Int32.Parse(str_length);
                    str_length = "";
                    for (int i = 0; i < 4; i++)
                    {
                        unbuffer[i] = (byte)stream.ReadByte();
                    }
                    for (int i = 0; i < num_cnt; i++)
                    {
                        buffer[i] = (byte)stream.ReadByte();
                    }
                    unbuffer[1] = (byte)stream.ReadByte();
                    unbuffer[1] = (byte)stream.ReadByte();
                    Bitmap bmp = (Bitmap)Bitmap.FromStream(
                                  new MemoryStream(buffer, 0, num_cnt));

                    //方法1
                    IntPtr hBitmap = bmp.GetHbitmap();
                    image_s = Image.FromHbitmap(hBitmap);

                    //方法2
                    //MemoryStream ms = new MemoryStream(buffer);
                    //image_s = Image.FromStream(ms);
                    //照片保存
                    //bmp.Save(Application.StartupPath + "//1/pic"+(cur_num++)+".jpeg");
                    //IntPtr hBitmap = bmp.GetHbitmap();



                    pictureBox1.Image = image_s;
                    //pictureBox1.Image = Image.FromHbitmap(bmp.GetHbitmap());
                    //bmp = null;//释放无效
                    //bmp.Dispose();
                    //image_s.Dispose();
                    GC.Collect();
                    DeleteObject(hBitmap);
                    //ig.Dispose();
                    //GC.Collect();    
                }
                catch { }
            }
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);
        private Bitmap get_IPCbitmap()
        {
            Bitmap bm = null;
            return bm;
        }
    }
}
