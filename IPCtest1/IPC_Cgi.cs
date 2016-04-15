using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Net;
using System.Drawing;

namespace IPCtest1
{
    class IPC_Cgi
    {
        public Stream get_videoStream(string url)
        {
            // create HTTP request  
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            // get response  
            WebResponse resp = req.GetResponse();
            // get response stream  
            Stream stream = resp.GetResponseStream();
            return stream;
        }

        //public Bitmap deal_videoStream(Stream videoStream)
        //{
        //    byte[] buffer = new byte[100000];
        //    byte[] unbuffer = new byte[60];
        //    string str_length = "";
        //    int num_cnt = 0;
        //    Bitmap bmp = null;
        //    //int cur_num = 0;

        //    try
        //    {
        //        for (int i = 0; i < 59; i++)
        //        {
        //            unbuffer[i] = (byte)videoStream.ReadByte();
        //        }

        //        for (int i = 0; i < 5; i++)
        //        {
        //            str_length += (char)videoStream.ReadByte();
        //        }
        //        num_cnt = Int32.Parse(str_length);
        //        str_length = "";
        //        for (int i = 0; i < 4; i++)
        //        {
        //            unbuffer[i] = (byte)videoStream.ReadByte();
        //        }
        //        for (int i = 0; i < num_cnt; i++)
        //        {
        //            buffer[i] = (byte)videoStream.ReadByte();
        //        }
        //        unbuffer[1] = (byte)videoStream.ReadByte();
        //        unbuffer[1] = (byte)videoStream.ReadByte();
        //        bmp = (Bitmap)Bitmap.FromStream(
        //                      new MemoryStream(buffer, 0, num_cnt));
        //    }
        //    catch { }

        //    return bmp;
        //}

        public void Ptz_control(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            WebResponse resp = req.GetResponse();            
            resp.Dispose();
        }

        public Image get_Image(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            Image im = Image.FromStream(stream);
            return im;
        }
    }
}
