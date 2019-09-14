using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FacadeSample
{
    /// <summary>
    /// 数据加密类，充当子系统类
    /// </summary>
    class CipherMachine
    {
        public string Encrypt(string plainText)
        {
            Write("数据加密，将明文转换为密文！");
            string es = "";
            char[] chars = plainText.ToCharArray();
            foreach (char ch in chars)
            {
                string c = (ch % 7).ToString();
                es += c;
            }
            WriteLine(es);
            return es;
        }
    }
}
