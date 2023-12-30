using Android.App;
using Android.Runtime;
using chronos.usecases;
using numpitz.device.Platforms.Android;

namespace chronos.app
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp()
            => MauiProgram.CreateMauiApp();
    }
}
