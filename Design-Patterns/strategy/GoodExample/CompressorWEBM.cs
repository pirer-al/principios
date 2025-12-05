namespace DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class CompressorWEBM : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing using WEBM");
        }
    }
}