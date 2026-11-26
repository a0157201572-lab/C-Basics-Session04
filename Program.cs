namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //1- Create a one-dimensional array double[] prices with the values 25.5, 40.0, and 33.75. Print the second price (index 1).

            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion

            #region Questoon 2
            // 2- Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.


            //int[,] shelfCopies =
            //{
            //    {5,3 },
            //    {4,1 }
            //};
            //Console.WriteLine(shelfCopies[1,0]);
            #endregion

            #region Question 3
            // 3-Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!". Call it from Main.


            //static void printWelcomeMessage()
            //{
            //    Console.WriteLine("Welcome to the library!");
            //}
            //printWelcomeMessage();
            #endregion

            #region Question 4
            // 4- Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".

            //static void printBookTitle(string title)
            //{
            //    Console.WriteLine("Book Title:"+ title);
            //   }
            //    printBookTitle("Clean Code");


            #endregion

            #region Question 5
            // 5-Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why?


            //static void AddBoundsPages(int pages)
            //{
            //    pages = pages + 50;
            //}
            //int pages = 400;
            //AddBoundsPages(pages);
            //Console.WriteLine(pages);
            #endregion

            #region Question 6 
            // 6-Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to see, and why?

            //static void ApplyDiscount(double[] prices)
            //{
            //    prices[0] = prices[0] - 5;
            //}
            //double[] discountPrices =  {25.5, 40.0};

            //ApplyDiscount(discountPrices);
            //Console.WriteLine(discountPrices[0]);


            #endregion

            #region Questuion 7
            // 7- Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. Call it and print pages afterward. How is the result different from question 5?

            //static void AddBonusPagesByRef(ref int pages)
            //{
            //    pages = pages + 50;
            //}
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);

            #endregion

            #region Question 8
            // 8- Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length afterward.

            //static void ReplaceArray(ref double[] prices)
            //{
            //    prices = new double[] { 10.0, 12.5, 15.0 };
            //}
            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);
            #endregion

            #region Question 9
            // 9-a method bool TryGetPrice(string title, out double price) that returns true and sets price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0. Call it and print the price if found.

            //static bool TryGetPrice(string title , out double price)
            //{
            //    if
            //        (title == "Clean Code")
            //    {
            //        price = 25.5;
            //        return true;
            //    }
            //    else
            //    {
            //        price = 0;
            //        return false;
            //    }
            //}
            //double price;
            //if
            //    (TryGetPrice("Clean Code ",out price))
            //{
            //    Console.WriteLine(price);
            //}

            #endregion

            #region Question 10
            // 10- Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call it once with only a title, and once passing both a title and pages.

            //static void PrintBookInfo(string title, int pages = 300)
            //{
            //    Console.WriteLine("title:" + title);
            //    Console.WriteLine("pages:" + pages);
            //}
            //PrintBookInfo("Clean Code");
            //PrintBookInfo("c# Basics", 450);
            #endregion

            #region Question 11
            // 11-Using the PrintBookInfo method from the question above, call it by naming the parameters, passing pages before title.


            ////PrintBookInfo(pages: 450, title: "Clean Code");
            #endregion

            #region Question 12
            // 12-Write a method PrintAllTitles(params string[] titles) that prints each title on its own line. Call it with three book titles.

            static void PrinAllTitles (params string[] titles)
            {
                foreach 
                    (string title in titles)
                {
                    Console.WriteLine(title);
                }
            }
            PrinAllTitles("Clean Code", "C# Basics", "JavaScript");

            #endregion

        }
    }
}
