using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost
{
    class Book
    {
        private string name;
        private string isbn; //  Kromě arabských číslic se v něm objevuje znak X (římská číslice 10) 
        private Author author;
        private int pages;
        //private int weight;
        //private int stock;


        public Book(Author author, int pages, string name)
        {
            this.author = author;
            this.pages = pages;
            this.name = name;
            //this.weight = weight;
            //this.stock = stock;
            //Console.Write("Čus");
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Isbn
        {
            get
            {
                return this.isbn;
            }
            set
            {
                this.isbn = value;
            }
        }

        public int Pages
        {
            get
            {
                return this.pages;
            }
            set
            {
                this.pages= value;
            }
        }

        public Author Author
        {
            get
            {
                return this.author;
            }
            set
            {
                this.author = value;
            }
        }


    }
}
