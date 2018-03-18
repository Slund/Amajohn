using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Amajohn.Models;

// Using Database and initializer now instead
//namespace Amajohn.Infrastructure
//{
//    public static class Repository {
//        // List of products and invoices
//        public static List<Product> Products = new List<Product>();
//		public static List<Invoice> Invoices = new List<Invoice>();

//        // Constructor
//        static Repository()
//        {
//            // Create objects
//            // Creating and adding Books to Products
//            Book book1 = new Book("Adolf", "Mein Kampf", 99.95m, 2007);
//            book1.Publisher = "The Nazis";
//            book1.ISBN = "1337";
//            book1.ImageUrl = ("kampf.jpg");
//            book1.ProductId = 1;
//            book1.Category = "Book";
//            Products.Add(book1);

//			Book book2 = new Book("Bjarne Røgter", "Ole Lukøje", 149.50m, 2001);
//			book2.Publisher = "Forlaget";
//			book2.ISBN = "123129839127";
//			book2.ImageUrl = ("ole.jpg");
//            book2.ProductId = 2;
//            book2.Category = "Book";
//			Products.Add(book2);

//			Book book3 = new Book("Ole Lund Kirkegaard", "Hodja fra Pjort", 349.00m, 1996);
//			book3.Publisher = "Gyldendal";
//			book3.ISBN = "912312381239";
//			book3.ImageUrl = ("hodja.jpg");
//            book3.ProductId = 3;
//            book3.Category = "Book";
//			Products.Add(book3);

//			// Creating/Adding CDs
//			MusicCD cd1 = new MusicCD("Beatles", "Yellow Submarine", 24.75m, 1968);
//            cd1.ImageUrl = ("yellowsub.jpg");
//            cd1.Label = "Universal";
//            cd1.Category = "Music";
//            // Adding Tracks
//            cd1.AddTrack(new Track { Title = "Twist and Shout", Composer = "Johnny", Length = new TimeSpan(0, 4, 22) });
//            cd1.AddTrack(new Track { Title = "Song Two", Composer = "Blur", Length = new TimeSpan(0, 3, 24) });
//            cd1.AddTrack(new Track { Title = "Title", Composer = "Composer", Length = new TimeSpan(0, 2, 58) });
//			cd1.AddTrack(new Track { Title = "Twist and Shout", Composer = "Johnny", Length = new TimeSpan(0, 4, 22) });
//			cd1.AddTrack(new Track { Title = "Song Two", Composer = "Blur", Length = new TimeSpan(0, 3, 24) });
//			cd1.AddTrack(new Track { Title = "Title", Composer = "Composer", Length = new TimeSpan(0, 2, 58) });
//			cd1.AddTrack(new Track { Title = "Twist and Shout", Composer = "Johnny", Length = new TimeSpan(0, 4, 22) });
//			cd1.AddTrack(new Track { Title = "Song Two", Composer = "Blur", Length = new TimeSpan(0, 3, 24) });
//			cd1.AddTrack(new Track { Title = "Title", Composer = "Composer", Length = new TimeSpan(0, 2, 58) });
//			cd1.AddTrack(new Track { Title = "Twist and Shout", Composer = "Johnny", Length = new TimeSpan(0, 4, 22) });
//			cd1.AddTrack(new Track { Title = "Song Two", Composer = "Blur", Length = new TimeSpan(0, 3, 24) });
//			cd1.AddTrack(new Track { Title = "Title", Composer = "Composer", Length = new TimeSpan(0, 2, 58) });

//			cd1.Totaltime = cd1.GetPlayingTime();
//            cd1.ProductId = 4;
//            Products.Add(cd1);

//			// Creating/Adding Movies
//			Movie movie1 = new Movie("Jungle Book", 199.49m, "junglebook.jpg", "James Bond");
//            movie1.ProductId = 5;
//            movie1.Category = "Movie";
//			Movie movie2 = new Movie("Forest Gump", 249.00m, "forrest-gump.jpg", "Arnold");
//            movie2.ProductId = 6;
//            movie2.Category = "Movie";
//            Movie movie3 = new Movie("Gladiator", 129.74m, "gladiator.jpg", "Jennifer");
//            movie3.ProductId = 7;
//            movie3.Category = "Movie";

//            Products.Add(movie1);
//			Products.Add(movie2);
//			Products.Add(movie3);

            /* Creating Customers
            Customer customer1 = new Customer(1, "Lars", "Nielsen", "Nyborgsgade 17", "9002", "Valby");
            customer1.AddPhone("6012 2748");
            customer1.AddPhone("1233 3245");
            customer1.Birthdate = new DateTime(1990, 12, 28);

            Customer customer2 = new Customer(2, "Kurt", "Hansen", "Slesvigvej 122", "2002", "Tønder");
            customer2.AddPhone("4213 5243");
            customer2.Birthdate = new DateTime(1920, 12, 28);

			Customer customer3 = new Customer(3, "Peter", "Paulsen", "Klostergade 17", "8000", "Århus C");
			customer3.AddPhone("6012 2748");
			customer3.Birthdate = new DateTime(1982, 12, 28);

			Customer customer4 = new Customer(4, "Martin", "Refslund", "Mejlgade 31", "8000", "Århus C");
			customer4.AddPhone("4213 5243");
			customer4.Birthdate = new DateTime(1912, 12, 28);

            // Creating Invoices and adding products
            Invoice invoice1 = new Invoice(1, new DateTime(28, 09, 25), customer1);
            invoice1.AddOrderItem(new OrderItem(book1, 2));
            invoice1.AddOrderItem(new OrderItem(cd1, 1));
			Invoices.Add(invoice1);

			Invoice invoice2 = new Invoice(2, new DateTime(26, 09, 25), customer2);
            invoice2.AddOrderItem(new OrderItem(movie1, 1));
			invoice2.AddOrderItem(new OrderItem(movie2, 1));
            Invoices.Add(invoice2);

			Invoice invoice3 = new Invoice(3, new DateTime(28, 09, 25), customer3);
			invoice3.AddOrderItem(new OrderItem(book1, 1));
			invoice3.AddOrderItem(new OrderItem(cd1, 1));
			invoice3.AddOrderItem(new OrderItem(book3, 1));
			Invoices.Add(invoice3);

			Invoice invoice4 = new Invoice(4, new DateTime(26, 09, 25), customer4);
			invoice4.AddOrderItem(new OrderItem(movie1, 1));
			invoice4.AddOrderItem(new OrderItem(movie2, 1));
			invoice4.AddOrderItem(new OrderItem(movie3, 1));
            invoice4.AddOrderItem(new OrderItem(book1, 1));
			Invoices.Add(invoice4);

            Invoice invoice5 = new Invoice(2, new DateTime(23, 10, 25), customer2);
            invoice5.AddOrderItem(new OrderItem(book2, 2));
            invoice5.AddOrderItem(new OrderItem(cd1, 1));
            Invoices.Add(invoice5);
            */
//		}
//    }
//}