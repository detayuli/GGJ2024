using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace team13
{
    public class MainCharacter : MonoBehaviour
    {
        public Vector3 jumpOffset = new Vector3(2, 0, 0);
        public float jumpPower = 1;
        public float jumpDuration = 1;
        public void OnGetHitByStoneExplosion()
        {
            StartCoroutine(CoolJumpAnimation());
        }

        private IEnumerator CoolJumpAnimation()
        {
            transform.DORotate(new Vector3(0f, 0f, -360f), jumpDuration, RotateMode.FastBeyond360);
            yield return transform.DOJump(transform.position + jumpOffset, jumpPower, 1, jumpDuration)
                .WaitForCompletion();
        }
    }
}
