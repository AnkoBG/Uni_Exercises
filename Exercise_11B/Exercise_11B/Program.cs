using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11B
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            try
            {
                using (var f = File.Open("storage.txt", FileMode.Open))
                {
                    int read;
                    byte[] buf = new byte[5];
                    DynamicArray contents = new DynamicArray();
                    do
                    {
                        read = f.Read(buf, 0, buf.Length);
                        contents.AddRange(buf,read);
                    }
                    while (read != 0);

                    text = Encoding.UTF8.GetString(contents.ToArray());
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Файлът не е намерен: ");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Неочаквана грешка: ");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
