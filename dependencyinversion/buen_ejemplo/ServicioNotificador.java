package buen_ejemplo;
public class ServicioNotificador {
    private Notificador notificador = new Email();

    public ServicioNotificador(Notificador notificador) {
        this.notificador = notificador;
    }

    public void notificar (String mensaje) {
        notificador.notificar(mensaje);
    }
}