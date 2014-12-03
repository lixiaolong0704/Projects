using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PTools
{
    class Program
    {

        public static void Encrypt()
        {
            Console.WriteLine("Enter E F Name");
            try
            {
                string text = File.ReadAllText(Console.ReadLine());

                byte[] bs = Encoding.UTF8.GetBytes(text);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bs.Length; i++)
                {

                    if (i != 0)
                    {
                        sb.Append(".");
                    }
                    sb.Append((bs[i]*704).ToString());
                }

                File.WriteAllText("E.txt", sb.ToString());
                Console.WriteLine("E Over");
            }
            catch (Exception ex)
            {
                Console.WriteLine("E Error Occur");
            }

        }

        public static void Decrypt()
        {
            string text = File.ReadAllText("a.txt");
            string[] es= text.Split('.');
            byte[] bs = new byte[es.Length];
            for (int i = 0; i < es.Length; i++)
            {
                bs[i]=(byte)(int.Parse(es[i])/704);


            }




            string fore = Encoding.UTF8.GetString(bs);
            File.WriteAllText("a1.txt", fore);
            Console.WriteLine(fore);
            Console.Read();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("E or D");
            string str = Console.ReadLine();
            if (str == "E" || str =="e")
            {
                Encrypt();
            }
            else
            {
                Decrypt();
            }
        
        }
    }
}
