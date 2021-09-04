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
    }
}
