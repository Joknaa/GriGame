using System.Collections;
using System.Collections.Generic;
using OknaaEXTENSIONS;
using UnityEngine;

namespace GriGame {
    public class GridManager : MonoBehaviour {
        private int height = 9;
        private int width = 16;

        void Start() {
            GenerateGrid();
        }

        private void GenerateGrid() {
            List<Tile> tiles = Resources.LoadAll<Tile>("Tiles").ToList();
            
            for (int y = 0; y < height; y++) {
                for (int x = 0; x < width; x++) {

                    var randomTile = GetRandomTileByWeight(tiles); ; 
                    GameObject tile = Instantiate(randomTile, new Vector3(x, y), Quaternion.identity, transform);
                    tile.GetComponent<Tile>().Init(x, y);
                }
            }

            Camera.main.transform.position = new Vector3(width * 0.5f - 0.5f, height * 0.5f - 0.5f, -10);
        }

        private GameObject GetRandomTileByWeight(List<Tile> tiles) {
            float totalWeight = 0;
            foreach (var tile in tiles) totalWeight += tile.GetWeight();
            
            float random = Random.Range(0f, totalWeight);
            
            foreach (var tile in tiles) {
                random -= tile.GetWeight();
                if (random <= 0) return tile.gameObject;
            }
            
            return tiles[0].gameObject;
        }
    }
}