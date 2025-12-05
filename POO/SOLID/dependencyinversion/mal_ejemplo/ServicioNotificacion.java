package mal_ejemplo;
public class ServicioNotificacion {
    Correo correo = new Correo();
    public void notificar(String mensaje) {
        correo.enviar(mensaje);
    }
}