using DesignPatterns_Builder.Interfaces;

namespace DesignPatterns_Builder
{
    public class HomeBuilder : IHomeBuilder
    {
        private Home Resultado = new Home();
        
        public void CreateWindows()
        {
            System.Console.WriteLine("Criando janelas de uma casa normal");
        }

        public void CreateWalls()
        {
            System.Console.WriteLine("Criando paredes de uma casa normal");
        }

        public void CreateDoors(int qtd)
        {
            System.Console.WriteLine($"Criando {qtd} portas de uma casa normal");
        }

        public void Reset()
        {
            Resultado = new Home();
        }

        public Home Build(){
            return this.Resultado;
        }
    

    }
}