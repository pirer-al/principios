import Animales.*;

class App {
    public static void main(String[] args) throws Exception{
        Perro miPerro = new Perro("Juan");
        Ganso miGanso = new Ganso("Gomez");        
        
        miPerro.hacerSonido();
        miGanso.hacerSonido();
        
        miGanso.volar();
    
    }
}
