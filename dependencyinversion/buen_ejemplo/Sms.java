package buen_ejemplo;
public class Sms implements Notificador {
    @Override
    public void notificar(String mensaje) {
        System.out.println("Enviando sms: " + mensaje);
    }
}