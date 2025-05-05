namespace libraryAPI.Result
{
    public record Error(string code , string Description , int? StautsCode)
    {
        public static readonly Error None = new Error(string.Empty, string.Empty, null);
    }
}
