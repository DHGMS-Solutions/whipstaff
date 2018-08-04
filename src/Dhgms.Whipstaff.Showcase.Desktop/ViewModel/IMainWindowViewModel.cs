namespace Dhgms.Whipstaff.Showcase.Desktop.ViewModel
{
    using ReactiveUI;

    public interface IMainWindowViewModel
    {
        ReactiveList<string> NativeSampleCollection { get; }

        ReactiveList<string> CrossPlatformSampleCollection { get; }
    }
}
