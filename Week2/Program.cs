using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Declaring array without initializing it.
            //int[] myFirstArray;

            ////Declare and initialize a second array
            //string[] mySecondArray = { "firstElement", "secondElement", "thirdElement", "fourthElement" };

            ////Declare and inititalize a char array with the letters of your last name
            //char[] lastName = { 'a', 'l', 'v', 'a', 'r', 'a', 'd', 'o' };

            //Console.WriteLine(lastName[0]);
            //Console.WriteLine(lastName[3]);
            //Console.WriteLine(lastName[1]);

            //Create the following arrays and print using the correct index numbers:
            //Array of top ten vacation spots
            //Print the first and last vacation spot
            //string[] vacationSpots = { "Sydney", "Orlando", "Puerto Rico", "Cuba", "California", "Canada", "DC", "Italy", "Tokyo", "Mexico" };
            //Console.WriteLine(vacationSpots[0]);
            //Console.WriteLine(vacationSpots[9]);

            ////Array of ages of 3 children you know
            ////Print each child's age
            //int[] childAge = { 8, 7, 7 };
            //Console.WriteLine(childAge[0]);
            //Console.WriteLine(childAge[1]);
            //Console.WriteLine(childAge[2]);

            ////Array of GPA on a 4.0 scale of 8 students - you don't have to print
            //double[] gpa = { 3.2, 3.0, 2.9, 4.0, 3.9, 2.0, 3.7, 3.1 };

            ////Array of the first letter of four of your classmate's names who are sitting near you
            ////Print all four on the same line
            //char[] firstLetter = { 'J', 'D', 'M', 'B' };
            //for (int i = 0; i < firstLetter.Length; i++)
            //    Console.Write(firstLetter[i]);

            //string[] studentsInClass = new string[21];
            //studentsInClass[0] = "Jordan";

            //Console.WriteLine("Please enter the name of the next student.");
            //studentsInClass[1] = Console.ReadLine();

            ////Ask user for input
            //Console.WriteLine("Please enter the age of the person in the first seat.");
            ////Create a new int array with 21 spots and call it ageOfStudentsInClass
            //int[] ageOfStudentsInClass = new int[21];
            ////Assign the value of the int at the 0 index of ageOfStudentsInClass to ...
            ////... the user's input converted into an int
            //ageOfStudentsInClass[0] = int.Parse(Console.ReadLine());
            ////Create a new string variable and set it equal to the int at the index of 0 ...
            ////and convert it into a string
            //string firstIndex = ageOfStudentsInClass[0].ToString();

            //string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chick Fil-A" };
            //Console.WriteLine(restaurantsInMall.Length);

            //char[] numberOfLetters = { 'J', 'o', 'n', 'a', 't', 'h', 'a', 'n' };
            //Console.WriteLine(numberOfLetters.Length);

            //Declare and initialize sting array using the length property print the second to last element in the array.
            //string[] secondToLast = { "first", "second", "third",  "last" };
            //Console.WriteLine(secondToLast [secondToLast.Length-2] );

            //int[] bestYearEver = { 1992, 1999, 2004, 2016, 1992, 2016 };
            //Console.WriteLine(Array.IndexOf(bestYearEver, 1992));
            //Console.WriteLine(Array.LastIndexOf(bestYearEver, 1992));

            //Array reverse method
            //int[] palindromeNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(palindromeNumbers[0]);
            //Array.Reverse(palindromeNumbers);
            //Console.WriteLine(palindromeNumbers[0]);

            //Sort
            //Will sort numbers in array from lowest to highest
            //Will sort char's or strings in alphabetical order from A-Z
            //string[] powerRangers = { "green", "red", "yellow", "black", "pink", "blue"};
            //Console.WriteLine(powerRangers[0]);
            //Array.Sort(powerRangers);
            //Console.WriteLine(powerRangers[0]);

            ////Declare and initialize a string array of first names. Choose a name to find and print the IndexOf.
            //string[] firstNames = { "Jonathan", "Ashley", "Carlos", "Daniel", "Ali" };
            //Console.WriteLine(Array.IndexOf(firstNames, "Carlos"));
            ////Create an array of lucky numbers. Each number should repeat at least once.Choose a lucky number, find and print the last index of it.
            //int[] luckyNumber = { 13, 2, 3, 7, 13 };
            //Console.WriteLine(Array.LastIndexOf(luckyNumber,13));
            ////Create an array of alphabet characters. Print the first index of the array.Now reverse the array and print the first index.
            //char[] alphabetChars = { 'a', 'b', 'c', 'd', 'e', 'f' };
            //Console.WriteLine(alphabetChars[0]);
            //Array.Reverse(alphabetChars);
            //Console.WriteLine(alphabetChars[0]);
            ////Create an array of student names in random order. Order the students’ names using the sort method.Print the first and last students’ names.
            //string[] studentNames = { "Jonathan", "Adam", "Daniel", "Aali" };
            //Array.Sort(studentNames);
            //Console.WriteLine(studentNames[0]);
            //Console.WriteLine(studentNames[studentNames.Length - 1]);
            ////Ask 10 people for their favorite numbers and create an array of those numbers.Order the numbers using the sort method.Print the first and last numbers.
            //int[] favNumber = { 3, 8, 12, 4, 9, 7, 12, 29, 8, 1, };
            //Array.Sort(favNumber);
            //Console.WriteLine(favNumber[0]);
            //Console.WriteLine(favNumber[favNumber.Length - 1]);
            //Console.WriteLine("Do you want to play the game? YES/NO");
            //string playAgain = Console.ReadLine();
            //while(playAgain.ToLower() == "yes")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play the game? YES/NO");
            //    playAgain = Console.ReadLine();
            //}
            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Welcome to my game!");
            //    //Game
            //    Console.WriteLine("Great game!");
            //    Console.WriteLine("Do you want to play the game? YES/NO");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain.ToLower() == "yes");

            //string add;
            //int classNumber;
            //Console.WriteLine("How many classes did you take?");
            //classNumber = int.Parse(Console.ReadLine());

            //string [] className = new string[classNumber];
            //string [] classGrade = new string[classNumber];


            //do
            //{

            //    Console.WriteLine("Would you like to add a class? YES/NO");
            //    add = Console.ReadLine();
            //    if (add.ToLower () == "yes")
            //    {
            //        for (int i = 0; i< classNumber; i++)
            //        {
            //            Console.WriteLine("What is the name for class " + i + 1 + "?");
            //            className[i] = Console.ReadLine();
            //            Console.WriteLine("What is the earned class grade?");
            //            classGrade[i]= Console.ReadLine();
            //        }
            //    }
            //}
            //while (add.ToLower() == "yes");

            //for (int rows = 1; rows <= 2; rows++)
            //{
            //    for (int columns = 1; columns <= 4; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}


            //Print a triangle outer loop will go line by line
            //inner loop will go over different elements in the line.
            //Result:
            //1
            //1 2
            //1 2 3
            //1 2 3 4

            for (int rows = 1; rows <= 25; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    Console.Write(columns);                    
                }
                Console.WriteLine();
            }


        }
    }
}
