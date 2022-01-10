using System;
using System.IO;

namespace FileStreamTest
{

    namespace Streams
    {
        class Program
        {
            static void Main(string[] args)
            {
                string filename = @"ByteArray.bin";



                byte[] byteArrayWrite = { 1, 2, 3, 4, 5, 5, 7, 8, 9 };
                byte[] byteArrayRead = new byte[byteArrayWrite.Length];



                FileStream fs = new FileStream(filename, FileMode.Create);



                fs.Write(byteArrayWrite, 0, byteArrayWrite.Length);



                fs.Position = 0;
                fs.Read(byteArrayRead, 0, byteArrayRead.Length);



                for (int count = 0; count < byteArrayRead.Length; count++)
                {
                    Console.Write(byteArrayRead[count] + ", ");
                }



                fs.Close();
                File.Delete(filename);
            }
        }
    }
}