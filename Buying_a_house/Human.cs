using System;


namespace Buying_a_house
{
    class Human
    {
        private static string Default_name;
        private static int Default_age;

        public string name { get; private set; }
        public int age { get; private set; }

        private decimal Money { get; set; }
        private House house { get; set; }

        public Human (string name, int age) { Default_name = name; Default_age = age; }

        public Human(string name, int age, decimal money,House house):this(name,age) 
        { 
            this.Money = money ;
            
            this.house = house ; 
        }
        public void Info()
        {
            Console.WriteLine($"Ном: {Default_name} синни сол: {Default_age} пул: {Money} хона: {house}");
        }

        public static void Default_info()
        {
            Console.WriteLine($"Ном: {Default_name} синни сол: {Default_age}");
        }

        private void make_deal(House house,decimal price)
        {

            Money -= price;
            this.house = house;

        }

        public void earn_money()
        {
            ++Money;

        }

        public void buy_house(House house,decimal discount)
        {
            if (house.final_price(discount) > Money)
            {
                Console.WriteLine("Пулатон камтар аст!!!");
            }
            else
            {
                Console.WriteLine("Табрик Шумо хонаи нав сохиб шудед");
            }
        }
    }
}
