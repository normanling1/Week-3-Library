﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book
    {
        string Title;
        string Author;
        string ISBN;

        //Example of a constructor that allows us to 'construct' a new book object

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }

        
    }
}
