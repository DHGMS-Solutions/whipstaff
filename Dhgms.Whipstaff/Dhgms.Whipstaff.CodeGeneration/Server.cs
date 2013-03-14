namespace Dhgms.Whipstaff.CodeGeneration
{
    /// <summary>
    /// Generation information for a server object
    /// </summary>
    public class Server : Dhgms.Nucleotide.Model.Info.ClassGenerationParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        public Server()
        {
            this.MainNamespaceName = "Dhgms.Whipstaff";

            this.ClassName = "Server";

            //this.ClassDescription = "Represents a server";

            this.Properties = new Dhgms.Nucleotide.Model.Info.PropertyInfo.Base[]
                {
                    new Dhgms.Nucleotide.Model.Info.PropertyInfo.Integer32(Dhgms.Nucleotide.Model.Info.CollectionType.None, "Id", "Unique Id", false, 0, null, true, null),
                    new Dhgms.Nucleotide.Model.Info.PropertyInfo.ClrString(Dhgms.Nucleotide.Model.Info.CollectionType.None, "Name", "Name of project", false, 0, null, false, true, null),
                    new Dhgms.Nucleotide.Model.Info.PropertyInfo.ClrString(Dhgms.Nucleotide.Model.Info.CollectionType.None, "Description", "Description of project", false, 0, null, false, true, null),
                    new Dhgms.Nucleotide.Model.Info.PropertyInfo.Integer32(Dhgms.Nucleotide.Model.Info.CollectionType.None, "Population", "Server Population", false, 0, null, false, null),
                    new Dhgms.Whipstaff.Nucleotide.Model.Info.PropertyInfo.ServerStatus(Dhgms.Nucleotide.Model.Info.CollectionType.None, "Status", "Server Status", false, false, null)
                };
        }
    }
}
