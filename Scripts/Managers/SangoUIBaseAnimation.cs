﻿using UnityEngine;

namespace SangoUtils.Tweens_Unity
{
    public abstract class SangoUIBaseAnimation : MonoBehaviour
    {
        public SangoUIAnimationType AnimationType { get; set; }
        public float DurationTime { get; set; }

        public abstract void InitAnimation(params string[] commands);
        public abstract void PlayAnimation(params string[] commands);
        public abstract void StopAnimation();
        public abstract void ResetAnimation();
    }

    public enum SangoUIAnimationType
    {
        Timer,
    }
}
