namespace Dhgms.Whipstaff.Core.Model
{
    using System.Collections.Generic;

    public class VersionHistory
    {
        public string Header { get; set; }

        public List<string> Changes { get; set; }
    }
}
