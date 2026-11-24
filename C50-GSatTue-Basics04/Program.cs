using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C50_GSatTue_Basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            ////Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
            ////the second price(index 1).
            //double[] arr1 = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(arr1[1]);
            #endregion

            #region Q02
            ////Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            ////shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            //int[,] shelf = {
            //{ 3,5},
            //{ 1,4 } };
            //Console.WriteLine(shelf[1, 0]);

            #endregion

            #region Q03
            ////Write a method called PrintWelcomeMessage that takes no parameters and prints
            ////"Welcome to the Library!".Call it from Main.
            //PrintWelcomMessage();

            #endregion

            #region Q04
            ////Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
            ////"Clean Code".
            //PrintBookTitle("Clean Code");

            #endregion

            #region  Q05
            //Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            //int pages = 400; and print pages afterward. What do you expect to see, and why?
            //int pages = 400;
            //int res = AddBonusPages(pages);
            //Console.WriteLine(pages);//pages = 400 because it value type method not effect on it 


            #endregion

            #region Q06
            ////Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
            //// with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            ////see, and why?
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);//20.5 because it ref type method  create the operation on the same ref

            #endregion

            #region Q07
            ////Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            //// Call it and print pages afterward. How is the result different from question 5 ?
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);//450 because we passed the parameter using ref ,which effect the  original variable itself

            #endregion


            #region Q08
            ////Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
            ////new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
            ////afterward
            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);

            #endregion

            #region Q09
            ////Write a method bool TryGetPrice(string title, out double price) that returns true and sets
            ////price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it2
            ////and print the price if found
            //bool res = TryGetPrice("Clean Code", out double price);
            //if(res) Console.WriteLine(price);


            #endregion

            #region Q10
            ////Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call
            ////it once with only a title, and once passing both a title and pages.
            //PrintBookInfo("Clean Code");
            //int pages = 900;
            //PrintBookInfo("Clean Code with pages", pages);
            #endregion


            #region Q11
            ////Using the PrintBookInfo method from the question above, call it by naming the
            ////parameters, passing pages before title.
            //int pages = 900;
            //PrintBookInfo(pages: pages, title: "Clean Code in q11");

            #endregion

            #region Q12
            //Write a method PrintAllTitles(params string[] titles) that prints each title on its own line.
            //Call it with three book titles.
            string bookTitle1 = "book1";
            string bookTitle2 = "book2";
            string bookTitle3 = "book3";


            PrintAllTitles(bookTitle1,bookTitle2,bookTitle3);
            #endregion
        }

        #region Fun
        //static void PrintWelcomMessage()
        //{
        //    Console.WriteLine("Welcom to the Library!.");
        //}

        //static  void PrintBookTitle(string title)
        //{
        //    Console.WriteLine("Book title: " + title);
        //}

        //static int AddBonusPages(int pages)
        //{
        //    return pages + 50;
        //}
        //    static double[] ApplyDiscount(double[] prices )
        //    {
        //        prices[0] -= 5;
        //        return prices;
        //    }

        //static int AddBonusPagesByRef(ref int pages)
        //{
        //    return pages + 50;


        //}

        //static double[] ReplaceArray(ref double[] prices)
        //{
        //    prices = new double[] { 10.0, 12.5, 15.0 };
        //    return prices;

        //}
        //static bool TryGetPrice(string title, out double price)
        //{
        //    if (title == "Clean Code")
        //    {
        //        price = 25.5;
        //        return true;
        //    }

        //    price = 0;
        //    return false;
        //}

        //static void PrintBookInfo(string title, int pages = 300)
        //{
        //    Console.WriteLine($"title is :{title} and the pages are:{pages}");
        //}
        static void PrintAllTitles(params string[] titles)
        {
            foreach (string bookTitle in titles)
            {
                Console.WriteLine(bookTitle);
            }

        }
        #endregion
    }
}
