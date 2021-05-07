namespace Store.Homework
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class GoldCard : Card
    {
        public GoldCard(decimal turnover, decimal purchaseValue)
            : base(turnover, purchaseValue)
        {

        }
        public override string Type => "Gold";
    }
}
