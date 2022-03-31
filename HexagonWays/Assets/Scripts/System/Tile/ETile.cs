using UnityEngine.Events;

namespace System.Tile
{
    public static class ETile
    {
        public static readonly OnTileStart OnTileStart = new OnTileStart();
        public static readonly OnTileClick OnTileClick = new OnTileClick();
    }
    public class OnTileStart : UnityEvent <HexagonTile>{};
    public class OnTileClick : UnityEvent <HexagonTile>{};
}