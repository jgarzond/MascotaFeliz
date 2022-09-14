using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        /// <summary>
        /// Referencia al contexto de Historia
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        
        public RepositorioHistoria(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Historia AddHistoria(Historia historia)
        {
            var historiaAdicionado = _appContext.Historias.Add(historia);
            _appContext.SaveChanges();
            return historiaAdicionado.Entity;
        }

        public void DeleteHistoria(int idHistoria)
        {
            var historiaEncontrada = _appContext.Historias.FirstOrDefault(v => v.Id == idHistoria);
            if (historiaEncontrada == null)
                return;
            _appContext.Historias.Remove(historiaEncontrada);
            _appContext.SaveChanges();
        }

       
       /* public IEnumerable<Historia> GetHistoriasPorFiltro(int filtro)
        {
            var historias = GetAllHistorias(); // Obtiene todos los saludos
            if (historias != null)  //Si se tienen saludos
            {
                if (!int.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    historias = historias.Where(s => s.IdVeterinario.Contains(filtro));
                }
            }
            return historias;
        }*/

        public IEnumerable<Historia> GetAllHistorias()
        {
            return _appContext.Historias;
        }

        public Historia GetHistoria(int idHistoria)
        {
            return _appContext.Historias.FirstOrDefault(v => v.Id == idHistoria);
        }

        public Historia UpdateHistoria(Historia historia)
        {
            var historiaEncontrada = _appContext.Historias.FirstOrDefault(h => h.Id == historia.Id);
            if (historiaEncontrada != null)
            {
                historiaEncontrada.FechaInicial = historia.FechaInicial;
                _appContext.SaveChanges();
            }
            return historiaEncontrada;
        }     
    }
}