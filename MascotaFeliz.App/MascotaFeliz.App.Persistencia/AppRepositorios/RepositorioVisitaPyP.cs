using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVisitaPyP : IRepositorioVisitaPyP
    {
        /// <summary>
        /// Referencia al contexto de VisitaPyP
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        
        public RepositorioVisitaPyP(AppContext appContext)
        {
            _appContext = appContext;
        }

        public VisitaPyP AddVisitaPyP(VisitaPyP visitaPyP)
        {
            var visitaPyPAdicionado = _appContext.VisitasPyP.Add(visitaPyP);
            _appContext.SaveChanges();
            return visitaPyPAdicionado.Entity;
        }

        public void DeleteVisitaPyP(int idVisitaPyP)
        {
            var visitaPyPEncontrada = _appContext.VisitasPyP.FirstOrDefault(v => v.Id == idVisitaPyP);
            if (visitaPyPEncontrada == null)
                return;
            _appContext.VisitasPyP.Remove(visitaPyPEncontrada);
            _appContext.SaveChanges();
        }

       
       /* public IEnumerable<VisitaPyP> GetVisitasPyPPorFiltro(int filtro)
        {
            var visitasPyP = GetAllVisitasPyP(); // Obtiene todos los saludos
            if (visitasPyP != null)  //Si se tienen saludos
            {
                if (!int.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    visitasPyP = visitasPyP.Where(s => s.IdVeterinario.Contains(filtro));
                }
            }
            return visitasPyP;
        }*/

        public IEnumerable<VisitaPyP> GetAllVisitasPyP()
        {
            return _appContext.VisitasPyP;
        }

        public VisitaPyP GetVisitaPyP(int idVisitaPyP)
        {
            return _appContext.VisitasPyP.FirstOrDefault(v => v.Id == idVisitaPyP);
        }

        public VisitaPyP UpdateVisitaPyP(VisitaPyP visitaPyP)
        {
            var visitaPyPEncontrada = _appContext.VisitasPyP.FirstOrDefault(d => d.Id == visitaPyP.Id);
            if (visitaPyPEncontrada != null)
            {
                visitaPyPEncontrada.FechaVisita = visitaPyP.FechaVisita;
                visitaPyPEncontrada.Temperatura = visitaPyP.Temperatura;
                visitaPyPEncontrada.Peso = visitaPyP.Peso;
                visitaPyPEncontrada.FrecuenciaRespiratoria = visitaPyP.FrecuenciaRespiratoria;
                visitaPyPEncontrada.FrecuenciaCardiaca = visitaPyP.FrecuenciaCardiaca;
                visitaPyPEncontrada.EstadoAnimo = visitaPyP.EstadoAnimo;
                visitaPyPEncontrada.IdVeterinario = visitaPyP.IdVeterinario;
                visitaPyPEncontrada.Recomendaciones = visitaPyP.Recomendaciones;
                _appContext.SaveChanges();
            }
            return visitaPyPEncontrada;
        }     
    }
}