using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace team13
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Parallax : MonoBehaviour
    {
        [SerializeField] private Vector2 speed = new Vector2(0.5f, 0.5f);
        private SpriteRenderer spriteRenderer;

        void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        void Update()
        {
            Vector2 offset = new Vector2(Time.time * speed.x % 1, Time.time * speed.y % 1);
            spriteRenderer.material.mainTextureOffset = offset;
        }
    }
}
