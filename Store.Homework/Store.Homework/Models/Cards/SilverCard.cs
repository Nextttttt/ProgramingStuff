namespace Store.Homework
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class SilverCard : Card
    {
        public SilverCard(decimal turnover, decimal purchaseValue)
            : base(turnover, purchaseValue)
        {

        }
        public override string Type => "Silver";
    }
}
