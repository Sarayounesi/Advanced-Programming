using System;

namespace faliatClassie2
{
    class Program
    {
        static void Main()
        {
            Book s1 = new Book(Console.ReadLine(),Console.ReadLine(), int.Parse(Console.ReadLine()));
            Book s2 = new Book(Console.ReadLine(), Console.ReadLine());
            s1.printInfo();
            s2.printInfo();
        }
       
        }
    }
class Book
{
    private string Bookname ;
    private int papernum , price ;
    public Book(string Bookname, int price, int papernum)
    {
        this.Bookname = Bookname;
        this.price = price;
        this.papernum = papernum;
    }
    public Book(string Bookname, int price)
    {
        this.Bookname = Bookname;
        this.price = price;
        Random papernum = new Random();
        this.papernum = papernum.Next(9, 100);
    }
    public void printInfo()
    {
        Console.Write("Bookname = {0} price = {1} papernum = {2}", Bookname , price , papernum);
    }
}

