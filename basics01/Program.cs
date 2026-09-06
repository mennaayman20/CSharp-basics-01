namespace basics01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1 Create an instance of the Book class 
            Book myBook = new Book();
            myBook.Title = "the Great Gatsby";
            myBook.Pages = 200;

            // 2. Store it in a variable of type object
            object objBook = myBook;

            //print
            Console.WriteLine(objBook);

        }
    }
}
