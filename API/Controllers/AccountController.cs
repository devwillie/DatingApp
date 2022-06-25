using API.Data;
using API.Entities;

namespace API.Controllers
{
    [Route("[controller]")]
    public class AccountController : BaseApiController
    {
        private readonly DataContext _context;

        public AccountController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<AppUser>> Register()
    }
}