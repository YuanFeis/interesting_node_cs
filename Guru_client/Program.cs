using System;
using System.Collections.Generic;

namespace Guru_client
{
    class Program
    {
        static void Main(string[] args)
        {
            makeget("img/c/yf.jpg", "img/s/sketch.jpg", "sketch.png", "0.8");


        }
        public static void makeget(string c_src, string s_src, string name, string degree) {
            string url = "http://localhost:8080/";
            Get get = new Get();
            //string c_src = "img/c/yf.jpg";
            //string s_src = "img/s/zigzag.jpg";
            //string name = "test.png";
            //string degree = "0.5";
            Dictionary<string, string> dic = get.addParams(c_src, s_src, name, degree);
            get.Getrequset(url, dic);
        }
    }
}
