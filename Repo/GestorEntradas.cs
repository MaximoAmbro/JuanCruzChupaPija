using System;
using Entidades;

namespace Repo
{
    public class GestorEntradas
    {
        public byte[] QRCodeImage { get; set; }
        public void GenerarTicket(string NombreEvento, string NombreSector)
        {
            MensajeTicket = null;
            QRCodeImage = null;
            string hora = DateTime.Now.ToString();
            Guid idTicket = Guid.NewGuid();
            foreach (var c in eventos)
            {
                if (c.Nombre == NombreEvento)
                {
                    int codigoEvento = Guid.NewGuid().GetHashCode();
                    string CodigoEvento = codigoEvento.ToString().Substring(0, 8);
                    MensajeTicket =
                        "ENTRADA " + c.Nombre + "\n" +
                        "SECTOR: " + NombreSector + "\n" +
                        "PRECIO: " + c.Sectores.Find(x => x.Nombre == NombreSector).Precio.ToString() + "$\n" +
                        "HORARIO: " + hora + "\n" +
                        "FECHA: " + c.Fecha.ToString();

                    string contenidoQR = "CÓDIGO: " + CodigoEvento;

                    using (var qrGenerator = new QRCodeGenerator())
                    {
                        var qrCodeData = qrGenerator.CreateQrCode(contenidoQR, QRCodeGenerator.ECCLevel.Q);
                        using (var qrCode = new PngByteQRCode(qrCodeData))
                        {
                            QRCodeImage = qrCode.GetGraphic(20);
                        }
                    }
                    break;
                }
            }
        }
    }
}
