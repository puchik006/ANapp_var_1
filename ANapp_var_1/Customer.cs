using System;

namespace ANapp_var_1
{
    public class Customer
    {
        public void Purchase(ISellable product)
        {
            Console.WriteLine($"Congratulations! You bought {product} for {product.Price} $");
        }

        public void CollectMetall(IMetallCollectable product)
        {
            Console.WriteLine($"You collect {product.MetallMass} grams of metall from {product}");
        }
    }


}
