namespace Store.Homework.Models
{

    using System;
    public class Client
    {

        

        public string ClientId { get; set; } = Guid.NewGuid().ToString();

        public Card ShopingCard { get; set; }

    }
}
