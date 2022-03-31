using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Systems.Tiles
{
    public class TileBoard : MonoBehaviour
    {
        private readonly List<Tile> _tileList = new List<Tile>();

        private void Awake()
        {
            ETile.OnTileStart.AddListener(AddTile);
            ETile.OnTileClicked.AddListener(OnTileClicked);
        }


        private void AddTile(Tile tile)
        {
            _tileList.Add(tile);
        }

        private void OnTileClicked(Tile clickedTile)
        {
            if (_tileList.Any(o => o.IsSelected))
            {
                var selectedTile = _tileList.FirstOrDefault(o => o.IsSelected);

                if (selectedTile == clickedTile)
                {
                    clickedTile.Rotate();
                }
                else
                {
                    var clickedTilePosition = clickedTile.transform.position;
                    clickedTile.SetPosition(selectedTile.transform.position);
                    selectedTile.SetPosition(clickedTilePosition);
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
            foreach (var tile in _tileList.Where(o => o.IsSelected))
            {
                tile.DeselectTile();
            }
        }
    }
}