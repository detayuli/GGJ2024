using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace team13
{
    public class ObjectInteraction : MonoBehaviour
    {
        AudioManager audioManager;
        protected bool isClickable = true;

        public void OnMouseDown()
        {
            if (isClickable)
            {
                
                Debug.Log("Clicked"); // Add this line for debugging

                GameManager.instance.ObjectClicked(gameObject);
                HandleClickEffect();
            }
        }

        protected virtual void HandleClickEffect()
        {
            // Base implementation (destroy the object)
            Destroy(gameObject);
        }

        public void SetClickable(bool clickable)
        {
            isClickable = clickable;
        }
    }
}
