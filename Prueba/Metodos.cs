using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Metodos
    {
        public static ListaSimpleEnlazada<Persona> listaVersiones = new ListaSimpleEnlazada<Persona>();
        public static string[] ListaArray = new string[4];
        

        public static List<Persona> LisVer = new List<Persona>();
        private static string _path = @"C:\Users\wilso\source\repos\Pruebas\ListaJson.json";

        /*Serializa una Lista<Persona> a Json*/
        /*public static void SerializarJson(ListaSimpleEnlazada<Persona> versiones)
        {
            string versionesJson = JsonConvert.SerializeObject(LisVer.ToArray(), Formatting.Indented); ;
            File.WriteAllText(_path, versionesJson);


        }*/

        /*Lee un Json de una archivo.Json
        public static string LeerJson()
        {
            string versionesJson;
            using (var reader = new StreamReader(_path))
            {
                versionesJson = reader.ReadToEnd();
            }
            return versionesJson;
        }

        /*Deseariliza el Json leido en el meotodo LeerJson
        public static string DeserealizarJson(string versionExtraer)
        {
            Console.WriteLine("se han extraido los siguientes datos: " + versionExtraer);

            return versionExtraer;


        }*/

        /*Extrae el Json y los pasa a una List<Persona> con esto podemos acceder a los atributos por separado y a la posición especificada
        */
        /*public static void ExtraePosicion(string JsonVersion, string posicion)
        {

            var versiones = JsonConvert.DeserializeObject<ListaSimpleEnlazada<Persona>>(JsonVersion);
            Console.WriteLine(string.Format("Los datos de la última versión buscada son: " + 1 ));

        }*/

        /*Busca la última posición de la List<>*/

        /*public static string ultimaPosicion(ListaSimpleEnlazada<Persona> ultimaPosicion)
        {
            return ultimaPosicion.DevuelveUltimoDato();
        }





        /*Crea objetos Persona en una Lista y retorna la Lista*/
        /*public static List<Persona> getPersonas()
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona
                {
                    nombre = "Wilson",
                    edad = "28"

                },
                new Persona
                {
                    nombre = "Alex",
                    edad = "20"
                },
                new Persona
                {
                    nombre = "Walter",
                    edad = "32"
                }
            };
            return personas;
        }*/

    }
}
