namespace AssignmentTwo
{
    internal class Program
    {
        static void Main(string[] args)
            {
                Book book = new Book();
                book.title = "c#";
                book.page = 555;
                Console.WriteLine(book.title);
                Console.WriteLine(book.page);
                Book book1 = new Book();
                book1.title = "Java";
                book1.page = 200;
                Console.WriteLine(book1.ToString());
                Console.WriteLine(book.Equals(book1));
                Console.WriteLine(book1.Equals(book1));
                Console.WriteLine(book.Equals(book));
                Console.WriteLine(book.GetHashCode());
                Console.WriteLine(book1.GetHashCode());
                Console.WriteLine(book.GetType());
                Console.WriteLine(book1.GetType());
                //int pages = "464"; is compile time error 
                // int pages=464;
                string pages = "464";
                int pagesNum = int.Parse(pages);
                Console.WriteLine(pagesNum);
                try
                {
                    int num = 10;
                    int num1 = 0;
                    int result = num / num1;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                finally
                {
                    Console.WriteLine("Done");
                }
                int pagesNumber = 300;
                double PageNumber = pagesNumber;
                Console.WriteLine(PageNumber);
                double price = 49.99;
                int priceInt = (int)price;
                Console.WriteLine(priceInt);
                string text = "464";
                int textInt = Convert.ToInt32(text);
                Console.WriteLine(textInt);
                string yearText = "2023";
                int YearInt = int.Parse(yearText);
                Console.WriteLine(YearInt);
                string badtext = "abc";

                bool badText = int.TryParse(badtext, out int badtextInt);
                if (badtextInt == 0)
                {
                    Console.WriteLine("Invalid number");
                }
                Console.WriteLine(badText);
                int pagesNumbers = 464;
                string pagesConvert = Convert.ToString(pagesNumbers);
                Console.WriteLine(pagesConvert);
                Console.WriteLine(pagesConvert.GetType());
                int copies = 100;
                object obj = copies;
            Console.WriteLine(obj);
                int newCopies = (int)obj;
                Console.WriteLine(newCopies);
            }
        }

}
