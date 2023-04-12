using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Factory.concreteProduct;
using Factory.creator;
using Factory.product;

namespace Factory.concreteCreator
{
    public class PizzaFactorySP : PizzaFactoryMethod
    {
        protected override Pizza CriaPizza(string tipo)
        {
            switch (tipo.ToUpper())
            {
                case "M": return new PizzaMussarelaSP();
                case "C": return new PizzaCalabresaSP();
                default : return null;
            }
        }
    }
}