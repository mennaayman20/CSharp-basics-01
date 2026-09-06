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






        }
    }
}
