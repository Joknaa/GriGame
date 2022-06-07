using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GriGame {
    public class Tile : MonoBehaviour {
        [SerializeField] private SpriteRenderer rend;
        [SerializeField] private Color baseColor;
        [SerializeField] private Color otherColor;
        [SerializeField] private GameObject highlight;
        private bool isHighlighted;

        public void Init(int x, int y) {
            bool isBase = (x + y) % 2 == 0;
            rend.color = isBase ? baseColor : otherColor;
            name = $"Time {x}, {y}";
        }

        public void OnMouseEnter() {
            isHighlighted = true;
            highlight.SetActive(true);
        }

        public void OnMouseExit() {
            isHighlighted = false;
            highlight.SetActive(false);
        }
    }
}