using System;
using UnityEngine;

namespace GameUI
{
    public class TransitionUI : MonoBehaviour
    {
        private Animator _animator;
        private static readonly int End = Animator.StringToHash("End");

        private void Start()
        {
            _animator = GetComponent<Animator>();
        }

        public void EndAnimation()
        {
            _animator.SetTrigger(End);
        }
    }
}
