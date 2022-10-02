using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class EditarMascotasModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
        private readonly IRepositorioDueno _repoDueno;
        private readonly IRepositorioVeterinario _repoVeterinario;
        private readonly IRepositorioHistoria _repoHistoria;

        DateTime FechaInicial;
        [BindProperty]
        public Mascota mascota { get; set; }
        public Veterinario veterinario { get; set; }
        public Dueno dueno { get; set; }
        public Historia historia { get; set; }
        public IEnumerable<Dueno> listaDuenos { get; set; }
        public IEnumerable<Veterinario> listaVeterinarios { get; set; }
        public IEnumerable<Historia> listaHistorias { get; set; }

        public EditarMascotasModel()
        {
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        }

        public void OnGet(int? mascotaId)
        {
            listaDuenos = _repoDueno.GetAllDuenos();
            listaVeterinarios = _repoVeterinario.GetAllVeterinarios();
            listaHistorias = _repoHistoria.GetAllHistorias();

            if (mascotaId.HasValue)
            {
                mascota = _repoMascota.GetMascota(mascotaId.Value);
            }
            else
            {
                mascota = new Mascota();
            }

            Page();

        }

        public IActionResult OnPost(Mascota mascota, int duenoId, int veterinarioId)
        {
            if (ModelState.IsValid)
            {
                dueno = _repoDueno.GetDueno(duenoId);
                veterinario = _repoVeterinario.GetVeterinario(veterinarioId); 
                historia = new Historia
                {
                    FechaInicial = DateTime.Today


                };


                
                if (mascota.Id > 0)
                {
                    mascota.Veterinario = veterinario;
                    mascota.Dueno = dueno;
                    
                    mascota = _repoMascota.UpdateMascota(mascota);
                }
                else
                {
                    mascota = _repoMascota.AddMascota(mascota);
                    _repoMascota.AsignarDueno(mascota.Id, dueno.Id);
                    _repoMascota.AsignarVeterinario(mascota.Id, veterinario.Id);
                }
                return RedirectToPage("/Mascotas/ListaMascotas");

            }
            else
            {
                return Page();
            }
        }
    }
}
