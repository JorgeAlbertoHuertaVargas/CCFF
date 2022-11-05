using CCFF.Modelo;
using System.Data;
using System.Net;
using WindosaForms.API;

namespace WindosaForms
{
    public partial class Form1 : Form
    {

         DBApi api = new DBApi();
        public DataTable tabla;

        public void Inicializar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Codigo");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            tabla.Columns.Add("Dni");
            tabla.Columns.Add("Correo");
            tabla.Columns.Add("Celular");
            ListaAlumnos.DataSource = tabla;

        }

        public Form1()
        {
            InitializeComponent();
            Inicializar();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

      




        private void  button1_Click(object sender, EventArgs e)
        {

            // dynamic respuesta = api.Get("https://joeapiccff.azurewebsites.net/api/Alumno/Listar");
           

            // dynamic respuesta = api.Get("https://joeapiccff.azurewebsites.net/api/Alumno/ListarAlumnoByID?id=1");
            //List<AlumnoDESK> lista = new List<AlumnoDESK>();
            //lista.Add(respuesta);


            //Enumerable<Alumno> alumnos = await _alumnoLogica.GetAllAlumnos();
            //List<AlumnoDESK> lista = AlumnoDESK
            //   .Select(x => new AlumnoDESK()
            //   {
            //       Id = x.Id,
            //       Nombre = x.Nombre,
            //       Apellido = x.Apellido,
            //       Codigo = x.Codigo,
            //       Dni = x.Dni,
            //       correo = x.correo,
            //       celular = x.celular,


            //   }).ToList();

            // textBox1.Text = respuesta.ToString();
            //textBox2.Text = respuesta.Nombre.ToString();
            //textBox2.Text = respuesta.data[1].nombre.ToString();
            //// textBox4.Text = await respuesta.data[1].nombre.ToString();
            ///





            //// var url = $"https://joeapiccff.azurewebsites.net/api/Alumno/ListarAlumnoByID?id=1";
            // var url = $"https://joeapiccff.azurewebsites.net/api/Alumno/Listar";
            //var request = (HttpWebRequest)WebRequest.Create(url);
            //request.Method = "GET";
            //request.ContentType = "application/json";
            //request.Accept = "application/json";
            //try
            //{
            //    using (WebResponse response = request.GetResponse())
            //    {
            //        using (Stream strReader = response.GetResponseStream())
            //        {
            //            if (strReader == null) return;
            //            using (StreamReader objReader = new StreamReader(strReader))
            //            {
            //                string responseBody = objReader.ReadToEnd();
            //                // Do something with responseBody
            //                // Console.WriteLine(responseBody);
            //                textBox1.Text = responseBody;



            //            }
            //        }
            //    }
            //}
            //catch (WebException ex)
            //{
            //    // Handle error
            //}
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListaAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

 }
