namespace Entities
{
   public static class EmisorExtension
  {
    public static string Mostrar(this EmisorDeWhatsapp emisor)
    {
      return emisor.ToString() + $"-telefono:{emisor.NumeroTelefono}";
    }

    public static string Mostrar(this EmisorDeEmails emisor)
    {
      return emisor.ToString() + $"-Emails:{emisor.Email}";
    }
  }
}
