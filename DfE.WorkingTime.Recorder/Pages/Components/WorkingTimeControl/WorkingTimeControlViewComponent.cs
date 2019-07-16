using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DfE.WorkingTime.Recorder.Pages.Components.WorkingTimeControl
{
    public class WorkingTimeControlViewComponent : ViewComponent
    {
        public WorkingTimeControlViewComponent()
        {
        }

        public IViewComponentResult
        Invoke()
        {
        return View("Default");
        }

    }
}
