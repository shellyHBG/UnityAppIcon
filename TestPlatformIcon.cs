using Builder.AppIcon;
using UnityEditor;
using UnityEngine;

public class TestPlatformIcon
{
    [MenuItem("Unit/Builder/PlatformIcon/ChangeIcon")]
    public static void ChangeIcon()
    {
        string iconPath = "Icon-test";
        Texture2D icon = Resources.Load(iconPath) as Texture2D;

        // default icon
        Debug.Log("Setup default icon.");
        Texture2D[] iconArray = new Texture2D[1];
        iconArray[0] = icon;
        PlayerSettings.SetIconsForTargetGroup(BuildTargetGroup.Unknown, iconArray, IconKind.Application);

        // platform icon
        IPlatformIcon platIcon = PlatformIconFactory.CreateIcon();
        if (platIcon == null)
        {
            Debug.LogError("PlatformIconFactory not support current platform.");
            return;
        }
        PlatformIcon[] appIcons = PlayerSettings.GetPlatformIcons(platIcon.Target, platIcon.IconKind);
        platIcon.SetIconTexture(appIcons, icon);
        PlayerSettings.SetPlatformIcons(platIcon.Target, platIcon.IconKind, appIcons);
    }    
}
