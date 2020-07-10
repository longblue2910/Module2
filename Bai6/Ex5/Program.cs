using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Chim chichcheo = new Chim();
            chichcheo.Bay();
            chichcheo.Chay();
            chichcheo.TimeBay();
            MayBay boing = new MayBay();
            boing.Bay();
            boing.Chay();
            boing.TimeBay();
        }
    }
    public interface IBay
    {
        void Bay();
    }
    public interface IChay
    {
        void Chay();
    }
    public interface ITimeBay
    {
        void TimeBay();
    }
    public class Chim : IBay , IChay, ITimeBay
    {
        public void Bay()
        {
            Console.WriteLine("Chim : Bay");
        }
        public void Chay()
        {
            Console.WriteLine("Chim : Chay bang 2 chan");
        }
        public void TimeBay()
        {
            Console.WriteLine("Chim bay den luc nao moi canh thi thoi");
        }
    }
    public class MayBay : IBay, IChay, ITimeBay
    {
        public void Bay()
        {
            Console.WriteLine("May Bay : Bay");
        }
        public void Chay()
        {
            Console.WriteLine("May bay : Chay bang 3 banh xe");
        }
        public void TimeBay()
        {
            Console.WriteLine("May banh : Bay khi nao het nhien lieu thi thoi");
        }
    }
}
