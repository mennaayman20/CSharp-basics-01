using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace basics01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object.Print it.
            // Create an instance of the Book class 
            Book myBook = new Book();
            myBook.Title = "the Great Gatsby";
            myBook.Pages = 200;
            // 2. Store it in a variable of type object
            object objBook = myBook;
            //print
            Console.WriteLine(objBook);
            #endregion



            #region Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book. 
            Console.WriteLine(objBook.ToString());             
            Console.WriteLine(objBook.Equals(objBook));       
            Console.WriteLine(objBook.GetHashCode());          
            Console.WriteLine(objBook.GetType());
            #endregion



            #region Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            try
            {
                int number1 = 10;
                int number2 = 0;
                int result = number1 / number2;
            }
            catch(Exception)
            {
                Console.WriteLine("Cannot divide by zero");

            }
            finally
            {
                Console.WriteLine("Done");
            }


            #endregion




            #region Declare an int pages = 300; then store it in a double variable without using a cast. 

            // 1. Declare int pages
            int pages = 300;

            // 2. Store it in a double variable (implicit)
            double doublePages = pages;

            // print
            Console.WriteLine(doublePages);

            #endregion


            #region Declare a double price = 49.99; then convert it into an int using a cast. 

            double price = 49.99;
            // Explicit casting
            int intPrice = (int)price;
            // print
            Console.WriteLine(intPrice);

            #endregion



            #region Given string pagesText = "464";, convert it into an int using the Convert class. 

            string pagesText = "464";
            // Convert string to int using Convert class
            int pagesInt = Convert.ToInt32(pagesText);
            // print
            Console.WriteLine(pagesInt);

            #endregion


            #region Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            
            // Convert using int.Parse()
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine($"Year: {year}");

            // try converting badText using int.TryParse()
            string badText = "abc";

            bool isSuccess = int.TryParse(badText, out int resultt);

            if (isSuccess)
            {
                Console.WriteLine($"Converted number: {resultt}");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            #endregion






        }
    }
}
