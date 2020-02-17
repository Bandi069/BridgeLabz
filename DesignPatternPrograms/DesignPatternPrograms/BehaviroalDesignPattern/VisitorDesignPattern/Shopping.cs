using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviroalDesignPattern.VisitorDesignPattern
{
    class Shopping
    {
        public  void MethodShopping()
        {

            IitemElement[] items = new IitemElement[]
            {
                new Book(20,"1234"),
                new Fruit(5,10,"Banana")
            };
            int total = CalculatePrice(items);
            Console.WriteLine("Total Price" + total);
        }
        public static int CalculatePrice(IitemElement[] titems)
        {
            IVisitor VisitObj = new Visit();
            int totalprice = 0;
            foreach(ItemElements items in items)
            {
                totalprice = totalprice + items.Acceppt(IVisitor);
            }
            return cost;
        }
    }
}
