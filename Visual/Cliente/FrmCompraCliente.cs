
using iText;
using iText.IO.Font;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Pdfa.Checker;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositorio;
using Negocio;
using Entidades;

namespace Visual
{
    public partial class FrmCompraCliente : Form
    {
        public string NombreEvento;
        public int IDUsuario;
        public int IDEvento;
        public SqlConnection ConexionSql;
        public string NombreUsuario;
        GestorEventos GestorEventos = new GestorEventos();
        public FrmCompraCliente()
        {
            frmEventosCliente frm = new frmEventosCliente();

            InitializeComponent();
        }
        private void FrmCompra_Load(object sender, EventArgs e)
        {
            CargarSectores();
        } // Una vez iniciado se cargan los sectores en CargarSectores
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmEventosCliente frm = new frmEventosCliente();
            frm.IDUsuario = IDUsuario;
            frm.ConexionSql = ConexionSql;
            frm.NombreUsuario = NombreUsuario;
            frm.Show();
            this.Hide();
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            int cantidadA = Convert.ToInt32(NumPrimero.Text);
            int CantidadB = Convert.ToInt32(NumSegundo.Text);
            int CantidadC = Convert.ToInt32(NumTercero.Text);
            int CantidadTotal = cantidadA + CantidadB + CantidadC;
            GenerarTicket();
            MessageBox.Show("Compra realizada con exito," + "revise documentos para recibir su entrada");
        }
        public void GenerarTicket()
        {

            int cantidadA = Convert.ToInt32(NumPrimero.Text);
            int CantidadB = Convert.ToInt32(NumSegundo.Text);
            int CantidadC = Convert.ToInt32(NumTercero.Text);
            int CantidadTickets = 0;
            int CantidadTotal = cantidadA + CantidadB + CantidadC;
            string carpetaTickets = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\A1.Tickets EVENTAURA";
            if (!Directory.Exists(carpetaTickets))
            {
                Directory.CreateDirectory(carpetaTickets);
            } 

            for (int i = 0; i <= CantidadTotal; i++)
            {
                string SectorNombre = ""; string PrecioSector = ""; string FechaEvento = "";
                string consulta = "SELECT Nombre FROM Eventos WHERE ID = @ID_Evento";
                using (SqlCommand sqlcomando = new SqlCommand(consulta, ConexionSql))
                {
                    sqlcomando.Parameters.Clear();
                    sqlcomando.Parameters.AddWithValue("@ID_Evento", IDEvento);
                    ConexionSql.Open();
                    object result = sqlcomando.ExecuteScalar();
                    NombreEvento = result.ToString();
                    ConexionSql.Close();
                }
                if (cantidadA > 0)
                {
                    SectorNombre = lblSectorA.Text;
                    PrecioSector = lblPrecioA.Text;
                }
                else if (CantidadB > 0)
                {
                    SectorNombre = lblSectorB.Text;
                    PrecioSector = lblPrecioB.Text;
                }
                else if (CantidadC > 0)
                {
                    SectorNombre = lblSectorC.Text;
                    PrecioSector = lblPrecioC.Text;
                }

                string consulta2 = "SELECT Fecha FROM Eventos WHERE ID = @ID_Evento";
                using (SqlCommand sqlcomando = new SqlCommand(consulta, ConexionSql))
                {
                    sqlcomando.Parameters.Clear();
                    sqlcomando.Parameters.AddWithValue("@ID_Evento", IDEvento);
                    ConexionSql.Open();
                    object result = sqlcomando.ExecuteScalar();
                    FechaEvento = result.ToString();
                    ConexionSql.Close();
                }
                string Ruta = System.IO.Path.Combine(carpetaTickets, $"Ticket_{NombreEvento}_{lblSectorA.Text}_{CantidadTickets}.PDF" );
                    CantidadTickets++;
                    GestorEventos.GenerarTicket(NombreEvento, SectorNombre, PrecioSector, FechaEvento);
                    GenerarPDF(Ruta, GestorEventos.MensajeTicket, GestorEventos.QRCodeImage);
                    cantidadA--;
                    CantidadTotal--;
            }

        }
        public void GenerarPDF( string ruta, string mensaje, byte[] QR)
        {
            PdfWriter pw = new PdfWriter(ruta);
            PdfDocument pdf = new PdfDocument(pw);
            // aca elegimos el tamaño de la pagina
            Document doc = new Document(pdf, PageSize.A6.Rotate());
            // aca seteamos el color de la pagina
            PdfPage page = pdf.AddNewPage();
            PdfCanvas canvas = new PdfCanvas(page);
            canvas.SetFillColor(ColorConstants.BLACK);
            canvas.Rectangle(0, 0, page.GetPageSize().GetWidth(), page.GetPageSize().GetHeight());
            canvas.Fill();

            // aca seteamos el color del texto
            doc.Add(new Paragraph(mensaje)
                .SetTextAlignment(TextAlignment.CENTER)
               .SetFontColor(ColorConstants.WHITE)
               .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD))
               .SetFontSize(10))
               .SetBottomMargin(50);

            // aca se agrega el QR y se setea tamaño y ubicacion
            var img = new iText.Layout.Element.Image(ImageDataFactory.Create(QR));
            img.ScaleAbsolute(100, 100);
            img.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
            doc.Add(img);

            doc.Close();
        }
        private void CargarSectores()
        {
            string consulta = "SELECT Nombre FROM Sectores WHERE EventoID = @ID_Evento AND PrecioID = @PrecioID";

            ConexionSql.Open();

            for (int i = 1; i <= 3; i++)
            {
                using (SqlCommand sqlcomando = new SqlCommand(consulta, ConexionSql))
                {
                    sqlcomando.Parameters.Clear();
                    sqlcomando.Parameters.AddWithValue("@ID_EventO", IDEvento);
                    sqlcomando.Parameters.AddWithValue("@PrecioID", i);

                    object result = sqlcomando.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        string nombre = result.ToString();
                        string etiqueta = nombre;

                        if (i == 1)
                            lblSectorA.Text = etiqueta;
                        else if (i == 2)
                            lblSectorB.Text = etiqueta;
                        else if (i == 3)
                            lblSectorC.Text = etiqueta;
                    }
                    else
                    {
                        if (i == 1) lblSectorA.Text = "";
                        else if (i == 2) lblSectorB.Text = "";
                        else if (i == 3) lblSectorC.Text = "";
                    }
                }
            }
            ConexionSql.Close();

            string consulta2 = "SELECT Precio FROM Sectores WHERE EventoID = @ID_Evento AND PrecioID = @PrecioID";

            ConexionSql.Open();

            for (int i = 1; i <= 3; i++)
            {
                using (SqlCommand sqlcomando = new SqlCommand(consulta2, ConexionSql))
                {
                    sqlcomando.Parameters.Clear();
                    sqlcomando.Parameters.AddWithValue("@ID_EventO", IDEvento);
                    sqlcomando.Parameters.AddWithValue("@PrecioID", i);

                    object result = sqlcomando.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        string precio = result.ToString();
                        string etiqueta = precio + " $";

                        if (i == 1)
                            lblPrecioA.Text = etiqueta;
                        else if (i == 2)
                            lblPrecioB.Text = etiqueta;
                        else if (i == 3)
                            lblPrecioC.Text = etiqueta;
                    }
                    else
                    {
                        if (i == 1) lblPrecioA.Text = "";
                        else if (i == 2) lblPrecioB.Text = "";
                        else if (i == 3) lblPrecioC.Text = "";
                    }
                }
            }

            ConexionSql.Close();
        } // Aca se llaman a los sectores de la base de datos y se cargan en los labels correspondientes
    }
}

