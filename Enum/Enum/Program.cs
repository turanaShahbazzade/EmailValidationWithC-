using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
       // public enum WeekDays { Monday, Tuesday, Wednesday };
        static void Main(string[] args)
        {
            //int num = 0;
            //switch (num)
            //{

            //    case(int)WeekDays.Monday:
            //        Console.WriteLine("Today it is Monday");
            //        break;

            //    case (int)WeekDays.Tuesday:
            //        Console.WriteLine("Today it is Tuesday");
            //        break;
            //    default:
            //        break;
            //}
            //Write(null);

            //bool? isTrue = null;
            // ? isaresi nullable demekdi bu isareni qoymaqla deyirem ki
            // menim deyisenim null ola bilir
            //Book b1 = new Book("Davainchinin shifresi");
            //Book b2 = new Book("Heyat eshqi");
            //Book b3 = new Book("Cehennem");
            //Library libraff = new Library();
            //libraff.AddBook(0, b1);
            //libraff.AddBook(1, b2);
            //libraff.AddBook(2, b3);
            //libraff.ShowBooks();
            //Console.WriteLine(libraff.GetBook(2)); 

            //Person p1 = new Person("Turana", 23);
            //Person p2 = new Person("Celal", 28);
            //Person p3 = new Person("Nargis", 0);
            //Person[] people = { p1, p2, p3 };
            //Array.Sort(people);

            string email = "turaneshahbazzadegmail.com";
            Console.WriteLine(email.isEmail()); 

            //Console.WriteLine(IsEmail(email));
        }

        //static bool IsEmail(string email)
        //{
        //    try
        //    {
        //        MailAddress mail = new MailAddress(email);
        //        return true;
        //    }
        //    catch (Exception)
        //    {

        //        return false;
        //    }
        //}
        #region Nullable
        //public static void Write(int? n)
        //{
        //    if (n == null)
        //    {
        //        Console.WriteLine("Hi there, this is main page");
        //        return;

        //    }
        //    Console.WriteLine(n);
        //}
        #endregion
      
    }
    class Library
    {
        public string Name { get; set; }
        private Book[] books;
        public Library()
        {
            books = new Book[100];

        }

        public void AddBook(int index, Book book)
        {
            try
            {
                books[index] = book;
            }
            catch (Exception)
            {

                Console.WriteLine("There is no such kind of index");
            }
        }
        public Book GetBook(int index)
        {
            try
            {
             return books[index];
            }
            catch (Exception)
            {

                return null;
            }
        }
        public void ShowBooks()
        {
            foreach (Book item in books)
            {
                if (item != null)
                
                    Console.WriteLine(item);
                
            }
        }
    }
    class Book
    {
        public string Name { get; set; }
        public Book (String Name)
        {
            this.Name = Name;

        }
        public override string ToString()
        {
            return Name;
        }
    }

    class Person:IComparable
    {
        public string  Name { get; set; }

        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }

        public int CompareTo(object obj)
        {
            return Age.CompareTo((Person)obj);

            
        }
    }
}
