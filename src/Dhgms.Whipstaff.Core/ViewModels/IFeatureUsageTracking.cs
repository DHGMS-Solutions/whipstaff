namespace Dhgms.Whipstaff.Core.ViewModels
{
    public interface IFeatureUsageTracking
    {
        void OnFeatureStart();

        void OnFeatureEnd();

        void OnFeatureException(System.Exception exception);

        void OnFeatureError();
    }
}
