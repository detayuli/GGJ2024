using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

namespace team13
{
    public class TrafficLight : ObjectInteraction
    {
        public GameObject lightTrafficLightPrefab; // Assign in Inspector

        protected override void HandleClickEffect()
        {
            // Custom implementation for TrafficLight (transform into lightTrafficLightPrefab)
            if (lightTrafficLightPrefab != null)
            {
                Instantiate(lightTrafficLightPrefab, transform.position, transform.rotation);
            }
            Destroy(gameObject);
            AudioManager.Instance.PlaySFX(AudioManager.Instance.StoneBroken);
        }
    }
}
