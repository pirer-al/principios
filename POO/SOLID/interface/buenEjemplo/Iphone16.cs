using System;

namespace buenEjemplo
{
    public class Iphone16 : TelefonoBasico, NFC, AsistenteVirtual, DesbloqueoBiometrico
    {
        public Iphone16(String marca, int modelo, int precio, int RAM) : base(marca, modelo, precio, RAM)
        {

        }

        public override void escribir()
        {
            Console.WriteLine($"Escribiendo desde mi {marca}");
        }

        public override void llamar()
        {
            Console.WriteLine($"Llamando desde {marca}");
        }

        public void pagarConNFC()
        {
            Console.WriteLine($"Pagando con el {marca}");
        }

        public void usarAsistenteVirtual()
        {
            Console.WriteLine("Hablando con Siri");
        }

        public void desbloquearConHuella()
        {

        }

    }
}