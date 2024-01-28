using UnityEngine;

namespace team13
{
    public class Stone : ObjectInteraction
    {
        protected override void HandleClickEffect()
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.StoneDuar);
            // Custom implementation for Stone (destroy the object)
            base.HandleClickEffect();
        }
    }
}
