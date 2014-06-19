using Android.App;

namespace Chance.MvvmCross.Plugins.UserInteraction.Droid
{
    public interface IAlertDialogBuilderCustomizer
    {
        AlertDialog CustomizeAndCreate(AlertDialog.Builder dialogBuilder, Activity currentActivity);
    }
}