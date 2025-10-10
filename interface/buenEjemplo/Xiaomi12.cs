using System;

namespace buenEjemplo {
    public class Xiaomi12 : TelefonoBasico, DesbloqueoBiometrico
    {
        public Xiaomi12(String marca, int modelo, int precio, int RAM) : base(marca, modelo, precio, RAM)
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

        public void desbloquearConHuella()
        {

        }

    }
}