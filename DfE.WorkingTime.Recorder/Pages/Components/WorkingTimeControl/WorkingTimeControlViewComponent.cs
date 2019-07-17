using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DfE.WorkingTime.Recorder.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace DfE.WorkingTime.Recorder.Pages.Components.WorkingTimeControl
{
    public class WorkingTimeControlViewComponent : ViewComponent
    {
        public WorkingTimes time { get; set; }

        public WorkingTimeControlViewComponent()
        {
        }

        public IViewComponentResult
        Invoke(string workingTimeControlType)
        {
        return View("Default", workingTimeControlType);
        }
    }
}
