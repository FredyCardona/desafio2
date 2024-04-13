using System;
interface Notificable
{
    void Notifica(string mensaje);
}
class NotificacionEmail : Notificable
{
    private string direccionCorreo;
    public NotificacionEmail(string direccionCorreo)
    {
        this.direccionCorreo = direccionCorreo;
    }
    public void Notifica(string mensaje)
    {
        Console.WriteLine($"Enviando correo electrónico a {direccionCorreo}: {mensaje}");
    }
}
class NotificacionWhatsapp : Notificable
{
    private string numeroTelefono;
    public NotificacionWhatsapp(string numeroTelefono)
    {
        this.numeroTelefono = numeroTelefono;
    }
    public void Notifica(string mensaje)
    {
        Console.WriteLine($"Enviando mensaje por WhatsApp al número {numeroTelefono}: {mensaje}");
    }
}
class NotificacionSMS : Notificable
{
    private string numeroTelefono;
    public NotificacionSMS(string numeroTelefono)
    {
        this.numeroTelefono = numeroTelefono;
    }
    public void Notifica(string mensaje)
    {
        Console.WriteLine($"Enviando SMS al número {numeroTelefono}: {mensaje}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Notificable notificacionEmail = new NotificacionEmail("ejemplo@example.com");
        Notificable notificacionWhatsapp = new NotificacionWhatsapp("+1234567890");
        Notificable notificacionSMS = new NotificacionSMS("1234567890");
        notificacionEmail.Notifica("¡Hola desde el correo electrónico!");
        notificacionWhatsapp.Notifica("¡Hola desde WhatsApp!");
        notificacionSMS.Notifica("¡Hola desde SMS!");
    }
}
