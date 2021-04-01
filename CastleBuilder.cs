using DesignPatterns_Builder.Interfaces;

namespace DesignPatterns_Builder
{
    public class CastleBuilder : IHomeBuilder
    {
        private Castle Resultado;

        public void CreateWindows()
        {
            System.Console.WriteLine("Criando janelas de um castelo");
        }

        public void CreateWalls()
        {
            System.Console.WriteLine("Criando paredes de pedra de um castelo");
        }

        public void CreateDoors(int quantidade)
        {
            System.Console.WriteLine($"Criando {quantidade} porta imensa de castelo");
        }
        public void Reset()
        {
            Resultado = new Castle(); 
        }

        public Castle Build(){
            return this.Resultado;
        }
    }
}