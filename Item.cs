using static System.Console;

namespace StoreApplication
{
    class Item
    {
        public static int ItemTotal= 0;
        //GroupWork
        public string Name { get; set; }
        public double Price { get; set; }
        public string ReferenceNum { get; set; }
        
        //Outputs List of Items       
        public void OrderList()
        {
            string result = $"{Name}\n Price:{Price:C}\n Reference Number:{ReferenceNum}\n ";
            WriteLine(result);
        }

        public void AddItem() {
            ItemTotal += 1;
            WriteLine(ItemTotal);
        }

    }
}
