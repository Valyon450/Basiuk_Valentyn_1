using Microsoft.AspNetCore.Mvc;
using КП.Model;
using КП.Clients;

namespace КП.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpeechPresidentOfDayController : ControllerBase
    {
        [HttpGet(Name = "SpeechPresidentByDay")]
        public VideoOfDay Day(string Day)
        {
            SpeechPresidentClient client = new SpeechPresidentClient();

            return client.GetSpeechPresidentByDayAsync(Day).Result;
        }
    }
}
