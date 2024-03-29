﻿namespace Assignment_Creational_Design_Patterns.Products.Coffe
{
    using Assignment_Creational_Design_Patterns.Products.Milk;

    public interface ICoffee
    {
        public int BlackCoffee { get; set; }

        public int CubesSugar { get; set; }

        public List<IMilk> Milk { get; set; }
    }
}
