using UnityEngine;

namespace System.Tile
{
    public class HexagonTile : MonoBehaviour
    {
        public bool IsSelected { get; private set; }

        [SerializeField] private Transform _mesh;

        private void Start()
        {
            ETile.OnTileStart.Invoke(this);
        }

        private void OnMouseDown()
        {
            ETile.OnTileClick.Invoke(this);
        }

        public void SelectTile()
        {
            IsSelected = true;
            _mesh.localPosition = new Vector3(0,0.025f,0);
        }

        public void DeselectTile()
        {
            IsSelected = false;
            _mesh.localPosition = new Vector3(0,0,0);
        }
        
        public void Rotate()
        {
            transform.RotateAround(transform.position, Vector3.up, 60);
        }
        
        public void SetPosition(Vector3 position)
        {
            transform.position = position;
        }
    }
}
