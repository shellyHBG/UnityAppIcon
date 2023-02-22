using UnityEditor;
using UnityEngine;

namespace Builder.AppIcon
{
    public interface IPlatformIcon
    {
        BuildTargetGroup Target { get; }
        PlatformIconKind IconKind { get; }
        void SetIconTexture(PlatformIcon[] appIcons, Texture2D texture);
    }
}
