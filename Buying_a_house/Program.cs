using System;

namespace Buying_a_house
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Human.Default_info();  //1
            Human human = new Human("Shahzodjon",21,30000,null);//2
          
            human.Info(); //3

            SmallHouse small = new SmallHouse(40,30000); //4
          
            human.buy_house(small,25);//5
            human.earn_money();
           
            Console.ReadKey();

        }

    }
}
