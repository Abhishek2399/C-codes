using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // all the classes about file handling are in this namespace

namespace IOFileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Getting information of any folder 
             * For this we have to use directory info class {DirectoryInfo}
             */
            DirectoryInfo dirInfo = new DirectoryInfo(@"d:\capgemini\training\technical"); // constr. will accept the folder directory we want information regarding 
            // if we have more than one folder we can create an array of folder 

            DirectoryInfo[] subDirs = dirInfo.GetDirectories(); // will get all the folders inside the parent folder here it is the "d:\capgemini\training\technical 
            foreach(var dir in subDirs)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"{dir.CreationTime} : {dir.Name} => [{dir.FullName}]"); // printing out the name of the Folders 
                //.Name : name of the sub folders 
                //.FullName : full path of the folder 
                //.CreationTime : time along with date of when the folder was created 
                // ------------------------------------------//
                // to get the files in specific folder we need to create an array of files  
                FileInfo[] filesInfo = dir.GetFiles(); // get the files from current dir 
                Console.WriteLine("###############################################");
                foreach (var file in filesInfo)
                {
                    Console.WriteLine($"{file.Name} ========== {(file.Length)/8} ============== {file.CreationTime}");
                    // .Name will give the name of the file 
                    // .Length will return the size of file in bits 
                    // .CreationTime gives date and time of creation file 
                }
                Console.WriteLine("###############################################");
                Console.WriteLine("------------------------");
            }

            // creating a folder 
            try
            {
                // we need to decide on which level we are creating folder 
                DirectoryInfo subDir = new DirectoryInfo(@"d:\capgemini\training\technical\day#7"); //  choosing the dir we want to create the folder in 
                subDir.CreateSubdirectory("TestDirCreation2"); // passing the folder name we want to create
                subDirs = subDir.GetDirectories(); // checking if the folders created 
                Console.WriteLine("Folder/Dir created successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach(var dir in subDirs)
            {
                Console.WriteLine(dir.Name);
            }
        }
    }
}
