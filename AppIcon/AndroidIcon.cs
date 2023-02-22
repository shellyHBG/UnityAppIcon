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

        void IPlatformIcon.SetIconTexture(PlatformIcon[] appIcons, Texture2D texture)
        {
            for (int i = 0; i < appIcons.Length; i++)
            {
                // set foreground and background texture
                appIcons[i].SetTexture(texture, 0);
                appIcons[i].SetTexture(texture, 1);
            }
        }
        #endregion
    }
    #endif
}
