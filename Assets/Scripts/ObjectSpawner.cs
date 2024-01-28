using UnityEngine;

namespace team13
{
    public class ObjectSpawner : MonoBehaviour
    {
        public static ObjectSpawner instance;

        void Awake()
        {
            if (instance == null)
                instance = this;
            else
                Destroy(gameObject);
        }
    }
}
