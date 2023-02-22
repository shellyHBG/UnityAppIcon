using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.AppIcon
{
    public class PlatformIconFactory
    {
        public static IPlatformIcon CreateIcon()
        {
            IPlatformIcon platIcon = null;
#if UNITY_ANDROID
            platIcon = new AndroidIcon();
#elif UNITY_IOS
            platIcon = new iOSIcon();
#endif
            return platIcon;
        }
    }
}
