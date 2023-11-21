using Microsoft.AspNetCore.Components;

namespace clone_serverWater.Controllers
{
    [Route("/api/[controller]")]
    public class UserController
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

    }
}
