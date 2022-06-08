namespace GriGame {
    public class Adjacents {
        private Tile up;
        private Tile down;
        private Tile left;
        private Tile right;

        
        public void SetUp(Tile tile) => up = tile;
        public void SetDown(Tile tile) => down = tile;
        public void SetLeft(Tile tile) => left = tile;
        public void SetRight(Tile tile) => right = tile;

        public Tile getUp() => up;
        public Tile getDown() => down;
        public Tile getLeft() => left;
        public Tile getRight() => right;
    }
}