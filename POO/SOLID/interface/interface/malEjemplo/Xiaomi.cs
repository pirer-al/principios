using System;

namespace malEjemplo {
    public class Xiaomi : Telefono {

        public Xiaomi (String marca, int modelo, int precio, int RAM) : base(marca, modelo, precio, RAM) {

        }

        public override void escribir () {
            Console.WriteLine("Escribiendo desde el celular");
        }

        public override void llamar () {
            Console.WriteLine($"Llamando desde el celular {marca}");
        }   

        public override void pagarConNFC () {
            Console.WriteLine("Este dispositivo no tiene acceso a esta función");
        }

        public override void usarAsistenteVirtual()
        {
            Console.WriteLine("Este dispositivo no tiene acceso a esta función");
        }
        
        public override void desbloquearConHuella()
        {
            Console.WriteLine("Este dispositivo no tiene acceso a esta función");
        }
    
    }
}