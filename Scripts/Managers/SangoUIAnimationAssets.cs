using UnityEngine;

namespace SangoUtils.Tweens_Unity
{
    public static class SangoUIAnimationAssets
    {
        public static SangoUIAnimationAssets_ResSangoUISlideBroadCastImageAnimation SangoUISlideBroadCastImageAnimation(Transform parentTrans, float aniDurationTime)
        {
            SangoUIAnimationAssets_ResSangoUISlideBroadCastImageAnimation animation = new SangoUIAnimationAssets_ResSangoUISlideBroadCastImageAnimation(parentTrans, aniDurationTime);
            animation.InitAnimation();
            return animation;
        }
    }
}
