using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Example_pg_289
{
    class Books
    {
        string _BookName;
        long _BookID;
        public Books(string name, int value)
        {
            _BookName = name;
            _BookID = value;
        }
        public string BookName
        {
            get
            {
                return _BookName;
            }
        }

        public long BookID
        {
            get
            {
                return _BookID;
            }
        }
    }
    class BookStore
    {
        static void Main(string[] args)
        {
            Books objBooks = new Books("Learn C # in 21 Days",10015);
            Console.WriteLine("BookName: " + objBooks.BookName);
            Console.WriteLine("BookID: " + objBooks.BookID);

            //objBooks.BookName = "C # Books"; error occurred when we set value because

            Books objNewBooks = new Books("C # Book", 10020);
            Console.WriteLine("BookName: " + objNewBooks.BookName);
            Console.WriteLine("BookID: " + objNewBooks.BookID);
            Console.Read();
        }
    }
}
