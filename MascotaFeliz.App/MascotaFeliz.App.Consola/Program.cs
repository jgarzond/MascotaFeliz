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
        //Métodos Dueño
        private static void AddDueno(){
            var dueno = new Dueno{
                Nombres = "Juan",
                Apellidos = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                Correo = "juansinmiedo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        public static void DeleteDueno(){
           // _repoDueno.DeleteDueno(1);    Ingresar ID de la BD
           // _repoDueno.DeleteDueno(2);
        }
        private static void BuscarDueno(int idDueno){
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
        }

        private static void ListarDuenos(){
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos){
                Console.WriteLine(d.Nombres + " " + d.Apellidos + " " + d.Corr});
            }
        }
    //Métodos Veterinario
        private static void AddVeterinario(){
            var veterinario = new Veterinario{
                Nombres = "Juan",
                Apellidos = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                TarjetaProfesional = "25660"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
        
        public static void DeleteVeterinario(){
            //_repoVeterinario.DeleteVeterinario(3); Ingresar ID de la BD
        }

        private static void BuscarVeterinario(int idVeterianrio){
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos + " " + veterinario.Direccion + " " + veterinario.Telefono + " " + veterinario.TarjetaProfesional);
        }

        private static void ListarVeterinarios(){
            var veterinarios = _repoVeterinario.GetAllVeterinarios();
            foreach (Veterinario v in veterinarios){
                Console.WriteLine(v.Nombres + " " + v.Apellidos + " " + v.TarjetaProfesional);
            }
        }
        


    }
}
