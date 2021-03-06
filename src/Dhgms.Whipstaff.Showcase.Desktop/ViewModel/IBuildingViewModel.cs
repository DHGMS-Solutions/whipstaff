﻿namespace Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface
{
    using System.Collections.Generic;

    public interface IBuildingViewModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the building floors
        /// </summary>
        List<string> Floors { get; set; }
    }
}
