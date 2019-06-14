using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReadAndWriteAssessment
{
    class Program
    {   //This is the path created to store user input into a text file.

        string pathToFile = "C:\\Users\\hp\\Documents\\userinput.txt";


        //This section accepts input in the cosole and saves it into the path created earlier
        public void AcceptInput()
        {
            List<string> eachLineOfInput = File.ReadAllLines(pathToFile).ToList(); //This line of code initialise a list 

            eachLineOfInput.Add(Console.ReadLine()); //This line of code add all the user input into the list that was initialised above

            File.WriteAllLines(pathToFile, eachLineOfInput); //This line of code write all the input of the user into the path created

            Console.WriteLine();
        }

        //This section allows us to read each line of text to from the text file created.
        public void ReadsInput()
        {
            List<string> readEachLineOfText = File.ReadLines(pathToFile).ToList(); //This line of code is to create a list where all the text saved in the text file is added

            foreach (string text in readEachLineOfText) //This line of code creates a string variable using a foreach approach
            {
                Console.WriteLine(text); //This line of code uses the string variable created earlier to print each line of text in the the text file on console
            }
        }
        

        //This section is where the instance of class is created in other to run the methods created earlier.

        static void Main(string[] args)
        {

                Program program = new Program(); //The instance of class created
               
                program.AcceptInput(); //The method created to accept input fron the user
                program.ReadsInput();  //The metthod created to read all the text from the text file
                




         Console.ReadLine(); //This line of code enables the console pop up to stay up and running when the pogram is triggered to ON..
        }
    }
}
