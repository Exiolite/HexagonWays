using UnityEngine.Events;

namespace System.Tiles
{
    public static class ETile
    {
        public static readonly OnTileStart OnTileStart = new OnTileStart();
        public static readonly OnTileClick OnTileClicked = new OnTileClick();
    }
    public class OnTileStart : UnityEvent <Tile>{};
    public class OnTileClick : UnityEvent <Tile>{};
}