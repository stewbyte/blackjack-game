using System.Diagnostics;

namespace blackjack_game
{
    [DebuggerDisplay("{Name} {Value}")]
    internal class Card
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string Image { get; set; }
    }
}
