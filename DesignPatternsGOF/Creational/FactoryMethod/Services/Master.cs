﻿using DesignPatternsGOF.Creational.FactoryMethod.Interfaces;

namespace DesignPatternsGOF.Creational.FactoryMethod.Services
{
    public class Master : IService
    {
        public Master()
        {
            Console.WriteLine("Product Master created.\n");
        }

        public void Charge()
        {
            //logic
        }
    }
}
