namespace Dhgms.Whipstaff.Showcase.Desktop.ViewModel
{
    using Dhgms.Whipstaff.Showcase.Desktop.Model;

    public interface IServerViewModel
    {
        string Name { get; }

        ServerState ServerState { get; }

        int CurrentUserCount { get; }

        int MaximumUserCount { get; }

        int QueueTime { get; }
    }
}
