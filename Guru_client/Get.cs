using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Guru_client
{
    class Get
    {
        public Dictionary<string, string> addParams(string c_src, string s_src, string name, string degree)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("c_src", c_src);
            dic.Add("s_src", s_src);
            dic.Add("name", name);
            dic.Add("degree", degree);
            return dic;

        }
        public  string Getrequset(string url, Dictionary<string, string> dic)
        {
            string result = "";
            StringBuilder builder = new StringBuilder();
            builder.Append(url);
            if (dic.Count > 0)
            {
                builder.Append("?");
                int i = 0;
                foreach (var item in dic)
                {
                    if (i > 0)
                        builder.Append("&");
                    builder.AppendFormat("{0}={1}", item.Key, item.Value);
                    i++;
                }
            }
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(builder.ToString());
            //添加参数
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            try
            {
                //获取内容
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }
            finally
            {
                stream.Close();
            }
            return result;
        }

        }
}
