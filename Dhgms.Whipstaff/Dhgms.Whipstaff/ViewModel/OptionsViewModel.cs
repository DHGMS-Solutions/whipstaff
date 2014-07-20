namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;

    public class OptionsViewModel : ViewModelBaseClosable<OptionsViewModel>, IOptionsViewModel
    {
        /// <summary>
        /// Gets the command handler for saving changes
        /// </summary>
        public ReactiveCommand<object> SaveChanges { get; private set; }

        /// <summary>
        /// Gets the command handler for canceling changes
        /// </summary>
        public ReactiveCommand<object> CancelChanges { get; private set; }
    }
}
