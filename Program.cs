using DesignPatterns_Builder.Interfaces;

namespace DesignPatterns_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeBuilder builder = new HomeBuilder(); 
            builder.CreateWindows();
            builder.CreateWalls();
            builder.CreateDoors(5);

            Home concreteHome = builder.Build();

            builder.Reset();

            System.Console.WriteLine("------------- ");

            CastleBuilder builderCastle = new CastleBuilder();
            builderCastle.CreateWindows();
            builderCastle.CreateWalls();
            builderCastle.CreateDoors(1);
            
            Castle concreteCastle = builderCastle.Build();

            
       

        }
    }
}
