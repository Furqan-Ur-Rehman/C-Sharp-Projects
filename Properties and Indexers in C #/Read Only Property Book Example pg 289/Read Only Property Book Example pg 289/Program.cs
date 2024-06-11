using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Only_Property_Book_Example_pg_289
{
    class Books
    {
        //Declare fields/variables

        string _BookName;
        long _BookId;

        // Create Parameterized Constructor for set values in the fields through user input
        public Books(string Name, long value)
        {
            _BookName = Name;
            _BookId = value;
        }

        //Create Read-Only property
        public string BookName
        {
            get { return _BookName; }
        }

        public long BookId
        {
            get
            {
                return _BookId;
            }
        }

    }
    internal class Bookstore
    {
        static void Main(string[] args)
        {
            Books objbooks = new Books("C# Books ", 1005);
            Console.WriteLine("Book Name: " + objbooks.BookName);
            Console.WriteLine("Book ID: " + objbooks.BookId);

            Console.Read();
        }
    }
}
