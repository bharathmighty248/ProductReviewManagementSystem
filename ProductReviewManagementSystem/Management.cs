using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementSystem
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

        public void TopRecords(List<ProductReview> review)
        {
            var recordedData = (from productReviews in review
                              orderby productReviews.Rating descending
                              select productReviews).Take(3);
            foreach(var list in recordedData)
            {
                Console.WriteLine("ProductId: " + list.ProductId + " " + "UserId: " + list.UserId + " " + "Rating: " + list.Rating + " " + "Review: " + list.Review + " " + "IsLike: " + list.isLike);
            }
        }

        public void SelectRecords(List<ProductReview> review)
        {
            var recordedData = (from productReviews in review
                                where (productReviews.ProductId==1 && productReviews.Rating>3) ||(productReviews.ProductId == 4 && productReviews.Rating > 3) || (productReviews.ProductId == 9 && productReviews.Rating > 3)
                                select productReviews);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId: " + list.ProductId + " " + "UserId: " + list.UserId + " " + "Rating: " + list.Rating + " " + "Review: " + list.Review + " " + "IsLike: " + list.isLike);
            }
        }

        public void RetrieveCountOfRecords(List<ProductReview> review)
        {
            var recordedData = review.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            Console.WriteLine("ProductId And Count");
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductId + "----------" + list.Count);
            }
        }

        public void RetrieveProductIdAndReview(List<ProductReview> review)
        {

            var recordedData = review.Select(x => new { ProductId = x.ProductId, Review = x.Review });
            Console.WriteLine("ProductId And Review ");
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductId + "----------" + list.Review);
            }
        }

        public void SkipTopFiveRecords(List<ProductReview> review)
        {
            var recordedData = (from productReview in review select productReview).Skip(5);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId: " + list.ProductId + " " + "UserId: " + list.UserId + " " + "Rating: " + list.Rating + " " + "Review: " + list.Review + " " + "IsLike: " + list.isLike);
            }
        }

    }
}
