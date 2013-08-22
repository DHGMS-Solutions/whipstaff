namespace Dhgms.Whipstaff.ViewModel
{
    interface IFeatureUsageTracking
    {
        void OnFeatureStart();

        void OnFeatureEnd();

        void OnFeatureException();

        void OnFeatureError();
    }
}
