using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.FrontEnd.Pages
{
    public class EliminarDuenosModel : PageModel{
        private readonly IRepositorioDueno _repoDueno;

        public Dueno dueno {get;set;}

        public EliminarDuenosModel(){
            this._repoDueno= new RepositorioDueno(new Persistencia.AppContext());
        }
         public IActionResult OnGet(int duenoId)
        {
            dueno=_repoDueno.GetDueno(duenoId);
            if (dueno == null){
                return RedirectToPage("./NotFound");
            }
            else
            {
                _repoDueno.DeleteDueno(duenoId);
                return Page();
            }
        }

       
    }
}
