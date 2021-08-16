using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOFileDemo
{
    class TxtFileDemo
    {
        static void Main()
        {
            // creating a text file 
            string path = @"D:\capgemini\training\technical\C#\IOFileDemo\IOFileDemo\";
            string fileName = "Abhishek.txt";
            string fileName2 = "Alka.txt";
            /*#region input chars in the file {Over write content} 
            // this region was for creation of file and set the access and mode of the file
            FileStream fileStream = new FileStream(path + fileName2, FileMode.Create, FileAccess.Write); // (<name of file>, <mode of the file we want to create>, <access level of the file write>)

            // this is for writing content in the file 
            StreamWriter sw = new StreamWriter(fileStream); // this is the object of file we just created 
            Console.WriteLine("Write a line");
            sw.WriteLine(Console.ReadLine()); // this will over write every time we run the code 
            sw.Close();
            #endregion
            
            #region Creating file and appending content 
            StreamWriter sw; // this is the object of file we just created 
            bool toAppend = true; // instruction for the stream writer to append or not 
            sw = new StreamWriter(path + fileName, toAppend);
            string ipData;
            Console.WriteLine("Start Typing -> ");
            do
            {
                ipData = Console.ReadLine();
                sw.WriteLine(ipData);
            }
            while (ipData.Length != 0); // once the length is 0 stop 
            sw.Close(); // if not used file data wont be saved/ file wont be saved
            Console.WriteLine("File Writing Complete");
            #endregion
            */

            #region Reading text file using stream reader / Copying content from one file to another 
            StreamWriter sw; // this is the object of file we just created 
            bool toAppend;
            StreamReader readFrom = new StreamReader(path+fileName); // reading the file we created in above region 
            string fileData;
            int lineNo = 0;
            while ((fileData = readFrom.ReadLine()) != null)// checking the end of the file EOF 
            {
                lineNo++;
                Console.WriteLine($"{lineNo}. {fileData}");
            }

            // copying the content of this file to another 
            readFrom = new StreamReader(path+fileName);
            toAppend = false; // as we just need to create a file and write data 
            StreamWriter writeTo = new StreamWriter(path+fileName2, toAppend); 
            
            while ((fileData = readFrom.ReadLine()) != null)// checking the end of the file EOF 
            {
                if (fileData.Length > 1)
                {
                    Console.WriteLine($"File data -> {fileData}");
                    writeTo.WriteLine(fileData);
                }
            }
            writeTo.Close();
            readFrom.Close();
            #endregion
        }
    }
}
