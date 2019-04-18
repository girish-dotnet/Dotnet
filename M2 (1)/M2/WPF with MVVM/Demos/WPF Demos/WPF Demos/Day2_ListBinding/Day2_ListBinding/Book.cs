using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2_ListBinding
{
    public class Book
    {
        public Book(string title, string publisher, string isbn,
              params string[] authors)
        {
            this.title = title;
            this.publisher = publisher;
            this.isbn = isbn;
            foreach (string author in authors)
            {
                this.authors.Add(author);
            }
        }
        public Book()
            : this("unknown", "unknown", "unknown")
        {
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string publisher;
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        private string isbn;
        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public override string ToString()
        {
            return title+" "+publisher+" "+isbn;
        }
        private readonly List<string> authors = new List<string>();
        public string[] Authors
        {
            get { return authors.ToArray(); }
        }
    }
}
