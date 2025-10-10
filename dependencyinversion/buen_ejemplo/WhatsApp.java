package buen_ejemplo;
public class WhatsApp implements Notificador {
    @Override
    public void notificar(String mensaje) {
        System.out.println("Enviando mensaje: " + mensaje);
    }
}