using Android.App;
using Android.Content;
using Android.Widget;
using numpitz.device;

namespace numpitz.device.Platforms.Android;

[BroadcastReceiver(Enabled = true, Exported = false)]
[IntentFilter([Constants.AlarmAction ])]
public class AlarmReceiver : BroadcastReceiver
{
    public override void OnReceive(Context? context, Intent? intent)
    {
        Toast
            .MakeText(context, "Alarm Ringing!", ToastLength.Short)
            ?.Show();
    }
}
