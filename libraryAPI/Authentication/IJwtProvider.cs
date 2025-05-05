using libraryAPI.Entities;

namespace libraryAPI.Authentication
{
    public interface IJwtProvider
    {
        string GenerateToken(ApplicationUser user, IEnumerable<string> roles, IEnumerable<string> permissions);

    }
}
