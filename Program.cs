using BorderControl.Interfaces;

namespace BorderControl;
class Program
{
    static void Main(string[] args)
    {
        IEngine engine = new Engine();
        engine.Run();
    }
}
