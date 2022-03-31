using System.Tile;
using UnityEngine;

namespace System.Grid
{
    public class GridBoard : MonoBehaviour
    {
        private readonly TileHolder _tileHolder = new TileHolder();

        private void Awake()
        {
            ETile.OnTileStart.AddListener(_tileHolder.AddTile);
            ETile.OnTileClick.AddListener(_tileHolder.OnTileClicked);
        }
    }
}