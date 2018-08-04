namespace Dhgms.Whipstaff.Model.Difference
{
        using System;
        using System.ComponentModel.DataAnnotations;
        using System.Diagnostics;
        using System.Diagnostics.CodeAnalysis;
        using System.Runtime.Serialization;
        using System.Xml;
        using System.Xml.Linq;

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Represents a server
        /// </summary>
        [DataContract]
        public class ServerDifference
// ReSharper disable RedundantNameQualifier
            : Dhgms.DataManager.Model.Info.Difference<ServerDifference>
// ReSharper restore RedundantNameQualifier
        {
        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerDifference"/> class.
        /// </summary>
        public ServerDifference()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerDifference"/> class.
        /// </summary>
        /// <param name="other">
        /// Object to copy
        /// </param>
        public ServerDifference(ServerDifference other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }

            this.Id = other.Id;
            this.Name = other.Name;
            this.Description = other.Description;
            this.Population = other.Population;
            this.Status = other.Status;
        }

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerDifference"/> class.
        /// </summary>
        /// <param name="id">Unique Id</param>
        /// <param name="name">Name of project</param>
        /// <param name="description">Description of project</param>
        /// <param name="population">Server Population</param>
        /// <param name="status">Server Status</param>
        public ServerDifference(
            bool id,
            bool name,
            bool description,
            bool population,
            bool status)
            {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Population = population;
            this.Status = status;
        }

        #region properties
        /// <summary>
        /// Unique Id
        /// </summary>
        public bool Id
        {
            get;
            set;
        }

        /// <summary>
        /// Name of project
        /// </summary>
        public bool Name
        {
            get;
            set;
        }

        /// <summary>
        /// Description of project
        /// </summary>
        public bool Description
        {
            get;
            set;
        }

        /// <summary>
        /// Server Population
        /// </summary>
        public bool Population
        {
            get;
            set;
        }

        /// <summary>
        /// Server Status
        /// </summary>
        public bool Status
        {
            get;
            set;
        }

            /// <summary>
            /// Gets a header record for use for something like a CSV file
            /// </summary>
            /// <returns>a collection of strings representing the header record</returns>
            public override System.Collections.Generic.IList<string> HeaderRecord
            {
                get
                {
                    var result = new System.Collections.Generic.List<string>
                    {
                        "Id",
                        "Name",
                        "Description",
                        "Population",
                        "Status"
                    };

                    return result;
                }
            }

            /// <summary>
            /// Gets the number of properties that are different
            /// </summary>
            /// <return>
            /// the number of properties that are different
            /// </return>
            public override int Count
            {
                get
                {
                    return
                    ((Id) ? 1 : 0)
                    + ((Name) ? 1 : 0)
                    + ((Description) ? 1 : 0)
                    + ((Population) ? 1 : 0)
                    + ((Status) ? 1 : 0)
                    ;
                }
            }

        #endregion

        #region IComparable methods

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">
        /// The instance to compare to
        /// </param>
        /// <returns>
        /// 0 if equal, otherwise non zero
        /// </returns>
        public override int CompareTo(ServerDifference other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }

        var checkResult = 0;
                        checkResult = Id.CompareTo(other.Id);
            if(checkResult != 0)
            {
                return (checkResult > 0) ? 1 : -1;
            }

                        checkResult = Name.CompareTo(other.Name);
            if(checkResult != 0)
            {
                return (checkResult > 0) ? 2 : -2;
            }

                        checkResult = Description.CompareTo(other.Description);
            if(checkResult != 0)
            {
                return (checkResult > 0) ? 3 : -3;
            }

                        checkResult = Population.CompareTo(other.Population);
            if(checkResult != 0)
            {
                return (checkResult > 0) ? 4 : -4;
            }

                        checkResult = Status.CompareTo(other.Status);
            if(checkResult != 0)
            {
                return (checkResult > 0) ? 5 : -5;
            }

            return 0;
        }

        #endregion
#region IEquatable methods
            /// <summary>
            /// Checks if the current instance matches another of the same type
            /// </summary>
            /// <param name="other">object to compare</param>
            /// <returns>true if equal, otherwise false</returns>
            public override bool Equals(ServerDifference other)
            {
                return this.CompareTo(other) == 0;
            }

#endregion

    #region our methods

        /// <summary>
        /// Gets the hash code for the object
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return
                this.Id.GetHashCode()
                ^ this.Name.GetHashCode()
                ^ this.Description.GetHashCode()
                ^ this.Population.GetHashCode()
                ^ this.Status.GetHashCode();
        }

        /// <summary>
        /// Checks a table to ensure it meets the required schema
        /// </summary>
        public override void DoTableValidation()
        {
        }

            /// <summary>
            /// Gets a collection of string data for use for something like a CSV file
            /// </summary>
            /// <returns>a collection of strings representing the data record</returns>
            public override System.Collections.Generic.IList<string> ToStringArray()
            {
                var result = new System.Collections.Generic.List<string>
                {
                    this.Id ? "1" : "0",
                    this.Name ? "1" : "0",
                    this.Description ? "1" : "0",
                    this.Population ? "1" : "0",
                    this.Status ? "1" : "0"
                };

                return result;
            }

            /// <summary>
            /// Adds an XML Element to an XML Writer
            /// </summary>
            /// <param name="writer">
            /// The XML writer to add the element to.
            /// </param>
            /// <param name="parentElementName">
            /// The name for the parenet element being produced.
            /// </param>
            public override void DoXmlElement(
                    System.Xml.XmlWriter writer,
                    string parentElementName)
            {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }

            if (string.IsNullOrEmpty(parentElementName) || parentElementName.Trim().Length == 0)
            {
            throw new ArgumentNullException("parentElementName");
            }

                writer.WriteStartElement(parentElementName);

                // Id
                this.DoChildXmlCDataElement(writer, "Id", this.Id ? "1" : "0");

                // Name
                this.DoChildXmlCDataElement(writer, "Name", this.Name ? "1" : "0");

                // Description
                this.DoChildXmlCDataElement(writer, "Description", this.Description ? "1" : "0");

                // Population
                this.DoChildXmlCDataElement(writer, "Population", this.Population ? "1" : "0");

                // Status
                this.DoChildXmlCDataElement(writer, "Status", this.Status ? "1" : "0");

                writer.WriteEndElement();
            }


        /// <summary>
        /// Gets the names of the columns that are different
        /// </summary>
        /// <returns>
        /// list of names of the columns that are different
        /// </returns>
        public override System.Collections.Generic.IList<string> GetColumnNames()
        {
            var columns = new System.Collections.Generic.List<string>();
            if (this.Id)
            {
                columns.Add("Id");
            }

            if (this.Name)
            {
                columns.Add("Name");
            }

            if (this.Description)
            {
                columns.Add("Description");
            }

            if (this.Population)
            {
                columns.Add("Population");
            }

            if (this.Status)
            {
                columns.Add("Status");
            }

            return columns;
        }

        /// <summary>
        /// Gets the CDSL that defines the OData Vocabularies for this class
        /// </summary>
        public static XmlReader GetOdataVocabularies()
        {
            // Id

            // Name

            // Description

            // Population

            // Status

        var schema = new XElement(
            "Schema",
            new XAttribute("Namespace", "Dhgms.Whipstaff"),
            new XAttribute("xmlns", "http://schemas.microsoft.com/ado/2009/11/edm"),
            // using directive
            new XElement(
                "Using",
                new XAttribute("Namespace", "Org.OData.Validation.V1"),
                new XAttribute("Alias", "Validation"),
                new XElement(
                    "Annotations",
                    new XAttribute("Target", "Dhgms.Whipstaff.Server/Id")),
                new XElement(
                    "Annotations",
                    new XAttribute("Target", "Dhgms.Whipstaff.Server/Name")),
                new XElement(
                    "Annotations",
                    new XAttribute("Target", "Dhgms.Whipstaff.Server/Description")),
                new XElement(
                    "Annotations",
                    new XAttribute("Target", "Dhgms.Whipstaff.Server/Population")),
                new XElement(
                    "Annotations",
                    new XAttribute("Target", "Dhgms.Whipstaff.Server/Status"))));

        Debug.Assert(schema.Document != null, "schema.Document != null");
        return schema.Document.CreateReader();
        }
        #endregion
            /// <summary>
            /// The on disposing event
            /// </summary>
            protected override void OnDisposing()
            {
            }
    }
}

