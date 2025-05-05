namespace libraryAPI.Authentication
{
    public class JWTSettings
    {
        public static readonly string SectionName = "JWT"; 
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
    }
}
