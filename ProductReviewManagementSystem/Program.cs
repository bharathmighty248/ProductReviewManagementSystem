using System;
using System.Collections.Generic;

namespace ProductReviewManagementSystem
{
    class Program
    {
        public static List<ProductReview> productReviewList = new List<ProductReview>()
        {
            new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 2, UserId = 1, Rating = 4, Review = "Nice", isLike = true },
            new ProductReview() { ProductId = 3, UserId = 1, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 4, UserId = 2, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 5, UserId = 2, Rating = 3, Review = "NotBad", isLike = false },
            new ProductReview() { ProductId = 6, UserId = 3, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 7, UserId = 4, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 8, UserId = 4, Rating = 3, Review = "NotBad", isLike = false },
            new ProductReview() { ProductId = 9, UserId = 4, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 10, UserId = 4, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 11, UserId = 5, Rating = 2, Review = "Bad", isLike = false },
            new ProductReview() { ProductId = 12, UserId = 5, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 13, UserId = 5, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 14, UserId = 5, Rating = 2, Review = "Bad", isLike = false },
            new ProductReview() { ProductId = 15, UserId = 6, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 16, UserId = 6, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 17, UserId = 6, Rating = 2, Review = "Bad", isLike = false },
            new ProductReview() { ProductId = 18, UserId = 6, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 19, UserId = 7, Rating = 3, Review = "NotBad", isLike = false },
            new ProductReview() { ProductId = 20, UserId = 7, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 21, UserId = 7, Rating = 4, Review = "Nice", isLike = true },
            new ProductReview() { ProductId = 22, UserId = 8, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 23, UserId = 8, Rating = 1, Review = "VeryBad", isLike = false },
            new ProductReview() { ProductId = 24, UserId = 9, Rating = 1, Review = "VeryBad", isLike = false },
            new ProductReview() { ProductId = 25, UserId = 10, Rating = 5, Review = "Good", isLike = true },
        };

        public static int choice;
        public static Management management = new Management();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product Review Management System");

            do
            {
                Console.WriteLine("____________________________________________________________\n");
                Console.Write("1. Retrieve Top 3 Records Whose Rating is High\n" +
                    "2. Retrieve Records Whose Rating is Above 3 of ProductID 1, 4 & 9\n" +
                    "3. Retrieve Count Of Review Present For Each ProductID\n" +
                    "4. Retrieve ProductId And Review\n" +
                    "5. Skip Top 5 Records\n" +
                    "6. Product Review DataTable\n" +
                    "0. Exit\n" +
                    "Select One Option: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("____________________________________________________________\n");
                switch (choice)
                {
                    case 1:
                        management.TopRecords(productReviewList);
                        break;
                    case 2:
                        management.SelectRecords(productReviewList);
                        break;
                    case 3:
                        management.RetrieveCountOfRecords(productReviewList);
                        break;
                    case 4:
                        management.RetrieveProductIdAndReview(productReviewList);
                        break;
                    case 5:
                        management.SkipTopFiveRecords(productReviewList);
                        break;
                    case 6:
                        management.ProductReviewDataTable(productReviewList);
                        break;
                    case 0:
                        Console.WriteLine("--------------------------Thankyou--------------------------");
                        Console.WriteLine("____________________________________________________________\n");
                        break;
                    default:
                        Console.WriteLine("-----------------------Invalid Option-----------------------");
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
