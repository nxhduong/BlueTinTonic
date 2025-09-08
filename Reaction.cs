namespace BlueTinTonic
{
    public record struct Reaction(string Name, int Value, string IconSrc)
    {
        public static readonly HashSet<Reaction> PresetReactionTypes = [
            new Reaction("Upvote", 1, ""),
            new Reaction("Downvote", -1, "")
        ];
    }
}
