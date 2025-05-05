using libraryAPI.Contract.Auth;
using libraryAPI.Result;

namespace libraryAPI.Services
{
    public interface IAuthService
    {
        Task<Result<AuthResponse>> LoginAsync(LoginRequest loginRequest, CancellationToken cancellationToken);
        Task<Result<SignupResponse>> SignupAsync(SignupRequest loginRequest, CancellationToken cancellationToken);
    }
}
