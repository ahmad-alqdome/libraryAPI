namespace libraryAPI.Const
{
    public static class Permissions
    {
        public static string Type { get; } = "permissions";

        // ✅ User Permissions
        public const string CanAddUser = "Resources|Allowed";

        // ✅ Role Permissions
        public const string CanViewRoles = "APP:Roles|Allowed";

        // ✅ Active Task Permissions
        public const string CanViewActiveTasks = "Active.Tasks|Allowed";



        // Get all permissions dynamically
        public static IList<string?> GetAllPermissions() =>
            typeof(Permissions).GetFields()
                               .Where(f => f.IsLiteral && !f.IsInitOnly)
                               .Select(x => x.GetValue(x) as string)
                               .ToList();
    }

}
