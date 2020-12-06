using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChrisMayor.PiWensnAzureNoiseAnalysis.Entities;
using ChrisMayor.PiWensnAzureNoiseAnalysis.Model;
using ChrisMayor.PiWensnAzureNoiseAnalysis.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ChrisMayor.PiWensnAzureNoiseAnalysis.Api.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class NoiseController : ControllerBase
    {

        private readonly ILogger<NoiseController> _logger;

        private readonly NoiseContext _context;

        private readonly IOptions<NoiseConfig> _noiseOptions;

        public NoiseController(NoiseContext context, IOptions<NoiseConfig> noiseOptions)
        {
            _context = context;
            _noiseOptions = noiseOptions;
        }

        [HttpPost]
        public async Task<ActionResult> Post(NoiseItemModel noiseItemModel)
        {
            if (_noiseOptions.Value.Secret != noiseItemModel.SecretKey)
            {
                return this.Forbid();
            }

            var noiseItem = new NoiseItem
            {
                ExecutionDate = noiseItemModel.Date,
                SoundLevel = noiseItemModel.Db,
                IsTestItem = noiseItemModel.IsTest
            };
            _context.NoiseItems.Add(noiseItem);
            await _context.SaveChangesAsync();

            return this.Ok(noiseItem);
        }

    }
}
