using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChrisMayor.PiWensnAzureNoiseAnalysis.Model
{
    public class NoiseItemModel
    {
        public double Db { get; set; }

        public DateTime Date { get; set; }

        public bool IsTest { get; set; }

        public string SecretKey { get; set; }
    }
}
