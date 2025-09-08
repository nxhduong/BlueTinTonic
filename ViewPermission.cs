namespace BlueTinTonic
{
    public record ViewPermission(HashSet<Allowed> Entities);

    public record Allowed
    {
        public record Member(string AllowedMembers): Allowed;
        public record Role(string AllowedMembers): Allowed;
    }
}
