namespace Store.Homework
{
    using Store.Homework.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class PayDesk
    {
        private const string WELCOME_TEXT = "Welcome to Discount Card Testing program! \n Info: \n To test different type of Discount Card Please enter:" +
            "\n 1. Bronze - for Bronze Discount Card." +
            "\n 2. Silver - for Silver Discount Card." +
            "\n 3. Gold - for Gold Discount Card." +
            "\n 4. ShutDown - to leave the Application.";

        private const string END_COMMNAD = "ShutDown";
        private const string BRONZE_COMMAND = "Bronze";
        private const string SILVER_COMMAND = "Silver";
        private const string GOLD_COMMAND = "Gold";

     
       

        public static void Run()
        {
            Client client1 = new Client();
            string input;

            Console.WriteLine(WELCOME_TEXT);
            Console.WriteLine();

            while ((input = Console.ReadLine()) != END_COMMNAD)
            {
                

                switch (input)
                {
                    case BRONZE_COMMAND:
                        {
                            client1.ShopingCard = new BronzeCard(0, 150);
                            break;
                        }
                    case SILVER_COMMAND:
                        {
                            client1.ShopingCard = new SilverCard(600, 850);
                            break;
                        }
                    case GOLD_COMMAND:
                        {
                            client1.ShopingCard = new GoldCard(1500, 1300);
                            break;
                        }
                }

                OutputPurchaseValue(client1.ShopingCard);
                OutputDiscountRate(client1.ShopingCard);
                OutputDiscount(client1.ShopingCard);
                OutputTotalPurchaseValue(client1.ShopingCard);

            }
        }

        public static void OutputPurchaseValue(Card card)
        {
            Console.WriteLine($"Purcahse Value: ${card.PurchaseValue:f2}");
            
        }
    
        public static void OutputDiscountRate(Card card)
        {
            Console.WriteLine($"Discount rate: {card.DiscountRate:f2}%");
        }

        public static void OutputDiscount(Card card)
        {
            Console.WriteLine($"Discount: ${card.Discount:f2}");
        }

        public static void OutputTotalPurchaseValue(Card card)
        {
            Console.WriteLine($"Total: ${card.TotalPurchaseValue:f2}");
        }

    }
}
