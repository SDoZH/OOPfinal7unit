using System;

namespace OOPfinal7unit
{
    abstract class Delivery
    {
        public string Address;
        public abstract void DisplayAdress();
    }

    class HomeDelivery : Delivery
    {
        public override void DisplayAdress()
        {
            Console.WriteLine("Выбран тип доставки: На дом ");
        }
    }

    class PickPointDelivery : Delivery
    {
        public override void DisplayAdress()
        {
            Console.WriteLine("Выбран тип доставки: На пункт выдачи ");
        }
    }

    class ShopDelivery : Delivery
    {
        public override void DisplayAdress()
        {
            Console.WriteLine("Выбран тип доставки: В розничный магазин ");
        }
    }

    class Order<TDelivery, TStruct>
     where TDelivery : Delivery
     where TStruct : struct
    {
        public TDelivery Delivery;

        public TStruct Struct;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

    }
    abstract class Product
    {
        public abstract void DisplayProduct();
    }
     class Book : Product
    {
       public int Id { get;}
        public string Tittle { get; }
        public Book(int id, string tittle)
        {
            Tittle = tittle;
            Id = id;
        }

        public override void DisplayProduct()
        {
          
        }
    }
    class Game : Product
    {
        public int Id { get; }
        public string Tittle { get; }
        public Game(int id, string tittle)
        {
            Tittle = tittle;
            Id = id;
        }

        public override void DisplayProduct()
        {

        }
    }
    class Food : Product
    {
        public int Id { get; }
        public string Tittle { get; }
        public Food(int id, string tittle)
        {
            Tittle = tittle;
            Id = id;
        }
        public override void DisplayProduct()
        {

        }
    }
}

