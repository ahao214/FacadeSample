using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FacadeSample
{
    /// <summary>
    /// 加密外观类，充当外观类
    /// </summary>
    class EncryptFacade
    {
        //维持对其他对象的引用
        private FileReader reader;
        private CipherMachine cipher;
        private FileWrite writer;

        public EncryptFacade()
        {
            reader = new FileReader();
            cipher = new CipherMachine();
            writer = new FileWrite();
        }

        //调用其他对象的业务方法
        public void FileEncrypt(string fileNameSrc,string fileNameDes)
        {
            string plainStr = reader.Read(fileNameSrc);
            string encryptStr = cipher.Encrypt(plainStr);
            writer.Write(encryptStr, fileNameDes);
        }
    }
}
