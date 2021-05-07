namespace Store.Homework
{
    using Store.Homework.Cards;
    using System;
    using System.Collections.Generic;
    using System.Text;
     public abstract class Card : BaseModel
    {
        private const decimal NO_DISCOUNT = 0M;
        private const decimal ONE_P_DISCOUNT = 1M;
        private const decimal TWO_P_DISCOUNT = 2M;
        private const decimal TWOH_P_DISCOUNT = 2.5M;
        private const decimal THREEH_P_DISCOUNT = 3.5M;
        private const decimal FULL_GOLD_DISCOUNT = 10M;
        private const decimal VALUE_100 = 100;
        private const decimal VALUE_300 = 300;
        private const decimal VALUE_900 = 900;



        private readonly decimal turnover = 0M;
        private decimal purchaseValue = 0M;
        private readonly decimal discountRate = 0M;
        private readonly decimal discount = 0M;
        private readonly decimal totalPurchaseValue = 0M;

        public Card(decimal _turnover, decimal _purchaseValue)
        {

            turnover = _turnover;
            purchaseValue = _purchaseValue;


            if (Type == "Bronze")
            {
                if (turnover < VALUE_100)
                {
                    discountRate = NO_DISCOUNT;
                }
                else if (turnover <= VALUE_300)
                {
                    discountRate = ONE_P_DISCOUNT;
                }
                else
                {
                    discountRate = TWOH_P_DISCOUNT;
                }
            }

            if (Type == "Silver")
            {
                discountRate = TWO_P_DISCOUNT;
                if (turnover > VALUE_300)
                {
                    discountRate = THREEH_P_DISCOUNT;
                }
            }

            if (Type == "Gold")
            {
                discountRate = TWO_P_DISCOUNT;

                if (turnover >= VALUE_100 && turnover < VALUE_900)
                {

                    discountRate = TWO_P_DISCOUNT + Math.Floor(turnover / 100);

                }
                else
                {
                    discountRate = FULL_GOLD_DISCOUNT;
                }
            }

            discount = PurchaseValue * DiscountRate / VALUE_100;
            totalPurchaseValue = purchaseValue - discount;

        }
        public decimal PurchaseValue 
        { 
            get
            {
                return purchaseValue;
            }
            set
            {
                purchaseValue = PurchaseValue;
            }
            
        }

        public decimal DiscountRate
        {
            get
            {

                return discountRate;

            }
            
        }

        public decimal Discount
        {
            get
            {
                return discount;
            }
            
        }

        public decimal TotalPurchaseValue
        {
            get
            {
                return totalPurchaseValue;
            }
           
        }

    }
}
