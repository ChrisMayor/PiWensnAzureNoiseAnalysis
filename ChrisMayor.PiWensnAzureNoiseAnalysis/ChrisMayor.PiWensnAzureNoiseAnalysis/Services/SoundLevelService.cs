using ChrisMayor.PiWensnAzureNoiseAnalysis.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChrisMayor.PiWensnAzureNoiseAnalysis.Services
{
    public class SoundLevelService
    {
        private readonly NoiseContext _context;

        public SoundLevelService(NoiseContext context)
        {
            _context = context;
        }

        public async Task<NoiseItem> GetLastSoundLevelAsync()
        {
            var lastItem = await _context.NoiseItems.OrderByDescending(x => x.ExecutionDate).FirstOrDefaultAsync();
            return lastItem;
        }

        public async Task<double> GetAverageSoundLevelToday()
        {
            var averageSoundLevel = await _context.NoiseItems.Where(x => x.ExecutionDate.Date == DateTime.Today).AverageAsync(x => x.SoundLevel);
            return averageSoundLevel;
        }
    }
}
