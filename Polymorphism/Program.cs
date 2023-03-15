using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Megazine m = new Megazine();
            m.OrderQty = 1000;
            m.Title = "Azab";
            m.Price = 5000000;

            Publication p = m;
            Console.WriteLine("Judul Buku : "+p.Title+"\nHarga : Rp. "+p.Price+"\nQty :"+m.OrderQty);

            PC komputer = new PC();
            VM virtualmechine = new VM();

            ICommand device = komputer;
            device.command("PC : YA");
            Console.WriteLine("\n"+device);

            device = virtualmechine;
            device.command("VM : YA");
            Console.WriteLine("\n"+device);

        }
    }
    class Publication
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }
    class Megazine : Publication
    {
        public int OrderQty { get; set; }
    }
    interface ICommand
    {
        public string command(string input);
    }
    interface IPrint
    {
        public void print(string input);
    }
    class PC : ICommand, IPrint
    {
        public string command(string input)
        {
            return "PC : YA";
        }

        public void print(string input)
        {
            input = "PC : YA";
            Console.WriteLine(input);
        }
    }
    class VM : ICommand
    {
        public string command(string input)
        {
            return "VM : YA";
        }
    }
}
