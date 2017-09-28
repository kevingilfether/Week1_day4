using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_day4
{
    class Program
    {
        static void Main(string[] args)
        {
            // A string is a sequence of characters inside 
            // inside "double quotes"

            //Console.WriteLine("This is a tab \t.");
            //Console.WriteLine("This is a line \"quote.\"");
            //Console.WriteLine("This is a backslash \\");
            //Console.WriteLine("This is a \n new line");
            //Console.WriteLine("And this is a bell \a");

            //Man, that bell is annoying.


            // Cool way to concatenate using indexes. {0} = zero index
            //string firstName = "Kevin";
            //string catName = "Nugget";

            //Console.WriteLine("My first name is {0} and my cat is {1}.", firstName, catName);

            // Cool way to concatenate using variables
            //string bestFriends = firstName + " " + catName;
            //Console.WriteLine(bestFriends);

            //Obscure rare way to concatenate

            //Console.WriteLine(string.Concat(firstName, catName));

            //.Length is a class of strings, it's useful on projects and stuff. 
            // It counts the number of characters in a string and then returns 

            //Console.WriteLine(firstName.Length);



            //String methods

            // Trim() -- Removes any empty space on either side of it, preserves space in the middle.

            //ToString() -- Changes input to a string (useful for converting the numbers)

            //ToUpper() -- Makes string all UPPERCASE.

            //To Lower() -- makes string all lowercase.

            //IndexOf() -- Returns an integer based on the location of the searched for substring
            // (in this case, the first character)

            //LastIndexOf() -- Does IndexOf(), but from right to left.

            //Substring() -- Extracts a portion of a string based upon an index

            //Remove() -- returns a specified part of the string

            //Split() -- Can split the strings into seperate parts based upon selector

            //Replace() -- Like find and replace on microsoft word document


        }
    }
}
