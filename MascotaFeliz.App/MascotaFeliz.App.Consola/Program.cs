using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello!")
;            //DeleteDueno();
            //DeleteVeterinario();
            //AddDueno();
            //AddVeterinario();
        }
        /*private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Juan",
                Apellidos = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                Correo = "juansinmiedo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                //Cedula = "1212",
                Nombres = "Juan",
                Apellidos = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                TarjetaProfesional = "25660"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }*/
        /*public static void DeleteDueno(){
            _repoDueno.DeleteDueno(1);
            _repoDueno.DeleteDueno(2);

        }
        public static void DeleteVeterinario(){
            _repoVeterinario.DeleteVeterinario(3);
        }
        */


    }
}
