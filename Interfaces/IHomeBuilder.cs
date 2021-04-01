namespace DesignPatterns_Builder.Interfaces
{
    public interface IHomeBuilder
    {
        void CreateWalls();
        void CreateDoors(int qtd);
        void CreateWindows();
        
        void Reset();
    }
}