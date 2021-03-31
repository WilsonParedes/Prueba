using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class ListaSimpleEnlazada<T>

    {
        

        private static string _path = @"C:\Users\wilso\source\repos\Pruebas\ListaJson.json";
        NodoVersiones<T> primero { get; set; }

        NodoVersiones<T> ultimo { get; set; }

        NodoVersiones<T> actual { get; set; }

        public ListaSimpleEnlazada()
        {
            primero = null;
            ultimo = null;
            actual = null;
        }

        public void agregarVersion(T version)
        {
            NodoVersiones<T> nuevaVersion = new NodoVersiones<T>(version);
       
            if (primero == null)
            {
                primero = nuevaVersion;
                ultimo = nuevaVersion;
                
            }
            else
            {
                ultimo.siguiente = nuevaVersion;
                ultimo = nuevaVersion;
                
            }
        }




        public Array recorre()
        {            
            actual = primero;
            int contador = 0;
            while (actual != null)
            {
                contador++;
                actual = actual.siguiente;
            }

            actual = primero;
            string[] nuevaLista = new string[contador];
            
            int i = 0;
            while (actual != null)
            {
                Console.WriteLine(actual.dato);
                nuevaLista[i] = actual.dato.ToString();                
                actual = actual.siguiente;
                i++;
            }
            return nuevaLista;
        }


        /*public string LeerJson()
        {
            string versionesJson;
            using (var reader = new StreamReader(_path))
            {
                versionesJson = reader.ReadToEnd();
                
            }
            return versionesJson;
        }*/

        


        public string versionBuscar(string posicion)
        {

            actual = primero;
            int contador = 1;
            var dato = "";
            int pos = Int32.Parse(posicion);
            while (actual != null)
            {
                if (contador != pos)
                {
                    actual = actual.siguiente;
                }
                else
                {
                    dato=  actual.dato.ToString();
                }
                contador++;    
            }
            return dato;

        }

        public string DevuelveUltimoDato()
        {

            return ultimo.dato.ToString();


        }

        /*public void serializar(ListaSimpleEnlazada<T> VersionJson)
        {
            string versionesJson = JsonConvert.SerializeObject(VersionJson.recorre(), Formatting.Indented);
            File.WriteAllText(_path, versionesJson);
            
        }*/
        


        public bool CompararContenido(string contenidonuevo, string contenido_anterior)
        {

            var comparar = false;
            
            if (contenidonuevo.Equals(contenido_anterior))
            {
                comparar = true;
            }

            return comparar;

        }



        public string recorredeapoyo()
        {

            actual = primero;
            string nuevaLista = "";

      
            while (actual != null)
            {
                nuevaLista = actual.dato.ToString();
                actual = actual.siguiente;
              
            }

            return nuevaLista;

        }
    }
}
