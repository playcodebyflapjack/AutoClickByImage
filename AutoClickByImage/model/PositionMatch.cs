namespace BotAutoFindItem.model
{
    public class PositionMatch
    {
        public int x { get; }
        public int y { get; }

        private PositionMatch()
        {

        }

        public PositionMatch(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
}
