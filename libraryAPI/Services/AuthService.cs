using libraryAPI.Contract.Auth;
using libraryAPI.Result;

namespace libraryAPI.Services
{
    public class AuthService : IAuthService
    {
        public Task<Result<AuthResponse>> LoginAsync(LoginRequest loginRequest, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Result<SignupResponse>> SignupAsync(SignupRequest loginRequest, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
