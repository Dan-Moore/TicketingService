using Microsoft.AspNetCore.Mvc;
using TicketingService.Models;

namespace TicketingService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketsController : ControllerBase
    {
        
        private readonly ILogger<TicketsController> _logger;

        public TicketsController(ILogger<TicketsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUser")]
        public User Get()
        {
            var user = new User();
            user.email = "email";
            user.firstName = "first";
            user.lastName = "last";
            user.slack = "slack";
            user.Id = 1;
            return user;
        }
    }
}
