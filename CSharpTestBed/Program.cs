using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;

namespace CSharpTestBed
{
    abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();

    }

    class MyBook : Book
    {
        private int price;

        public MyBook(String t, String a, int p) : base(t, a)
        {
            price = p;
        }

        public override void display()
        {
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Author: {0}", author);
            Console.WriteLine("Price: {0}", price);
        }
    }

    class Solution
    {
        static void Main(String[] args)
        {
            String title = "The Alchemist";//Console.ReadLine();
            String author = "Paulo Coelho";//Console.ReadLine();
            int price = 248;//Int32.Parse(Console.ReadLine());

            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }


}
