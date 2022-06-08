using System;
using System.Collections;
using System.Collections.Generic;
using OknaaEXTENSIONS;
using UnityEngine;

namespace GriGame {
    public abstract class Tile : MonoBehaviour {
        [SerializeField] protected float weight;
        [SerializeField] protected List<Sprite> sprites;

        protected SpriteRenderer spriteRenderer;
        private GameObject highlight;
        

        protected virtual void Awake() {
            highlight = transform.GetChild(0).gameObject;
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        public virtual void Init(int x, int y) {
            name = $"Tile {x}, {y}";
            spriteRenderer.sprite = sprites.Random();
        }

        
        public void OnMouseEnter() => highlight.SetActive(true);
        public void OnMouseExit() => highlight.SetActive(false);
        
        public float GetWeight() => weight;
    }
}