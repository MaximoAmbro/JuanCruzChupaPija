using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Entidades;
using QRCoder;
using static Entidades.Evento;
namespace Negocio
{
    public partial class GestorEventos //Lista
    {
        List<Evento> eventos = new List<Evento>();
        public string SectorA { get; set; }
        public string SectorB { get; set; }
        public string SectorC { get; set; }
        public string PrecioA { get; set; }
        public string PrecioB { get; set; }
        public string PrecioC { get; set; }
        public int TotalEntradas { get; set; }
        public string MensajeTicket { get; set; }
        public byte[] QRCodeImage { get; set; }
    }
    public partial class GestorEventos //Metodos
    {
        public bool BuscarLista(string NombreEvento)
        {
            Evento evento1 = null;
            foreach (var c in eventos)
            {
                if (c.Nombre == NombreEvento)
                {
                    evento1 = c;
                    break;
                }
            }
            if (evento1 == null)
            {

                return false;
                throw new Exception("Evento no encontrado");
            }
            else
            {
                SectorA = evento1.Sectores[0].Nombre;
                SectorB = evento1.Sectores[1].Nombre;
                SectorC = evento1.Sectores[2].Nombre;
                PrecioA = evento1.Sectores[0].Precio.ToString();
                PrecioB = evento1.Sectores[1].Precio.ToString();
                PrecioC = evento1.Sectores[2].Precio.ToString();
                return true;
            }
        }

        public void GenerarTicket(string NombreEvento, string NombreSector, string PrecioSector, string FechaEvento)
        {
            MensajeTicket = null;
            QRCodeImage = null;
            string hora = DateTime.Now.ToString();
            Guid idTicket = Guid.NewGuid();

                    int codigoEvento = Guid.NewGuid().GetHashCode();
                    string CodigoEvento = codigoEvento.ToString().Substring(0, 8);
                    MensajeTicket =
                        "ENTRADA " + NombreEvento + "\n" +
                        "SECTOR: " + NombreSector + "\n" +
                        "PRECIO: " + PrecioSector + "$\n" +
                        "FECHA: " + FechaEvento + "\n";

            string contenidoQR = "CÓDIGO: " + CodigoEvento;

                    using (var qrGenerator = new QRCodeGenerator())
                    {
                        var qrCodeData = qrGenerator.CreateQrCode(contenidoQR, QRCodeGenerator.ECCLevel.Q);
                        using (var qrCode = new PngByteQRCode(qrCodeData))
                        {
                            QRCodeImage = qrCode.GetGraphic(20);
                        }
                    }

        } 
        public List<Evento> ObtenerListaEventos()
        {
            return eventos;
        }
        public void DevolverEntrada(string NombreEvento)
        {
            foreach (var c in eventos)
            {
                if (c.Nombre == NombreEvento)
                {
                    break;
                }
            }
        }
    }
    
}
    
