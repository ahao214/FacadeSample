using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FacadeSample
{
    /// <summary>
    /// 文件读取类，充当子系统类
    /// </summary>
    class FileReader
    {
        public string Read(string fileNameSrc)
        {
            Write("读取文件，获取明文");
            FileStream fs = null;
            StringBuilder sb = new StringBuilder();
            try
            {
                fs = new FileStream(fileNameSrc, FileMode.Open);
                int data;
                while ((data = fs.ReadByte()) != -1)
                {
                    sb = sb.Append((char)data);
                }
                fs.Close();
                WriteLine(sb.ToString());
            }
            catch (FileNotFoundException ex)
            {
                WriteLine("文件不存在");
            }
            catch (IOException e)
            {
                WriteLine("文件操作错误");
            }
            return sb.ToString();

        }



    }
}
