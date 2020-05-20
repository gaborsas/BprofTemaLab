using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BProfTemaLab.Views.Shared.Components.Stand
{
    public class StandViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IEnumerable<BProfTemaLab.Dal.Dtos.StandDto> stands)
        {
            return View(stands);
        }
    }
}
