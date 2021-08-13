﻿using System;
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
            
            #region input chars in the file {Over write content} 
            // this region was for creation of file and set the access and mode of the file
            FileStream fileStream = new FileStream("TestFileCreation.txt", FileMode.Create, FileAccess.Write); // (<name of file>, <mode of the file we want to create>, <access level of the file write>)

            // this is for writing content in the file 
            StreamWriter sw = new StreamWriter(fileStream); // this is the object of file we just created 
            Console.WriteLine("Write a line");
            sw.WriteLine(Console.ReadLine()); // this will over write every time we run the code 
            sw.Close();

            #endregion
            
            
            #region Creating file and appending content 
            bool toAppend = true; // instruction for the streamwriter to append or not 
            sw = new StreamWriter("TestFileAppend.txt", toAppend); 
            string ipData;
            Console.WriteLine("Start Typing -> ");
            do
            {
                ipData = Console.ReadLine();
                sw.WriteLine(ipData);
            }
            while (ipData.Length != 0); // once the lenght is 0 stop 
            sw.Close(); // if not used file data wont be saved/ file wont be saved
            Console.WriteLine("File Writing Complete");
            
            #endregion
            

            #region Reading text file using stream reader / Copying content from one file to another 
            StreamReader sr = new StreamReader("TestFileAppend.txt"); // reading the file we created in above region 
            
            string fileData;
            int lineNo = 0;
            while ((fileData = sr.ReadLine()) != null)// checking the end of the file EOF 
            {
                lineNo++;
                Console.WriteLine($"{lineNo}. {fileData}");
            }

            // copying the content of this file to another 
            sr = new StreamReader("TestFileAppend.txt");
            toAppend = false; // as we just need to create a file and write data 
            sw = new StreamWriter("TestFileAppendCopy.txt", toAppend); 
            
            while ((fileData = sr.ReadLine()) != null)// checking the end of the file EOF 
            {
                if (fileData.Length > 1)
                {
                    Console.WriteLine($"File data -> {fileData}");
                    sw.WriteLine(fileData);
                }
            }
            sw.Close();
            sr.Close();
            #endregion

         


        }
    }
}
