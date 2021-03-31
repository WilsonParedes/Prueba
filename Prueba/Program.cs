using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Metodos.listaVersiones.agregarVersion(new Persona { VersiónNo = "1", Fecha = "20/03/2021", Usuario_Creador = "wparedes", Contenido = "Hola" });
            Metodos.listaVersiones.agregarVersion(new Persona { VersiónNo = "2", Fecha = "21/03/2021", Usuario_Creador = "wjuarez", Contenido = "Hola " });
            Metodos.listaVersiones.agregarVersion(new Persona { VersiónNo = "3", Fecha = "22/03/2021", Usuario_Creador = "azacarias", Contenido = "Hola a todos" });
            Metodos.listaVersiones.agregarVersion(new Persona { VersiónNo = "4", Fecha = "24/03/2021", Usuario_Creador = "wparedes", Contenido = "Hola a todos que tal" });
         
           /*prueba*/
            /*Almacena la List<Persona>*/
            var ListaVersiones = Metodos.listaVersiones;
            Metodos.listaVersiones.recorre();

            /*Metodos.listaVersiones.serializar(ListaVersiones);*/

            /*Metodos.SerializarJson(ListaVersiones);
            Console.WriteLine("Se ha Creado la Lista Json exitosamente");*/
            

            /*Dessearlizar*/
            /*var personasextraer = Metodos.LeerJson();*/
           
            
            Console.WriteLine("Indique el número de la versión que desea buscar");
            string posicion = Console.ReadLine();
            Console.WriteLine(Metodos.listaVersiones.versionBuscar(posicion));

            /*Imprime última posición*/
            var ultimaversion = Metodos.listaVersiones.DevuelveUltimoDato();
            Console.WriteLine("\nLA ÚLTIMA VERSIÓN REGISTRADA ES : " + ultimaversion );

            /*string json = Metodos.listaVersiones.LeerJson();
            Console.WriteLine(json);*/


            /*var versiones = JsonConvert.DeserializeObject<List<Persona>>(json);
            Console.WriteLine(string.Format("Los datos de la última versión buscada son: " + versiones[2].Contenido));*/



            string lista = ListaVersiones.recorredeapoyo();
            string contenidoanterior = "";
            int i = 0;
            for (i = 0; i < 1; i++)
            {
                string[] persona = lista.Split("%");
                Persona hola = new Persona { VersiónNo = persona[0], Fecha = persona[1], Usuario_Creador = persona[2], Contenido = persona[3] };
                contenidoanterior = hola.Contenido.ToString();
            }
            Console.WriteLine(contenidoanterior.Substring(11));



            /*COMPARA UN STRING*/
            Console.WriteLine("\n\n Ingrese el Contenido para una Nueva Versión");
            string contenidoNuevo = Console.ReadLine();

            if (!Metodos.listaVersiones.CompararContenido(contenidoNuevo, contenidoanterior.Substring(11)))
            {
                Console.WriteLine("Se crea una nueva versión");
                Metodos.listaVersiones.agregarVersion(new Persona { VersiónNo = "5", Fecha = "24/03/2021", Usuario_Creador = "wparedes", Contenido = contenidoNuevo });
                /*Metodos.SerializarJson(ListaVersiones);*/
                /*Console.WriteLine("\n\n\nDATOS QUE SE ENCUENTRAN EN EL JSON\n");*/
                /*Metodos.DeserealizarJson(Metodos.LeerJson());*/
                Console.WriteLine("\n SE ACTUALIZA EL NODO\n");
                Metodos.listaVersiones.recorre();

            }
            else
            {
                Console.WriteLine("La última versión no ha sufrido ningun cambio");
            }


        }

       
          

      


    }
}
