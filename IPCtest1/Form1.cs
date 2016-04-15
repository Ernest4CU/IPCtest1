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
using AForge.Video.VFW;

namespace IPCtest1
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }        

        Thread get_video_thread = null;
        string str_ip = "192.168.1.100";
        AVIWriter aviWriter = new AVIWriter();        
        int avirecord = 0;
        int pic_count = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            get_video_thread = new Thread(ipc_run);
            get_video_thread.Start();            
        }

        private void ipc_run()
        {
            string sourceURL = "http://" + str_ip + "/videostream.cgi?loginuse=admin&amp;loginpas=";
            byte[] buffer = new byte[100000];
            byte[] unbuffer = new byte[60];
            string str_length = "";
            int num_cnt = 0;
            Image image_s = null;
            Bitmap bmp = null;
            IPC_Cgi ipcamear = new IPC_Cgi();
            try
            {
                Stream stream = ipcamear.get_videoStream(sourceURL);
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

                        bmp = (Bitmap)Bitmap.FromStream(
                                      new MemoryStream(buffer, 0, num_cnt));

                        /*在视频上添加实时时间*/
                        Graphics g = Graphics.FromImage(bmp);                        
                        Font font = new Font("宋体", 18);
                        String str_realtime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        SolidBrush sbrush = new SolidBrush(Color.WhiteSmoke);
                        g.DrawString(str_realtime, font, sbrush, new PointF(10, 20));
                        MemoryStream ms = new MemoryStream();
                        bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

                        if (avirecord == 1)
                        {
                            aviWriter.AddFrame(bmp);
                            aviWriter.AddFrame(bmp);
                            aviWriter.AddFrame(bmp);
                            aviWriter.AddFrame(bmp);
                            aviWriter.AddFrame(bmp);
                        }

                        //方法1
                        IntPtr hBitmap = bmp.GetHbitmap();
                        image_s = Image.FromHbitmap(hBitmap);

                        //方法2
                        //MemoryStream ms = new MemoryStream(buffer);
                        //image_s = Image.FromStream(ms);
                        //照片保存
                        //bmp.Save(Application.StartupPath + "//1/pic"+(cur_num++)+".jpeg");
                        //IntPtr hBitmap = bmp.GetHbitmap();
                        
                        pb_video.Image = image_s;
                        //pictureBox1.Image = Image.FromHbitmap(bmp.GetHbitmap());
                        //bmp = null;//释放无效
                        //bmp.Dispose();
                        //image_s.Dispose();
                        GC.Collect();
                        DeleteObject(hBitmap);
                    }
                    catch { }
                }
            }
            catch
            {
                MessageBox.Show("无法连接到远程服务器!!!");
            }
        }
        
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);
        private Bitmap get_IPCbitmap()
        {
            Bitmap bm = null;
            return bm;
        }

        private void pl_OrientationUp_MouseDown(object sender, MouseEventArgs e)
        {
            string str_ctl = @"http://" + str_ip + "/decoder_control.cgi?command=0&onestep=0&user=admin&pwd=";
            IPC_Cgi IpCamera_temp = new IPC_Cgi();
            IpCamera_temp.Ptz_control(str_ctl);
        }
        private void pl_OrientationUp_MouseUp(object sender, MouseEventArgs e)
        {
            string str_ctl = @"http://" + str_ip + "/decoder_control.cgi?command=1&onestep=0&user=admin&pwd=";
            IPC_Cgi IpCamera_temp = new IPC_Cgi();
            IpCamera_temp.Ptz_control(str_ctl);
        }        

        private void pl_OrientationDown_MouseDown(object sender, MouseEventArgs e)
        {
            string str_ctl = @"http://" + str_ip + "/decoder_control.cgi?command=2&onestep=0&user=admin&pwd=";
            IPC_Cgi IpCamera_temp = new IPC_Cgi();
            IpCamera_temp.Ptz_control(str_ctl);
        }

        private void pl_OrientationDown_MouseUp(object sender, MouseEventArgs e)
        {
            string str_ctl = @"http://" + str_ip + "/decoder_control.cgi?command=3&onestep=0&user=admin&pwd=";
            IPC_Cgi IpCamera_temp = new IPC_Cgi();
            IpCamera_temp.Ptz_control(str_ctl);
        }

        private void pl_OrientationLeft_MouseDown(object sender, MouseEventArgs e)
        {
            string str_ctl = @"http://" + str_ip + "/decoder_control.cgi?command=4&onestep=0&user=admin&pwd=";
            IPC_Cgi IpCamera_temp = new IPC_Cgi();
            IpCamera_temp.Ptz_control(str_ctl);
        }

        private void pl_OrientationLeft_MouseUp(object sender, MouseEventArgs e)
        {
            string str_ctl = @"http://" + str_ip + "/decoder_control.cgi?command=5&onestep=0&user=admin&pwd=";
            IPC_Cgi IpCamera_temp = new IPC_Cgi();
            IpCamera_temp.Ptz_control(str_ctl);
        }

        private void pl_OrientationRight_MouseDown(object sender, MouseEventArgs e)
        {
            string str_ctl = @"http://" + str_ip + "/decoder_control.cgi?command=6&onestep=0&user=admin&pwd=";
            IPC_Cgi IpCamera_temp = new IPC_Cgi();
            IpCamera_temp.Ptz_control(str_ctl);
        }

        private void pl_OrientationRight_MouseUp(object sender, MouseEventArgs e)
        {
            string str_ctl = @"http://" + str_ip + "/decoder_control.cgi?command=7&onestep=0&user=admin&pwd=";
            IPC_Cgi IpCamera_temp = new IPC_Cgi();
            IpCamera_temp.Ptz_control(str_ctl);
        }

        Image image_snapshot = null;

        private void bt_test_Click(object sender, EventArgs e)
        {
            string str_ctl = @"http://" + str_ip + "/snapshot.cgi?user=admin&pwd=";
            IPC_Cgi IPCamera = new IPC_Cgi();
            image_snapshot = IPCamera.get_Image(str_ctl);
            image_snapshot.Save("F:\\IPC_Picture\\" + pic_count + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            GC.Collect();
            System.Diagnostics.Process.Start("F:\\IPC_Picture");         
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (get_video_thread != null)
            {
                get_video_thread.Abort();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (get_video_thread != null)
            {
                get_video_thread.Abort();
            }
        }

        private void avi_record_Click(object sender, EventArgs e)
        {
            aviWriter.Open("F:\\IPC_Video\\001.avi", 640, 480);
            avirecord = 1;
        }

        private void avi_save_Click(object sender, EventArgs e)
        {
            aviWriter.Close();
            avirecord = 0;
            System.Diagnostics.Process.Start("F:\\IPC_Video");
        }
    }
}
