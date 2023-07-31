using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using System.IO;
using System.Data;
using System.Data.SqlClient;


//Agregar usings necesarios

namespace WindowsForms.SP
{
    //Agregar manejo de excepciones en TODOS los lugares críticos!!!
    public partial class SegundoParcial : Form
    {
        private Lapiz lapiz;
        private Goma goma;
        private Sacapunta sacapunta;

        private Cartuchera<Utiles> c_utiles;
        private Cartuchera<Lapiz> c_lapices;
        private Cartuchera<Goma> c_gomas;

        private SqlConnection cn;
        private SqlDataAdapter da;
        private DataTable dt;
        public delegate void InsertarRows(object u, EventArgs e);
        public event InsertarRows añado;

        public SegundoParcial()
        {
            InitializeComponent();

            this.dt = new DataTable("utiles");
            this.dt.Columns.Add("id", typeof(int));
            this.dt.Columns["id"].AutoIncrement = true;
            this.dt.Columns["id"].AutoIncrementSeed = 1;
            this.dt.Columns["id"].AutoIncrementStep = 1;

            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.AllowUserToAddRows = false;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Cambiar por su apellido y nombre
        private void SegundoParcial_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Roberta Gabor");
            this.Text = "Roberta Gabor";
        }

        //Crear, en un class library, la siguiente jerarquía de clases:

        private void btnPunto1_Click(object sender, EventArgs e)
        {
            //Crear una instancia de cada clase e inicializar los atributos del form lapiz, goma y sacapunta. 
            this.lapiz = new Lapiz(ConsoleColor.Green, ETipoTrazo.Grueso, "Sylvapen", 25.50);
            this.goma = new Goma(true, "Pelican", 30);
            this.sacapunta = new Sacapunta(true, 55.90, "Afiladitos");

            MessageBox.Show(this.lapiz.ToString());
            MessageBox.Show(this.goma.ToString());
            MessageBox.Show(this.sacapunta.ToString());
        }

  
        private void btnPunto2_Click(object sender, EventArgs e)
        {
            this.c_lapices = new Cartuchera<Lapiz>(3);
            this.c_gomas = new Cartuchera<Goma>(3);
            this.c_utiles = new Cartuchera<Utiles>(2);

            this.c_lapices += new Lapiz(ConsoleColor.Red, ETipoTrazo.Medio, "Faber-Castell", 32.25);
            this.c_lapices += new Lapiz(ConsoleColor.Blue, ETipoTrazo.Fino, "Paper Mate", 30);
            this.c_lapices += this.lapiz;

            this.c_gomas += this.goma;
            this.c_gomas += new Goma(false, "Dos banderas", 25);

            this.c_utiles += this.lapiz;
            this.c_utiles += this.goma;

            MessageBox.Show(this.c_lapices.ToString());
            MessageBox.Show(this.c_gomas.ToString());
            MessageBox.Show(this.c_utiles.ToString());
        }

 
        private void btnPunto3_Click(object sender, EventArgs e)
        {
            try
            {
                this.c_utiles += this.lapiz;
            }
            catch (CartucheraLlenaException ex)
            {

                MessageBox.Show(ex.InformarNovedad());
            }
        }


        private void btnPunto4_Click(object sender, EventArgs e)
        {
            //Asociar manejador de eventos (c_gomas_EventoPrecio) aquí 
            this.c_gomas.precioSuperado += c_gomas_EventoPrecio;//asocio al evento de una cartuchera, el manejador
            this.c_gomas += new Goma(false, "Faber-Castell", 31);
        }

        private void c_gomas_EventoPrecio(object sender, EventArgs e)//manejador creado aca porque es el que recibe el evento
        {
            bool todoOK = Ticketeadora<Goma>.ImprimirTicket(c_gomas);//Reemplazar por la llamada al método de clase ImprimirTicket

            if (todoOK)
            {
                MessageBox.Show("Ticket impreso correctamente!!!");
            }
            else
            {
                MessageBox.Show("No se pudo imprimir el ticket!!!");
            }
        }

        //Configurar el OpenFileDialog, para poder seleccionar el log de tickets
        private void btnVerLog_Click(object sender, EventArgs e)
        {
            //titulo -> 'Abrir archivo de tickets'
            //directorio por defecto -> Mis documentos
            //tipo de archivo (filtro) -> .log
            //extensión por defecto -> .log
            //nombre de archivo (defecto) -> tickets

            openFileDialog1.Title = "Abrir archivo de tickets";
            openFileDialog1.InitialDirectory= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.DefaultExt = ".log";
            openFileDialog1.FileName = "tickets";

            DialogResult rta = openFileDialog1.ShowDialog();//Reemplazar por la llamada al método correspondiente del OpenFileDialog
            //showDialog te devuelve ok o cancel
            if (rta == DialogResult.OK)
            {
                //leer el archivo seleccionado por el cliente y mostrarlo en txtVisorTickets
                string path = openFileDialog1.FileName;//filename devuelve todo el path

                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        txtVisorTickets.Text = sr.ReadToEnd();
                    }

                }
                catch (Exception)
                {
                    txtVisorTickets.Text = "No se pudo abrir el archivo";
                }
            }
        }

        //Crear las interfaces (en class library): 
        //Implementar (implícitamente) ISerializa lápiz
        //Implementar (explícitamente) IDeserializa en lápiz
        private void btnPunto5_Click(object sender, EventArgs e)
        {
            Lapiz aux = null;

            if (this.lapiz.Xml())//tiene que estar en lapiz el xml
            {
                MessageBox.Show("Lápiz serializado OK");
            }
            else
            {
                MessageBox.Show("Lápiz NO serializado");
            }

            if (((IDeserializa)this.lapiz).Xml(out aux))
            {
                MessageBox.Show("Lápiz deserializado OK");
                MessageBox.Show(aux.ToString());
            }
            else
            {
                MessageBox.Show("Lápiz NO deserializado");
            }
        }
        /*private SqlConnection cn;
        private SqlDataAdapter da;
        private DataTable dt;*/

        //Obtener de la base de datos (sp_lab_II_utiles) el listado de útiles:
        //Tabla - utiles { id(autoincremental - numérico) - marca(cadena) - precio(numérico) - tipo(cadena) }.
        private void btnPunto6_Click(object sender, EventArgs e)
        {
            //Configurar el SqlConnection
            try
            {
                this.cn = new SqlConnection(Properties.Settings.Default.miConexion);
                //Configurar el SqlDataAdapter (y su selectCommand)                        
                this.da = new SqlDataAdapter();
                this.dt = new DataTable("Utiles");
                
                this.dt.Columns.Add("id", typeof(int));
                this.dt.Columns.Add("marca", typeof(string));
                this.dt.Columns.Add("precio", typeof(float));
                this.dt.Columns.Add("tipo", typeof(string));

                this.dt.PrimaryKey = new DataColumn[] { this.dt.Columns[0] };//id key

                this.dt.Columns["id"].AutoIncrement = true;
                this.dt.Columns["id"].AutoIncrementSeed = 1;//obtener el último id insertado en la tabla
                this.dt.Columns["id"].AutoIncrementStep = 1;

                this.da.SelectCommand = new SqlCommand("SELECT id, marca, precio, tipo FROM utiles", cn);

                this.da.Fill(this.dt);
                this.dataGridView1.DataSource = this.dt;
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        //Agregar en el dataTable los útiles del formulario (lapiz, goma y sacapunta).
        private void btnPunto7_Click(object sender, EventArgs e)
        {
            bool ok = false;
            //Configurar el insertCommand del SqlDataAdapter y sus parámetros
            try
            {
                this.da.InsertCommand = new SqlCommand("INSERT INTO utiles (marca, precio, tipo) VALUES (@marca, @precio, @tipo)", cn);
                this.da.InsertCommand.Parameters.Add("@marca", SqlDbType.VarChar,50 , "marca");
                this.da.InsertCommand.Parameters.Add("@precio", SqlDbType.Float,10 ,"precio");
                this.da.InsertCommand.Parameters.Add("@tipo", SqlDbType.VarChar, 50, "tipo");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Agregar los utiles del formulario al dataTable (crear filas)

            this.añado += this.RecorridoInsertarUtiles;
            this.añado += this.RecorridoInsertarGomas;
            this.añado += this.RecorridoInsertarLapices;
            this.añado(c_gomas, EventArgs.Empty);
            this.añado(c_lapices, EventArgs.Empty);
            this.añado(c_utiles, EventArgs.Empty);
        }
        
        public void RecorridoInsertarUtiles(object catu,EventArgs e)
        {
            
            try
            {Cartuchera<Utiles> auxiliar = (Cartuchera < Utiles >)catu;
                foreach (Utiles item in auxiliar.Elementos)
                {
                    DataRow fila = this.dt.NewRow();
                    fila["marca"] = item.marca;
                    fila["precio"] = item.precio;
                    fila["tipo"] = item.GetType().Name;
                    this.dt.Rows.Add(fila);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RecorridoInsertarGomas(object catu, EventArgs e)
        {
            
            try
            {Cartuchera<Goma> auxiliar = (Cartuchera<Goma>)catu;
                foreach (Goma item in auxiliar.Elementos)
                {
                    DataRow fila = this.dt.NewRow();
                    fila["marca"] = item.marca;
                    fila["precio"] = item.precio;
                    fila["tipo"] = item.GetType().Name;
                    this.dt.Rows.Add(fila);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RecorridoInsertarLapices(object catu, EventArgs e)
        {
            
            try
            {Cartuchera<Lapiz> auxiliar = (Cartuchera<Lapiz>)catu;
                foreach (Lapiz item in auxiliar.Elementos)
                {
                    DataRow fila = this.dt.NewRow();
                    fila["marca"] = item.marca;
                    fila["precio"] = item.precio;
                    fila["tipo"] = item.GetType().Name;
                    this.dt.Rows.Add(fila);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Eliminar del dataTable el primer registro
        private void btnPunto8_Click(object sender, EventArgs e)
        {
            //Configurar el deleteCommand del SqlDataAdapter y sus parámetros

            //Borrar el primer registro del dataTable (borrado físico NO)
        }

        //Modificar del dataTable el último registro, cambiarlo por: marca:barrilito; precio:72
        private void btnPunto9_Click(object sender, EventArgs e)
        {
            //Configurar el updateCommand del SqlDataAdapter y sus parámetros

            //Modificar el último registro del dataTable
        }

        //Sincronizar los cambios (sufridos en el dataTable) con la base de datos
        private void btnPunto10_Click(object sender, EventArgs e)
        {
            try
            {
                //Sincronizar el SqlDataAdapter con la BD

                MessageBox.Show("Datos sincronizados!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha sincronizado!!!\n" + ex.Message);
            }
        }
    }
}
