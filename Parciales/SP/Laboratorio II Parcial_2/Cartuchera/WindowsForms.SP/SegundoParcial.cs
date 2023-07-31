using Entidades;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

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
            MessageBox.Show("SegundoParcial");
            this.Text = "SegundoParcial 2020";
        }

        //Crear, en un class library, la siguiente jerarquía de clases:
        //Utiles-> marca:string y precio:double (públicos); PreciosCuidados:bool (prop. s/l, abstracta);
        //constructor con 2 parametros y UtilesToString():string (protegido y virtual, retorna los valores del útil)
        //ToString():string (polimorfismo; reutilizar código)
        //Lapiz-> color:ConsoleColor(público); trazo:ETipoTrazo(enum {Fino, Grueso, Medio}; público); PreciosCuidados->true; 
        //Reutilizar UtilesToString en ToString() (mostrar TODOS los valores).
        //Goma-> soloLapiz:bool(público); PreciosCuidados->true; 
        //Reutilizar UtilesToString en ToString() (mostrar TODOS los valores).
        //Sacapunta-> deMetal:bool(público); 
        //Reutilizar UtilesToString en ToString() (mostrar TODOS los valores).
        private void btnPunto1_Click(object sender, EventArgs e)
        {
            //Crear una instancia de cada clase e inicializar los atributos del form lapiz, goma y sacapunta. 
            this.lapiz = new Lapiz(ConsoleColor.Green, Lapiz.ETipoTrazo.Grueso, "Sylvapen", 25.50);
            this.goma = new Goma(true, "Pelican", 30);
            this.sacapunta = new Sacapunta(true, 55.90, "Afiladitos");

            MessageBox.Show(this.lapiz.ToString());
            MessageBox.Show(this.goma.ToString());
            MessageBox.Show(this.sacapunta.ToString());
        }

        //Crear, en class library, la clase Cartuchera<T> -> restringir para que sólo lo pueda usar Utiles 
        //o clases que deriven de Utiles.
        //atributos: capacidad:int y elementos:List<T> (TODOS protegidos)        
        //Propiedades:
        //Elementos:(sólo lectura) expone al atributo de tipo List<T>.
        //PrecioTotal:(sólo lectura) retorna el precio total de la cartuchera (la suma de los precios de sus elementos).
        //Constructor
        //Cartuchera(), Cartuchera(int); 
        //El constructor por default es el único que se encargará de inicializar la lista.
        //Métodos:
        //ToString: Mostrará en formato de tipo string: 
        //el tipo de cartuchera, la capacidad, la cantidad actual de elementos, el precio total y el listado completo 
        //de todos los elementos contenidos en la misma. Reutilizar código.
        //Sobrecarga de operadores:
        //(+) Será el encargado de agregar elementos a la cartuchera, 
        //siempre y cuando no supere la capacidad máxima de la misma.
        private void btnPunto2_Click(object sender, EventArgs e)
        {
            this.c_lapices = new Cartuchera<Lapiz>(3);
            this.c_gomas = new Cartuchera<Goma>(3);
            this.c_utiles = new Cartuchera<Utiles>(2);

            this.c_lapices += new Lapiz(ConsoleColor.Red, Lapiz.ETipoTrazo.Medio, "Faber-Castell", 32.25);
            this.c_lapices += new Lapiz(ConsoleColor.Blue, Lapiz.ETipoTrazo.Fino, "Paper Mate", 30);
            this.c_lapices += this.lapiz;

            this.c_gomas += this.goma;
            this.c_gomas += new Goma(false, "Dos banderas", 25);

            this.c_utiles += this.lapiz;
            this.c_utiles += this.goma;

            MessageBox.Show(this.c_lapices.ToString());
            MessageBox.Show(this.c_gomas.ToString());
            MessageBox.Show(this.c_utiles.ToString());
        }

        //Agregar un elemento a la cartuchera de útiles, al superar la cantidad máxima, 
        //lanzará un CartucheraLlenaException (diseñarla), cuyo mensaje explicará lo sucedido.
        private void btnPunto3_Click(object sender, EventArgs e)
        {
            try
            {
                this.c_utiles += this.lapiz;
            }
            catch (CartucheraLlenaException ex)
            {
                //Agregar, para la clase CartucheraLlenaException, un método de extensión (InformarNovedad():string)
                //que retorne el mensaje de error
                MessageBox.Show(ex.InformarNovedad());
            }
        }

        //Si el precio total de la cartuchera supera los 85 pesos, se disparará el evento EventoPrecio. 
        //Diseñarlo (de acuerdo a las convenciones vistas) en la clase cartuchera. 
        //Adaptar la sobrecarga del operador +, para que lance el evento, según lo solicitado.
        //Crear el manejador necesario para que, una vez capturado el evento, se imprima en un archivo de texto: 
        //la fecha (con hora, minutos y segundos) y el total de la cartuchera (en un nuevo renglón). 
        //Se deben acumular los mensajes. 
        //El archivo se guardará con el nombre 'tickets.log' en la carpeta 'Mis documentos' del cliente.
        //El manejador de eventos (c_gomas_EventoPrecio) invocará al método (de clase) 
        //ImprimirTicket (se alojará en la clase Ticketeadora), que retorna un booleano 
        //indicando si se pudo escribir o no.
        private void btnPunto4_Click(object sender, EventArgs e)
        {
            //Asociar manejador de eventos (c_gomas_EventoPrecio) aquí 
            try
            {
                this.c_gomas.EventoPrecio -= new Cartuchera<Goma>.DelegadoEventoPrecio(c_gomas_EventoPrecio);
                this.c_gomas.EventoPrecio += new Cartuchera<Goma>.DelegadoEventoPrecio(this.c_gomas_EventoPrecio);
                this.c_gomas += new Goma(true, "Faber-Castell", 31);
            }
            catch (CartucheraLlenaException ex)
            {
                MessageBox.Show(ex.InformarNovedad());
            }
        }

        private void c_gomas_EventoPrecio(object sender, EventArgs e)
        {

            bool todoOK = Ticketeadora.ImprimirTicket(this.c_gomas); //

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
            this.openFileDialog1.Title = "Abrir archivo de tickets";
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            this.openFileDialog1.Filter = "Archivos.log | *.log";
            this.openFileDialog1.DefaultExt = "log";
            this.openFileDialog1.FileName = "tickets";


            DialogResult rta = this.openFileDialog1.ShowDialog(); ;//Reemplazar por la llamada al método correspondiente del OpenFileDialog

            if (rta == DialogResult.OK)
            {
                try
                {
                    using (StreamReader lector = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\tickets.log"))
                    {
                        this.txtVisorTickets.Text = lector.ReadToEnd();

                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error al intentar leer el ticket", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Crear las interfaces (en class library): 
        //#.-ISerializa -> Xml() : bool
        //              -> Path{ get; } : string
        //#.-IDeserializa -> Xml(out Lapiz) : bool
        //Implementar (implícitamente) ISerializa lápiz
        //Implementar (explícitamente) IDeserializa en lápiz
        //El archivo .xml guardarlo en el escritorio del cliente, con el nombre formado con su apellido.nombre.lapiz.xml
        //Ejemplo: Alumno Juan Pérez -> perez.juan.lapiz.xml
        private void btnPunto5_Click(object sender, EventArgs e)
        {
            Lapiz aux = null;

            if (this.lapiz.Xml())
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

        //Obtener de la base de datos (sp_lab_II_utiles) el listado de útiles:
        //Tabla - utiles { id(autoincremental - numérico) - marca(cadena) - precio(numérico) - tipo(cadena) }.
        private void btnPunto6_Click(object sender, EventArgs e)
        {
            //Configurar el SqlConnection
            this.cn = new SqlConnection(Properties.Settings.Default.Conexion);

            //Configurar el SqlDataAdapter (y su selectCommand)     
            string comando = "SELECT * FROM [sp_lab_II_utiles].[dbo].[utiles]";
            this.da = new SqlDataAdapter(comando, this.cn);

            this.da.Fill(this.dt);
            this.dataGridView1.DataSource = this.dt;

        }

        //Agregar en el dataTable los útiles del formulario (lapiz, goma y sacapunta).
        private void btnPunto7_Click(object sender, EventArgs e)
        {
            //Configurar el insertCommand del SqlDataAdapter y sus parametros
            string comando = "INSERT INTO [sp_lab_II_utiles].[dbo].[utiles] VALUES(@p1, @p2, @p3)";
            this.da.InsertCommand = new SqlCommand(comando, this.cn);

            this.da.InsertCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50, "marca");
            this.da.InsertCommand.Parameters.Add("@p2", SqlDbType.Float, 10, "precio");
            this.da.InsertCommand.Parameters.Add("@p3", SqlDbType.VarChar, 50, "tipo");

            //Agregar los utiles del formulario al dataTable
            DataRow fila = this.dt.NewRow();

            //Lapices
            fila[1] = this.lapiz.marca;
            fila[2] = this.lapiz.precio;
            fila[3] = "lapiz";
            this.dt.Rows.Add(fila);

            //Gomas
            fila = this.dt.NewRow();
            fila[1] = this.goma.marca;
            fila[2] = this.goma.precio;
            fila[3] = "goma";
            this.dt.Rows.Add(fila);

            //Sacapuntas
            fila = this.dt.NewRow();
            fila[1] = this.sacapunta.marca;
            fila[2] = this.sacapunta.precio;
            fila[3] = "sacapunta";
            this.dt.Rows.Add(fila);
        }
        //Eliminar del dataTable el primer registro
        private void btnPunto8_Click(object sender, EventArgs e)
        {
            //Configurar el deleteCommand del SqlDataAdapter y sus parámetros
            //Borrar el primer registro del dataTable (borrado físico NO)
            this.da.DeleteCommand = new SqlCommand("delete from utiles where id=@id", cn);
            this.da.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 2, "id");
            this.dt.Rows[0].Delete();
        }

        //Modificar del dataTable el último registro, cambiarlo por: marca:barrilito; precio:72
        private void btnPunto9_Click(object sender, EventArgs e)
        {
            //Configurar el updateCommand del SqlDataAdapter y sus parámetros
            da.UpdateCommand = new SqlCommand("update utiles set marca=@marca,precio=@precio,tipo=@tipo where id=@id", cn);
            da.UpdateCommand.Parameters.Add("@marca", SqlDbType.VarChar, 50, "marca");
            da.UpdateCommand.Parameters.Add("@precio", SqlDbType.VarChar, 50, "precio");
            da.UpdateCommand.Parameters.Add("@tipo", SqlDbType.Int, 2, "tipo");
            da.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 2, "id");

            //Modificar el ultimo registro del dataTable
            DataColumnCollection columna = dt.Columns;
            DataRow fila = dt.Rows[dt.Rows.Count - 1];
            fila[columna[1]] = "utileria";
            fila[columna[2]] = 50;

        }

        //Sincronizar los cambios (sufridos en el dataTable) con la base de datos
        private void btnPunto10_Click(object sender, EventArgs e)
        {
            try
            {
                //Sincronizar el SqlDataAdapter con la BD
                this.da.Update(this.dt);
                MessageBox.Show("Datos sincronizados!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha sincronizado!!!\n" + ex.Message);
            }
        }
    }
}


