using DesignPatternsGOF.Creational.Builder.Builders;
using DesignPatternsGOF.Creational.Builder.Studios;

namespace DesignPatternsGOF.Creational.Builder
{
    public class Client
    {
        public void Execute()
        {
            var director = new Director();

            StudioBuilder builder = new Studio24mBuilder();

            director.BuildStudio(builder);
            var studio = builder.GetStudio();
            Print(studio, "24m");

            //------------------------------------
            builder = new Studio26mBuilder();

            director.BuildStudio(builder);
            studio = builder.GetStudio();
            Print(studio, "26m");

            //------------------------------------
            builder = new Studio28mBuilder();

            director.BuildStudio(builder);
            studio = builder.GetStudio();
            Print(studio, "28m");
        }

        private static void Print
        (
            Studio studio,
            string name
        )
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"[+] - Studio {name}");
            Console.WriteLine("Valor: " + studio.Value.ToString("C"));
            Console.WriteLine("Piso: " + studio.Floor);
            Console.WriteLine("Financiamento: " + studio.Financing);
        }
    }
}
