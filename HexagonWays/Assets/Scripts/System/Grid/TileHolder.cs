using System.Collections.Generic;
using System.Linq;
using System.Tile;
using UnityEngine;

namespace System.Grid
{
    public class TileHolder
    {
        private readonly List<HexagonTile> _hexagonTiles = new List<HexagonTile>();

        public void AddTile(HexagonTile hexagonTile)
        {
            _hexagonTiles.Add(hexagonTile);
        }

        public void OnTileClicked(HexagonTile clickedTile)
        {
            if (_hexagonTiles.Any(o => o.IsSelected))
            {
                var selectedTile = _hexagonTiles.FirstOrDefault(o => o.IsSelected);

                if (selectedTile == clickedTile)
                {
                    clickedTile.transform.RotateAround(clickedTile.transform.position, Vector3.up, 60);
                }
                else
                {
                    var hexagonTilePosition = clickedTile.transform.position;
                    clickedTile.transform.position = selectedTile.transform.position;
                    selectedTile.transform.position = hexagonTilePosition;
                    DeselectAll();
                }
            }
            else
            {
                DeselectAll();
                clickedTile.SelectTile();
            }
        }

        private void DeselectAll()
        {
            foreach (var tile in _hexagonTiles)
            {
                tile.DeselectTile();
            }
        }
    }
}