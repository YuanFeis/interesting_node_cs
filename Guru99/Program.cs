using System;
using System.IO;
using System.Net;
using System.Threading;

namespace Guru99
{
    class Program
    {
        static void Main(string[] args)
        {

            Guru99Demo gr = new Guru99Demo();
            //red_circles
            gr.startBrowser();
           

            //Console.WriteLine("DONE");
            HttpListener httpListener = new HttpListener();

            httpListener.AuthenticationSchemes = AuthenticationSchemes.Anonymous;
            httpListener.Prefixes.Add("http://localhost:8080/");
            httpListener.Start();
            Console.WriteLine("DONE");
            while (true)
            {

                HttpListenerContext httpListenerContext = httpListener.GetContext();
                httpListenerContext.Response.StatusCode = 200;
                //chrome 报错 ie 不报错 直接写个客户端get
                string c_img = httpListenerContext.Request.QueryString["c_src"];
                string s_img = httpListenerContext.Request.QueryString["s_src"];
                string name = httpListenerContext.Request.QueryString["name"];
                string degree = httpListenerContext.Request.QueryString["degree"];
                Console.WriteLine("访问的服务器 c_img =  "+c_img+" "+ s_img + "  "+ name + "  "+  degree);
                //// 内容图片 风格图片 名字 风格化程度（0.5-0.8比较好）
                gr.test(c_img, s_img, name, degree);

                //using (StreamWriter writer = new StreamWriter(httpListenerContext.Response.OutputStream))
                //{
                //    writer.WriteLine("<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"/><title>测试服务器</title></head><body>");
                //    writer.WriteLine("<div style=\"height:20px;color:blue;text-align:center;\"><p> hello</p></div>");
                //    writer.WriteLine("<ul>");
                //    writer.WriteLine("</ul>");
                //    writer.WriteLine("</body></html>");

                //}
                
                }
            
        }
       
        }
    }

