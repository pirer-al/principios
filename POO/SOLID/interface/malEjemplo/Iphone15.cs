using System;

namespace malEjemplo {
    public class Iphone15 : Telefono {

        public Iphone15 (String marca, int modelo, int precio, int RAM) : base(marca, modelo, precio, RAM) {

        }

        public override void escribir () {
            Console.WriteLine($"Escribiendo desde el celular {marca}");
        }

        public override void llamar () {
            Console.WriteLine($"Llamando desde el celular {marca}");
        }   

        public override void pagarConNFC () {
            Console.WriteLine($"Pagando con el {marca}");
        }

        public override void usarAsistenteVirtual()
        {
            Console.WriteLine("Hablando con Siri");
        }    
        public override void desbloquearConHuella()
        {
            Console.WriteLine("Desbloqueando con FaceID");
        }

    
    }
}