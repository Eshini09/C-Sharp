﻿using Lab02;
using System;
namespace Lab02
{
    // A public class allows other classes to access the (Book) class
    public class Book
    {
        public String Title;
        public String Author;
    }
}

public class Program
{
    public static void Main()
    {
        Book book = new Book();
        book.Author = "Martin Wickramasinghe";
        book.Title = "Madol Duwa";

        Console.WriteLine(book.Title);
        Console.WriteLine(book.Author);

        Console.ReadKine();

    }
}
 
