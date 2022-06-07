using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GriGame {
    public class GridManager : MonoBehaviour {
        [SerializeField] private GameObject tilePrefab;
        private int height = 9;
        private int width = 16;

        void Start() {
            GenerateGrid();
        }

        private void GenerateGrid() {
            for (int y = 0; y < height; y++) {
                for (int x = 0; x < width; x++) {
                    GameObject tile = Instantiate(tilePrefab, new Vector3(x, y), Quaternion.identity, transform);
                    tile.GetComponent<Tile>().Init(x, y);
                }
            }

            Camera.main.transform.position = new Vector3(width * 0.5f - 0.5f, height * 0.5f - 0.5f, -10);
        }
    }
}