using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GriGame {
    public class Plain : Tile {
        [SerializeField] private Color otherColor;
        
        
        public override void Init(int x, int y) {
            base.Init(x, y);
            bool isBase = (x + y) % 2 == 0;
            spriteRenderer.color = isBase ? baseColor : otherColor;
        }
       
    }
}