using DesignPatternsGOF.Structural.Composite.Models;

namespace DesignPatternsGOF.Structural.Composite
{
    public class Client
    {
        public void Execute()
        {
            Component product1 = new ProductLeaf("Cup", 25.00);
            Component product2 = new ProductLeaf("Shirt", 80.00);
            Component product3 = new ProductLeaf("Shoes", 200.00);
            Component product4 = new ProductLeaf("Plane", 10000.00);

            Component smallBox = new ProductComposite();

            smallBox.Add(product1, product2, product3);

            Component bigBox = new ProductComposite();

            bigBox.Add(product4, smallBox);

            var value = bigBox.Operation();

            Console.WriteLine("Total value: " + value.ToString("C"));
        }
    }
}
