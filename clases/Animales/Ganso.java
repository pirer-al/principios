package Animales;

public class Ganso extends Animal implements Volador {
    String nombre;

    public Ganso (String nombre) {
        this.nombre = nombre;
    }
    
    public void hacerSonido () {
        System.out.println("El ganso hace cuack cuack");
    }

    public void volar () {
        System.out.println("El ganso está volando");
    }

}
