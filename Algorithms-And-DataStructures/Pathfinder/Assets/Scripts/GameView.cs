using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace DefaultNamespace
{
    public class GameView : MonoBehaviour
    {
        public Game Game;
        public GameObject PlayerView;
        [SerializeField] private CellView TilePrefab;

        private List<CellView> _tiles = new();

        void Start()
        {
            Game.StateChanged += OnGameStateChanged;
            OnGameStateChanged(Game.State);
        }

        private void OnGameStateChanged(State state)
        {
            PlayerView.transform.position = new Vector3(state.playerPosition.x, state.playerPosition.y, 0);
            foreach (var tile in _tiles)
                Destroy(tile.gameObject);
            _tiles.Clear();

                for (int y = 0; y < state.Grid.Height; y++)
            {
                for (int x = 0; x < state.Grid.width; x++)
                {
                    var tile = Instantiate(TilePrefab, new Vector3(x, y, 0), Quaternion.identity);
                    tile.SetCell(state.Grid.GetCell(x, y));
                    _tiles.Add(tile);
                }
            }
        }
    }
}