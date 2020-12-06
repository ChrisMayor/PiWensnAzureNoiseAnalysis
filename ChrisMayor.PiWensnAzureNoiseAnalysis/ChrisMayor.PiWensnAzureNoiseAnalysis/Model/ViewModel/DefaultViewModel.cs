using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChrisMayor.PiWensnAzureNoiseAnalysis.Model.ViewModel
{
    public class DefaultViewModel
    {
        public double LastMeasurement { get; set; }
        public DateTime LastMeasurementDate { get; set; }

        public double AverageSoundLevelToday { get; set; }
    }
}
