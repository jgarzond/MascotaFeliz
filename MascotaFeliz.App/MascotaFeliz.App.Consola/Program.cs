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
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("SUCCESS");
            //DeleteDueno();
            //DeleteVeterinario();
            //AddDueno();
            //AddVeterinario();
            //BuscarDueno(4);
            //BuscarDueno(6);
            //BuscarVeterinario(5);
            //BuscarVeterinario(7);
            //ListarDuenos();
            //ListarVeterinarios();
            //AddMascota();
            //ListarMascotas();
            //AddVisitaPyP();
            //BuscarVisitaPyP(1);
            //ListarVisitasPyP();
            //AddHistoria();
            //BuscarHistoria(1);
            //ListarHistorias();
        }
        //Métodos Dueño
        private static void AddDueno(){
            var dueno = new Dueno{
                Nombres = "Alejandra",
                Apellidos = "Echeverria",
                Direccion = "Calle 6",
                Telefono = "3134",
                Correo = "alejandra@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        public static void DeleteDueno(){
            _repoDueno.DeleteDueno(8);    //Ingresar ID de la BD
           // _repoDueno.DeleteDueno(2);
        }
        private static void BuscarDueno(int idDueno){
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
        }

        private static void ListarDuenos(){
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos){
                Console.WriteLine(d.Nombres + " " + d.Apellidos + " " + d.Correo);
            }
        }
    //Métodos Veterinario
        private static void AddVeterinario(){
            var veterinario = new Veterinario{
                Nombres = "Alan",
                Apellidos = "Cadena",
                Direccion = "Calle 100",
                Telefono = "3332225",
                TarjetaProfesional = "10256"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
        
        public static void DeleteVeterinario(){
            _repoVeterinario.DeleteVeterinario(9);// Ingresar ID de la BD
        }

        private static void BuscarVeterinario(int idVeterinario){
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos + " " + veterinario.Direccion + " " + veterinario.Telefono + " " + veterinario.TarjetaProfesional);
        }

        private static void ListarVeterinarios(){
            var veterinarios = _repoVeterinario.GetAllVeterinarios();
            foreach (Veterinario v in veterinarios){
                Console.WriteLine(v.Nombres + " " + v.Apellidos + " " + v.TarjetaProfesional);
            }
        }

        //Métodos Mascotas
        private static void AddMascota(){
            var mascota = new Mascota{
                Nombre = "Pinina",
                Color = "Blanco",
                Especie = "Felino",
                Raza = "Siames",
            };
            _repoMascota.AddMascota(mascota);
        }

        public static void DeleteMascota(){
            //_repoMascota.DeleteMascota(1);    //Ingresar ID de la BD
           
        }

        private static void BuscarMascota(int idMascota){
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre + " " + mascota.Especie + " " + mascota.Raza);
        }

        private static void ListarMascotas(){
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota m in mascotas){
                Console.WriteLine(m.Nombre + " " + m.Especie + " " + m.Raza);
            }
        }

        // Métodos VisitaPyP

        private static void AddVisitaPyP(){
            var visitaPyP = new VisitaPyP{
                FechaVisita = new DateTime(2022,09,15,8,30,0),
                Temperatura = 36f,
                Peso = 7f,
                FrecuenciaRespiratoria = 55f,
                FrecuenciaCardiaca = 89f,
                EstadoAnimo = "Normal",
                IdVeterinario = 7,
                Recomendaciones = "Dar mas whiskas"
            };
            _repoVisitaPyP.AddVisitaPyP(visitaPyP);
        }

        public static void DeleteVisitaPyP(){
            //_repoMascota.DeleteVisitaPyP(1);    //Ingresar ID de la BD
           
        }

        private static void BuscarVisitaPyP(int idVisitaPyP){
            var visitaPyP = _repoVisitaPyP.GetVisitaPyP(idVisitaPyP);
            Console.WriteLine(visitaPyP.FechaVisita + " " + visitaPyP.IdVeterinario + " " + visitaPyP.Recomendaciones);
        }

        private static void ListarVisitasPyP(){
            var visitasPyP = _repoVisitaPyP.GetAllVisitasPyP();
            foreach (VisitaPyP v in visitasPyP){
                Console.WriteLine(v.FechaVisita + " " + v.IdVeterinario + " " + v.Recomendaciones);
            }
        }

        //Metodos Historia
        
        private static void AddHistoria(){
            var historia = new Historia{
                FechaInicial = new DateTime(2022,09,10,8,0,0),
                
            };
            _repoHistoria.AddHistoria(historia);
        }

        public static void DeleteHistoria(){
            //_repoMascota.DeleteHistoria(1);    //Ingresar ID de la BD
           
        }

        private static void BuscarHistoria(int idHistoria){
            var historia = _repoHistoria.GetHistoria(idHistoria);
            Console.WriteLine(historia.FechaInicial);
        }

        private static void ListarHistorias(){
            var historias = _repoHistoria.GetAllHistorias();
            foreach (Historia h in historias){
                Console.WriteLine(h.Id + " "+ h.FechaInicial);
            }
        }

        


    }
}
