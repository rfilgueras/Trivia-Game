using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication
{
    class Store
    {
        //Groupwork
        public string Name { get; set; }

        public int TotalCost { get; set; }


        //BY Rhona Filgueras
        static string storeName = "Art Stuff";       

        public static void Shop()
        {
            Title = storeName;
            WriteLine($"Welcome to {storeName}!\n");

            Buy();
        }
        //global vars
        //public static int ItemTotal;


        public static void Buy() //void to int
        {
           
            string Name = "Jane Doe";
            WriteLine("What is your name?");
            Name = ReadLine();
            WriteLine($"Hello {Name}! Thank you for choosing to shop at our store today!\n");
            WriteLine("Press enter to see our selection of items");
            ReadLine();


            Item item1 = new Item();
            item1.Name = ">> Princeton Long Acrilyc Brush";
            item1.Price = 9.08;
            item1.ReferenceNum = " No.51793";       
            item1.OrderList();
            //AddItem();

            //int ItemTotal = 0;
            WriteLine("Would you like to add this item to cart?");
            string offer1 = ReadLine();
            if (offer1 == $"yes")
            {
                item1.AddItem();
                WriteLine("Item has been added to your cart!\n");
                WriteLine($"Items in your cart: {Item.ItemTotal}\nCurrent Total: {item1.Price:C}\nPress enter to continue shopping\n");
            }
            
            Item item2 = new Item();
            item2.Name = ">> 8x11 Mixed Media Pad";
            item2.Price = 8.38;
            item2.ReferenceNum = "No. 62810";
            item2.OrderList();

            WriteLine("Would you like to add this item to cart?");
            string offer2 = ReadLine();
            if (offer2 == $"yes")
            {
                item2.AddItem();
                WriteLine("Item has been added to your cart!\n");
                WriteLine($"Items in your cart: {Item.ItemTotal}\nCurrent Total: {item1.Price + item2.Price:C}\nPress enter to continue shopping\n");

            }
            
            Item item3 = new Item();
            item3.Name = ">> Uni-Ball White Gelpen 3.0";
            item3.Price = 3.45;
            item3.ReferenceNum = "No. 73921";
            item3.OrderList();

            WriteLine("Would you like to add this item to cart?");
            string offer3 = ReadLine();
            if (offer3 == $"yes")
            {
                item3.AddItem();
                WriteLine("Item has been added to your cart!\n");
                WriteLine($"Items in your cart: {Item.ItemTotal}\nCurrent Total: {item1.Price + item2.Price + item3.Price:C}\nPress enter to continue shopping\n");

            }

           
            Item item4 = new Item();
            item4.Name = ">> G-Tech Black 0.4 Gel Pen";
            item4.Price = 2.30;
            item4.ReferenceNum = "No. 84102";
            item4.OrderList();

            WriteLine("Would you like to add this item to cart?");
            string offer4 = ReadLine();
            if (offer4 == $"yes")
            {
                item4.AddItem();
                WriteLine("Item has been added to your cart!\n");
                WriteLine($"Items in your cart: {Item.ItemTotal}\nCurrent Total: {item1.Price + item2.Price + item3.Price + item4.Price:C}\nPress enter to continue shopping\n");

            }

            Item item5 = new Item();
            item5.Name = ">> 5x7.5 Fabriano Dotted Line Notebook";
            item5.Price = 6.45;
            item5.ReferenceNum = "No. 95213";
            item5.OrderList();

            WriteLine("Would you like to add this item to cart?");
            string offer5 = ReadLine();
            if (offer5 == $"yes")
            {
                item5.AddItem();
                WriteLine("Item has been added to your cart!\n");
                WriteLine($"Items in your cart: {Item.ItemTotal}\n Total: {item1.Price + item2.Price + item3.Price + item4.Price + item5.Price:C}\n");
            }
            
            GoodBye();
           // ReadLine();
        }

        /*
        public static int AddItem()
        {
            //setting the Item total variable
            ItemTotal = ItemTotal + 1;
            return ItemTotal;
        }
        */

        public static void GoodBye() 
        {
            WriteLine($"Thank you for coming to {storeName} have a great day!");
        }
    }
}
