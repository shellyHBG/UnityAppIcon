using UnityEditor;
using UnityEngine;

namespace Builder.AppIcon
{
    #if UNITY_ANDROID
    public class AndroidIcon : IPlatformIcon
    {
        #region implement IPlatformIcon
        BuildTargetGroup IPlatformIcon.Target => BuildTargetGroup.Android;
        PlatformIconKind IPlatformIcon.IconKind => Android.AndroidPlatformIconKind.Adaptive;

        void IPlatformIcon.SetIconTexture(PlatformIcon[] inAppIcons, Texture2D inTexture)
        {
            for (int i = 0; i < inAppIcons.Length; i++)
            {
                // set foreground and background texture
                inAppIcons[i].SetTexture(inTexture, 0);
                inAppIcons[i].SetTexture(inTexture, 1);
            }
        }
        #endregion
    }
    #endif
}
