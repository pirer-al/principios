namespace DesignPatterns.Behavioral.Strategy
{
    public class VideoStorage
    {
        private Compressors _compressor;
        private Overlays _overlay;

        public VideoStorage(Compressors compressor, Overlays overlay = Overlays.None)
        {
            _compressor = compressor;
            _overlay = overlay;
        }

        public void SetCompressor(Compressors compressor)
        {
            _compressor = compressor;
        }

        public void SetOverlay(Overlays overlay)
        {
            _overlay = overlay;
        }

        public void Store(string fileName)
        {
            // Compressor logic
            if (_compressor == Compressors.MOV)
            {
                System.Console.WriteLine("Compressing using MOV");
            }
            else if (_compressor == Compressors.MP4)
            {
                System.Console.WriteLine("Compressing using MP4");
            }
            else if (_compressor == Compressors.WEBM)
            {
                System.Console.WriteLine("Compressing using WEBM");
            }

            // Overlay logic
            if (_overlay == Overlays.BlackAndWhite)
            {
                System.Console.WriteLine("Compressing using MOV");
            }
            else if (_overlay == Overlays.Blur)
            {
                System.Console.WriteLine("Compressing using MP4");
            }
            else if (_overlay == Overlays.None)
            {
                System.Console.WriteLine("Compressing using WEBM");
            }
            
            System.Console.WriteLine("Storing ");
        } 
    }
}