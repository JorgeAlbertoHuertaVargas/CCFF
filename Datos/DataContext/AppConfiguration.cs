using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCFF.Datos.DataContext
{
    public class AppConfiguration
    {
        //Sinlgeton Pattern
        public static AppConfiguration singletonInstance;
        private AppConfiguration()
        {
            var configuracion = new ConfigurationBuilder();// para construir 
            configuracion.AddJsonFile("appsettings.json", true, true);//agragamos un archivo json para leerlo
            var root = configuracion.Build();// agregamos todo lo construido en una variable de tipo root
            var appsetting = root.GetSection("ConnectionStrings:cadenaconexion");//obtenermos la cadena de conexion
            sqlConnectionString = appsetting.Value;//todo el valor optenido lo guardamos en un atributo.
        }


        public static AppConfiguration GetInstance()
        {
            if(singletonInstance == null)
                singletonInstance= new AppConfiguration();
            return singletonInstance;
        }
        public string sqlConnectionString { get; set; }
    }
}
