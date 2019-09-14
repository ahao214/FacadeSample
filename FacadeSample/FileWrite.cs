using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace FacadeSample
{
    /// <summary>
    /// 文件保存类，充当子类系统
    /// </summary>
    class FileWrite
    {
        public void Write(string encryptStr, string fileNameDes)
        {
            WriteLine("保存密文，写入文件！");
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileNameDes, FileMode.Create);
                byte[] str = Encoding.Default.GetBytes(encryptStr);
                fs.Write(str, 0, str.Length);
                fs.Flush();
                fs.Close();
            }
            catch (FileNotFoundException e)
            {
                WriteLine("文件不存在!");
            }
            catch (IOException e)
            {
                WriteLine(e.Message);
                WriteLine("文件操作错误!");
            }


        }
    }
}
