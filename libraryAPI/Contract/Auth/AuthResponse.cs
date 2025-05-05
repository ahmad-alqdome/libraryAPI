namespace libraryAPI.Contract.Auth
{
    public class AuthResponse
    {
        public string UserId { get; }
        public string Email { get; }
        public string FullName { get; }
        public string Token { get; }

        public AuthResponse(string userId, string email, string fullName, string token)
        {
            UserId = userId;
            Email = email;
            FullName = fullName;
            Token = token;
        }
    }
}
