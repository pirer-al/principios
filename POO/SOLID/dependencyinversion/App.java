import mal_ejemplo.*;
import buen_ejemplo.*;

public class App {
    public static void main(String[] args) {
        // Mal ejemplo
        ServicioNotificacion servicio = new ServicioNotificacion();
        servicio.notificar("Hola mundo");

        // Buen ejemplo
        Notificador email = new Email();
        Notificador whatsapp = new WhatsApp();
        Notificador sms = new Sms();

        ServicioNotificador servicio_email = new ServicioNotificador(email);
        ServicioNotificador servicio_whatsapp = new ServicioNotificador(whatsapp);
        ServicioNotificador servicio_sms = new ServicioNotificador(sms);

        servicio_email.notificar("Hola mundo via Email");
        servicio_whatsapp.notificar("Hola mundo via WhatsApp");
        servicio_sms.notificar("Hola mundo via SMS");
    }
}