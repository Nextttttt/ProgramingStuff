using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Homework
{
    class BronzeCard : Card
    {
        public BronzeCard(decimal turnover, decimal purchaseValue)
            :base(turnover,purchaseValue)
        {

        }

        public override string Type => "Bronze";


    }
}
