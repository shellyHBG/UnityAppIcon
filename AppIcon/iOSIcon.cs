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

        void IPlatformIcon.SetIconTexture(PlatformIcon[] appIcons, Texture2D texture)
        {
            for (int i = 0; i < appIcons.Length; i++)
            {
                appIcons[i].SetTexture(texture);
            }
        }
        #endregion
    }
    #endif
}
