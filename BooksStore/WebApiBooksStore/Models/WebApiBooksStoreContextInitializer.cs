using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace WebApiBooksStore.Models
{
    public class WebApiBooksStoreContextInitializer : DropCreateDatabaseAlways<WebApiBooksStoreContext>
    {

        protected override void Seed(WebApiBooksStoreContext context)
        {
            var books = new List<Book>
            {

                 new Book() {Name = "Ready to Wed", Chapter = "One", Title = "Life Long Commitment", Author = " Greg Smalley", Summary ="Lifelong commitment begins with a decision that divorce is not an option and a determination to invest in your marriage every day.", Price = 15.65m},
                 new Book() {Name = "Ready to Wed", Chapter = "Two", Title = "Spending Enjoyable Time Together", Author = " Greg Smalley", Summary ="In the busyness of life, remember that love isn’t self-sufficient. Your marriage must be constantly fed and nurtured by spending regular time together.", Price = 13.08m},
                 new Book() {Name = "Ready to Wed", Chapter = "Three", Title = "Positive Communication", Author = " Greg Smalley", Summary ="Communication gives life to marriage when you spend time getting to know your spouse and allowing yourself to be deeply known by him or her.", Price = 9.05m},
                 new Book() {Name = "Ready to Wed", Chapter = "Four", Title = "Shared Spiritual Intimacy", Author = " Greg Smalley", Summary ="Couples who have a deep, shared faith and have Christ at the center of their marriage have a more satisfying relationship and deeper intimacy.", Price = 10.05m},
                 new Book() {Name = "Ready to Wed", Chapter = "Five", Title = "Healthy Individuals", Author = " Greg Smalley", Summary ="A healthy marriage is made of two healthy people. Commit to a lifetime of spiritual, emotional, physical and mental growth and development.", Price = 12.19m},
                 new Book() {Name = "Ready to Wed", Chapter = "Six", Title = "Mutually Satisfying Physical Intimacy", Author = " Greg Smalley", Summary ="Sex is God’s gift to a married couple as a way to experience the deepest, most profound intimacy possible—the two becoming one flesh.", Price = 8.99m},
                 new Book() {Name = "Ready to Wed", Chapter = "Seven", Title = "Healthy Conflict Management", Author = " Greg Smalley", Summary ="Conflict is an inevitable part of marriage, but handled well, healthy conflict can become an opportunity for deeper intimacy and connection.", Price = 18.03m},
                 new Book() {Name = "Ready to Wed", Chapter = "Eight", Title = "Shared Responsibility (Teamwork)", Author = " Greg Smalley", Summary ="Marriage means you are always on the same team. Make decisions and divide household responsibilities in a way that honors both of you.", Price = 5.89m},
                 new Book() {Name = "Ready to Wed", Chapter = "Nine", Title = "Coping With Change, Stress and Crises", Author = " Greg Smalley", Summary ="You will face challenges on your journey together. Always fight for your marriage and trust that God will turn your pain to blessing.", Price = 19.50m},
                 new Book() {Name = "Ready to Wed", Chapter = "Ten", Title = "Cherish", Author = " Greg Smalley", Summary ="Created by God, your fiancé(e) is of infinite worth and value. Reflect often on the things that you love and cherish about your future spouse.", Price = 2.04m},
                 new Book() {Name = "Ready to Wed", Chapter = "Eleven", Title = "Nourish", Author = " Greg Smalley", Summary ="Love involves action and behavior. You need to nourish your relationship with your fiancé(e) in ways that speak love to him or her.", Price = 5.17m},
                 new Book() {Name = "Ready to Wed", Chapter = "Twelve", Title = "Community-Mindedness", Author = " Greg Smalley", Summary ="Connecting regularly with like-minded couples who are committed to the good of your relationship is vital to the success of your marriage.", Price = 7.05m}
            };
            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();

            var order = new Order() { Customer = "John Smith", OrderDate = new DateTime(2015, 10, 27) };
            var details = new List<OrderDetail>()
            {

                new OrderDetail() { Book = books [0], Quantity = 1, Order = order},
	            new OrderDetail() { Book = books [2], Quantity = 3, Order = order},
	            new OrderDetail() { Book = books [3], Quantity = 5, Order = order},
	            new OrderDetail() { Book = books [5], Quantity = 2, Order = order},

                new OrderDetail() { Book = books [1], Quantity = 7, Order = order},
	            new OrderDetail() { Book = books [4], Quantity = 6, Order = order},
	            new OrderDetail() { Book = books [7], Quantity = 4, Order = order},
	            new OrderDetail() { Book = books [6], Quantity = 1, Order = order},
               
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();


            order = new Order() { Customer = "Abraham Nick", OrderDate = new DateTime(2015, 09, 08) };
            details = new List<OrderDetail>()
            {

                new OrderDetail() { Book = books [2], Quantity = 1, Order = order},
	            new OrderDetail() { Book = books [1], Quantity = 3, Order = order},
	            new OrderDetail() { Book = books [4], Quantity = 12, Order = order},
	            new OrderDetail() { Book = books [5], Quantity = 2, Order = order},

               
                new OrderDetail() { Book = books [10], Quantity = 11, Order = order},
	            new OrderDetail() { Book = books [2], Quantity = 4, Order = order},
	            new OrderDetail() { Book = books [11], Quantity = 12, Order = order},
	            new OrderDetail() { Book = books [8], Quantity = 6, Order = order},
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();


            order = new Order() { Customer = "Lawless Alex", OrderDate = new DateTime(2015, 10, 20) };
            details = new List<OrderDetail>()
            {

                new OrderDetail() { Book = books [1], Quantity = 1, Order = order},
	            new OrderDetail() { Book = books [1], Quantity = 2, Order = order},
	            new OrderDetail() { Book = books [3], Quantity = 2, Order = order},
	            new OrderDetail() { Book = books [4], Quantity = 3, Order = order},
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            order = new Order() { Customer = "Morgan Freeman", OrderDate = new DateTime(2015, 11, 29) };
            details = new List<OrderDetail>()
            {

                new OrderDetail() { Book = books [2], Quantity = 1, Order = order},
	            new OrderDetail() { Book = books [2], Quantity = 3, Order = order},
	            new OrderDetail() { Book = books [4], Quantity = 12, Order = order},
	            new OrderDetail() { Book = books [5], Quantity = 2, Order = order},

                new OrderDetail() { Book = books [10], Quantity = 11, Order = order},
	            new OrderDetail() { Book = books [2], Quantity = 4, Order = order},
	            new OrderDetail() { Book = books [11], Quantity = 12, Order = order},
	            new OrderDetail() { Book = books [8], Quantity = 6, Order = order},
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            order = new Order() { Customer = "Harrison Scott", OrderDate = new DateTime(2015, 12, 10) };
            details = new List<OrderDetail>()
            {

                new OrderDetail() { Book = books [3], Quantity = 10, Order = order},
	            new OrderDetail() { Book = books [9], Quantity = 8, Order = order},
	            new OrderDetail() { Book = books [7], Quantity = 9, Order = order},
	            new OrderDetail() { Book = books [6], Quantity = 7, Order = order},

                new OrderDetail() { Book = books [10], Quantity = 11, Order = order},
	            new OrderDetail() { Book = books [2], Quantity = 4, Order = order},
	            new OrderDetail() { Book = books [11], Quantity = 12, Order = order},
	            new OrderDetail() { Book = books [8], Quantity = 6, Order = order},
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();


            order = new Order() { Customer = "Tom Brady", OrderDate = new DateTime(2015, 12, 28) };
            details = new List<OrderDetail>()
            {

                new OrderDetail() { Book = books [2], Quantity = 1, Order = order},
	            new OrderDetail() { Book = books [2], Quantity = 3, Order = order},
	            new OrderDetail() { Book = books [4], Quantity = 12, Order = order},
	            new OrderDetail() { Book = books [5], Quantity = 2, Order = order},

                new OrderDetail() { Book = books [3], Quantity = 10, Order = order},
	            new OrderDetail() { Book = books [9], Quantity = 8, Order = order},
	            new OrderDetail() { Book = books [7], Quantity = 9, Order = order},
	            new OrderDetail() { Book = books [6], Quantity = 7, Order = order},

            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}