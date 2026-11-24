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
            int pages = 400;
            int res = AddBonusPages(pages);
            Console.WriteLine(pages);//pages = 400 because it value type method not effect on it 


            #endregion

            #region Q06
            ////Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
            //// with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            ////see, and why?
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);//20.5 because it ref type method  create the operation on the same ref

            #endregion
        }
        //static void PrintWelcomMessage()
        //{
        //    Console.WriteLine("Welcom to the Library!.");
        //}

        //static  void PrintBookTitle(string title)
        //{
        //    Console.WriteLine("Book title: " + title);
        //}

        static int AddBonusPages(int pages)
        {
            return pages + 50;
        }
        //    static double[] ApplyDiscount(double[] prices )
        //    {
        //        prices[0] -= 5;
        //        return prices;
        //    }
    }
}
