using UnityEngine;

namespace team13
{
    public class Stone : ObjectInteraction
    {
        public float explosionRadius = 3;
        protected override void HandleClickEffect()
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.StoneDuar);
            MainCharacter mainCharacter = GameManager.instance.MainCharacter;
            
            // Calculate the distance between the Stone and the MainCharacter
            float distance = Vector3.Distance(transform.position, mainCharacter.transform.position);

            if (distance <= explosionRadius)
            {
                mainCharacter.OnGetHitByStoneExplosion();
            }
            
            // Custom implementation for Stone (destroy the object)
            base.HandleClickEffect();
        }
    }
}
