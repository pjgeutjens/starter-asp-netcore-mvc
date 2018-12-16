using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {

        public string Phone()
        {
            return "0478/658806";
        }

        public string Address()
        {
            return "Centrumstraat 1 b01.010";
        }
    }
}
