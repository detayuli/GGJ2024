using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace team13
{
    using UnityEngine;

    public class ObjectMovement : MonoBehaviour
    {
        public float speed = 5f;

        void Update()
        {
            if (GameManager.instance.IsGamePaused()) return;

            MoveObject();
        }

        void MoveObject()
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);

            // Destroy the object if it goes off-screen
            if (transform.position.x < -10f)
                Destroy(gameObject);
        }
    }

}
