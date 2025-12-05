namespace DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class CompressorMOV : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing video using MOV");
        }
    }
}