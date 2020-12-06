using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChrisMayor.PiWensnAzureNoiseAnalysis.Entities
{
    public class NoiseItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public double SoundLevel { get; set; }

        [Required]
        public DateTime ExecutionDate { get; set; }

        [Required]
        public bool IsTestItem { get; set; }
    }
}
