using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChrisMayor.PiWensnAzureNoiseAnalysis.Model.ViewModel;
using ChrisMayor.PiWensnAzureNoiseAnalysis.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChrisMayor.PiWensnAzureNoiseAnalysis.Controllers
{
    public class DefaultController : Controller
    {

        private readonly SoundLevelService _soundLevelService;

        public DefaultController(SoundLevelService soundLevelService)
        {
            _soundLevelService = soundLevelService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var lastmesurement = await _soundLevelService.GetLastSoundLevelAsync();
            var averageSoundLevelToday = await _soundLevelService.GetAverageSoundLevelToday();


            if (lastmesurement != null)
            {
                var model = new DefaultViewModel
                {
                    LastMeasurement = lastmesurement.SoundLevel,
                    LastMeasurementDate = lastmesurement.ExecutionDate,
                    AverageSoundLevelToday = averageSoundLevelToday
                };

                return View(model);
            }
            else
            {
                return View();
            }
        }
    }
}