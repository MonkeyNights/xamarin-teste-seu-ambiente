using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Microsoft.WindowsAzure.MobileServices;
using Social;
using UIKit;

namespace HelloMonkey.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            CurrentPlatform.Init();

            global::Xamarin.Forms.Forms.Init();

            SetupStatusBar();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }

        private void SetupStatusBar()
        {
            UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(1, 87, 155);
            UINavigationBar.Appearance.TintColor = UIColor.White;

            UINavigationBar.Appearance.SetBackgroundImage(new UIImage(), UIBarPosition.Any, UIBarMetrics.Default);
            UINavigationBar.Appearance.ShadowImage = new UIImage();

            UINavigationBar.Appearance.TitleTextAttributes = new UIStringAttributes { ForegroundColor = UIColor.White };
            UINavigationBar.Appearance.Translucent = true;

            UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, true);
        }
    }
}
