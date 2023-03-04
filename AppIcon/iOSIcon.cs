using UnityEditor;
using UnityEngine;

namespace Builder.AppIcon
{
    #if UNITY_IOS
    public class iOSIcon : IPlatformIcon
    {
        #region implement IPlatformIcon
        BuildTargetGroup IPlatformIcon.Target => BuildTargetGroup.iOS;
        PlatformIconKind IPlatformIcon.IconKind => UnityEditor.iOS.iOSPlatformIconKind.Application;

        void IPlatformIcon.SetIconTexture(PlatformIcon[] inAppIcons, Texture2D inTexture)
        {
            for (int i = 0; i < inAppIcons.Length; i++)
            {
                inAppIcons[i].SetTexture(inTexture);
            }
        }
        #endregion
    }
    #endif
}
