using System;

namespace buenEjemplo {
    public abstract class TelefonoBasico 
    {
        public String marca;

        public int modelo;

        public int precio;

        public int RAM;

        public TelefonoBasico(String marca, int modelo, int precio, int RAM) {
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
        }

        public abstract void escribir();
        public abstract void llamar();
    }
}