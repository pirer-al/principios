package Animales;

public class Perro extends Animal {
    String nombre;

    public Perro(String nombre) {
        this.nombre = nombre;
    }


    @Override
    public void hacerSonido () {
        System.out.println("El perro hace guau guau");
    }
}

