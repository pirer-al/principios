package buen_ejemplo;

public class Email implements Notificador {
    @Override
    public void notificar(String mensaje) {
        System.out.println("Enviando email: " + mensaje);
    }
    
}
