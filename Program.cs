using System;
using System.IO;
namespace projectFinale
{
    class Program
    {
        //add static to void main
       static void Main(string[] args)
        {
           string userChoice;

           do {
                Console.WriteLine("Please press 1 to create and write to a cvs file, 2 to read from one or any other number to quit");
                userChoice = Console.ReadLine();

                if (userChoice == "1"){
                    Console.WriteLine("Enter the name of the new file");
                 string userFile;
                 userFile = Console.ReadLine();
                 string file = userFile+".txt";
                 StreamWriter sw = new StreamWriter(file);
                 Console.WriteLine("Please enter the data you wish to put in the file, seperate the items with commas");
                 string userData =  Console.ReadLine();
            
                //  String[] cvsArray = userData.Split(',');
                 sw.WriteLine(userData);
                 sw.Close();

                } else if (userChoice == "2"){

                }

            

               if(userChoice == "2"){
                      Console.WriteLine("please enter the name of the file you wish to read from");
                      string userFileRead = " ";
                    userFileRead = Console.ReadLine();
                  
                  StreamReader sr = new StreamReader(userFileRead+".txt");
                  while(!sr.EndOfStream){
                      string lineOfCode = sr.ReadLine();
                     string[] parsedLineOfCode = lineOfCode.Split(',');
Console.WriteLine("The file says:");
                    for(int i = 0; i < parsedLineOfCode.Length; i++){
                         Console.WriteLine(parsedLineOfCode[i]);
                     }

                  }}

            } while(userChoice == "1" || userChoice == "2");
        }
    }
}