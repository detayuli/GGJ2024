using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace team13
{
    public class FollowBackground : MonoBehaviour
    {
        public GameObject scrollingBackground;

        void Update()
        {
            float backgroundScrollSpeed = scrollingBackground.GetComponent<ScrollingBackground>().speed;
            transform.Translate(Vector3.left * backgroundScrollSpeed * Time.deltaTime);
        }
    }
}
