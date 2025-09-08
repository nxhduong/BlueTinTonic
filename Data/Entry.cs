using System.ComponentModel.DataAnnotations;

namespace BlueTinTonic.Data
{
    public class Entry
    {
        [Required]
        public required string PostId { get; set; }
        [Required]
        public required string Author { get; set; }

        public Stack<(DateTime, string)> Title { get; private set; } = [];
        public Stack<(DateTime, string)> Content { get; private set; } = [];

        public ViewPermission? Visibility { get; set; } = null;

        public readonly Dictionary<string, Reaction> Reactions = [];
        public readonly HashSet<string> Children = [];
    }
}
