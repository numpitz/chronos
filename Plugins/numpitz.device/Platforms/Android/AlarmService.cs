using Android.App;
using Android.Content;
using Android.Widget;
using chronos.usecases;
using numpitz.device.Platforms.Android;

namespace numpitz.device;

public partial class AlarmService : IAlarmService
{
    public void CheckAlarm()
    {
        var context = Platform.CurrentActivity;
        Intent intent = new Intent(Constants.AlarmAction);
        var alarmIntent = PendingIntent.GetBroadcast(
            context,
            0,
            intent,
            PendingIntentFlags.Mutable | PendingIntentFlags.NoCreate);

        var alarmExists = (alarmIntent != null);

        Toast
            .MakeText(context, $"AlarmExists = {alarmExists}", ToastLength.Long)
            ?.Show();
    }

    public void RaisAlarm()
    {
        if (Platform.CurrentActivity is not { } context)
            return;
        
        var intent = new Intent(context, typeof(AlarmReceiver));
        intent.PutExtra("key", "value");

        context.SendBroadcast(intent);
    }

    public void SetAlarm(DateTime time)
    {
        if (Platform.CurrentActivity is not { } context
            || context.GetSystemService(Context.AlarmService) as AlarmManager is not { } alarmManager)
            return;

        var intent = new Intent(context, typeof(AlarmReceiver));
        intent.PutExtra("key", "value");

        var pendingIntent = PendingIntent.GetBroadcast(
            context,
            0,
            intent,
            PendingIntentFlags.Mutable);

        // Convert DateTime to milliseconds since epoch
        long millis = (long)(time - new DateTime(1970, 1, 1)).TotalMilliseconds;

        alarmManager.SetExactAndAllowWhileIdle(AlarmType.RtcWakeup, millis, pendingIntent);
    }

}
