using libraryAPI.Entities;
using Microsoft.Extensions.Options;

namespace libraryAPI.Authentication
{
    public class JwtProvider(IOptions<JWTSettings> options) : IJwtProvider
    {
        private readonly JWTSettings _options = options.Value;

        public string GenerateToken(ApplicationUser user, IEnumerable<string> roles, IEnumerable<string> permissions)
        {
            throw new NotImplementedException();
        }
    }
}
