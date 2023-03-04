using UnityEditor;
using UnityEngine;

namespace Builder.AppIcon
{
    public interface IPlatformIcon
    {
        BuildTargetGroup Target { get; }
        PlatformIconKind IconKind { get; }
        void SetIconTexture(PlatformIcon[] inAppIcons, Texture2D inTexture);
    }
}
