namespace Domain
{
    public class JoinCreateGame
    {
        public string Game { get; set; } = default!;
        public string Name { get; set; } = default!;
        public int Players { get; set; }
        public string? Code { get; set; }
        public string Command { get; set; } = default!;
    }
}