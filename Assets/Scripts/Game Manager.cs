using UnityEngine;
using System.Collections;

namespace team13
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public GameObject[] objectsToSpawn; // Array to store the three objects
        public float pauseDuration = 5f; // Adjust this value to set the pause duration
        private bool isGamePaused = false;

        void Awake()
        {
            if (instance == null)
                instance = this;
            else
                Destroy(gameObject);
        }

        void Start()
        {
            InvokeRepeating("SpawnRandomObject", 0f, 5f);
        }

        void SpawnRandomObject()
        {
            GameObject objectToSpawn = GetRandomObject();
            GameObject spawnedObject = Instantiate(objectToSpawn, ObjectSpawner.instance.transform.position, Quaternion.identity);
            spawnedObject.GetComponent<ObjectInteraction>().SetClickable(!isGamePaused);
        }

        public void ObjectClicked(GameObject clickedObject)
        {
            if (!isGamePaused)
            {
                isGamePaused = true;
                StartCoroutine(ResumeGameAfterDelay());

                ObjectInteraction interactableObject = clickedObject.GetComponent<ObjectInteraction>();
                if (interactableObject != null)
                {
                    interactableObject.OnMouseDown();
                }
            }
        }

        System.Collections.IEnumerator ResumeGameAfterDelay()
        {
            yield return new WaitForSeconds(pauseDuration);
            isGamePaused = false;
        }

        public bool IsGamePaused()
        {
            return isGamePaused;
        }

        GameObject GetRandomObject()
        {
            // Choose one of the three objects randomly
            int randomIndex = Random.Range(0, objectsToSpawn.Length);
            return objectsToSpawn[randomIndex];
        }
    }
}
