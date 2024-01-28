using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace team13
{
    public class ScrollingBackground : MonoBehaviour
    {
        public float speed;
        [SerializeField] private Renderer backgroundRenderer;
        // Start is called before the first frame update
        void Start()
        {
            backgroundRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
