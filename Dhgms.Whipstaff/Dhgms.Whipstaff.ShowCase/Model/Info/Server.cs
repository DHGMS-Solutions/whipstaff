namespace Dhgms.Whipstaff.Model.Info
{
        using System;
        using System.ComponentModel.DataAnnotations;
        using System.Data.Entity;
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
        public class Server
// ReSharper disable RedundantNameQualifier
            : Dhgms.DataManager.Model.Info.Base<Server>
// ReSharper restore RedundantNameQualifier
        {
        #region fields
            /// <summary>
            /// Unique Id
            /// </summary>
            [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1121:UseBuiltInTypeAlias", Justification = "Reviewed. Suppression is OK here.")]
            private int id;

            /// <summary>
            /// Name of project
            /// </summary>
            [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1121:UseBuiltInTypeAlias", Justification = "Reviewed. Suppression is OK here.")]
            private string name;

            /// <summary>
            /// Description of project
            /// </summary>
            [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1121:UseBuiltInTypeAlias", Justification = "Reviewed. Suppression is OK here.")]
            private string description;

            /// <summary>
            /// Server Population
            /// </summary>
            [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1121:UseBuiltInTypeAlias", Justification = "Reviewed. Suppression is OK here.")]
            private int population;

        #endregion

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        public Server()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        /// <param name="other">
        /// Object to copy
        /// </param>
        public Server(Server other)
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
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        /// <param name="id">Unique Id</param>
        /// <param name="name">Name of project</param>
        /// <param name="description">Description of project</param>
        /// <param name="population">Server Population</param>
        /// <param name="status">Server Status</param>
        public Server(
            int id,
            string name,
            string description,
            int population,
            Dhgms.Whipstaff.Common.Model.Info.ServerStatus status)
            {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Population = population;
            this.Status = status;
        }

            /// <summary>
            /// The on disposing event
            /// </summary>
            protected override void OnDisposing()
            {
            }
        #region properties
        /// <summary>
        /// Gets or sets Unique Id
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1121:UseBuiltInTypeAlias", Justification = "Reviewed. Suppression is OK here.")]
        [DataMember(IsRequired = true,Order = 1)]
        [Required]
[Range(typeof(int), "0", "")]
        public int Id
        {
            get
            {
                return this.id;
            }

            set
        {
            if(value < 0)
            {
                // ReSharper disable RedundantNameQualifier
                throw new Dhgms.DataManager.Model.Exception.NumberTooLowInteger32Exception("Id",0, value);
                // ReSharper restore RedundantNameQualifier
            }
            this.id = value;
        }
        }

        /// <summary>
        /// Gets or sets Name of project
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1121:UseBuiltInTypeAlias", Justification = "Reviewed. Suppression is OK here.")]
        [DataMember(IsRequired = true,Order = 2)]
        [Required]
[MinLength(0, ErrorMessage="Must be at least 0 characters in length")]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
        {
            if(value  != null && value.Length < 0)
            {
                // ReSharper disable RedundantNameQualifier
                throw new Dhgms.DataManager.Model.Exception.StringTooShortException(0, value.Length);
                // ReSharper restore RedundantNameQualifier
            }
            this.name = value;
        }
        }

        /// <summary>
        /// Gets or sets Description of project
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1121:UseBuiltInTypeAlias", Justification = "Reviewed. Suppression is OK here.")]
        [DataMember(IsRequired = true,Order = 3)]
        [Required]
[MinLength(0, ErrorMessage="Must be at least 0 characters in length")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
        {
            if(value  != null && value.Length < 0)
            {
                // ReSharper disable RedundantNameQualifier
                throw new Dhgms.DataManager.Model.Exception.StringTooShortException(0, value.Length);
                // ReSharper restore RedundantNameQualifier
            }
            this.description = value;
        }
        }

        /// <summary>
        /// Gets or sets Server Population
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1121:UseBuiltInTypeAlias", Justification = "Reviewed. Suppression is OK here.")]
        [DataMember(IsRequired = true,Order = 4)]
        [Required]
[Range(typeof(int), "0", "")]
        public int Population
        {
            get
            {
                return this.population;
            }

            set
        {
            if(value < 0)
            {
                // ReSharper disable RedundantNameQualifier
                throw new Dhgms.DataManager.Model.Exception.NumberTooLowInteger32Exception("Population",0, value);
                // ReSharper restore RedundantNameQualifier
            }
            this.population = value;
        }
        }

        /// <summary>
        /// Gets or sets Server Status
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1121:UseBuiltInTypeAlias", Justification = "Reviewed. Suppression is OK here.")]
        [DataMember(IsRequired = true,Order = 5)]
        [Required]

        public Dhgms.Whipstaff.Common.Model.Info.ServerStatus Status
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
        public override int CompareTo(Server other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }

        var checkResult = 0;
            // Id
            checkResult = this.Id.CompareTo(other.Id);

            if (checkResult != 0)
            {
                return (checkResult > 0) ? 1 : -1;
            }

            // Name
            checkResult = string.CompareOrdinal(this.Name, other.Name);

            if (checkResult != 0)
            {
                return (checkResult > 0) ? 2 : -2;
            }

            // Description
            checkResult = string.CompareOrdinal(this.Description, other.Description);

            if (checkResult != 0)
            {
                return (checkResult > 0) ? 3 : -3;
            }

            // Population
            checkResult = this.Population.CompareTo(other.Population);

            if (checkResult != 0)
            {
                return (checkResult > 0) ? 4 : -4;
            }

            // Status
            checkResult = this.Status.CompareTo(other.Status);

            if (checkResult != 0)
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
            public override bool Equals(Server other)
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
                ^ (this.Name != null ? this.Name.GetHashCode() : 0)
                ^ (this.Description != null ? this.Description.GetHashCode() : 0)
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
                    this.Id.ToString(System.Globalization.CultureInfo.InvariantCulture),
                    this.Name,
                    this.Description,
                    this.Population.ToString(System.Globalization.CultureInfo.InvariantCulture),
                    this.Status.ToString()
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
                this.DoChildXmlCDataElement(writer, "Id", this.Id.ToString(System.Globalization.CultureInfo.InvariantCulture));

                // Name
                this.DoChildXmlCDataElement(writer, "Name", this.Name);

                // Description
                this.DoChildXmlCDataElement(writer, "Description", this.Description);

                // Population
                this.DoChildXmlCDataElement(writer, "Population", this.Population.ToString(System.Globalization.CultureInfo.InvariantCulture));

                // Status
                this.DoChildXmlCDataElement(writer, "Status", this.Status.ToString());

                writer.WriteEndElement();
            }

        /// <summary>
        /// Checks this instance against another to see where there are differences
        /// </summary>
        /// <param name="other">other instance to compare</param>
        /// <returns>summary of where there are differences</returns>
// ReSharper disable RedundantNameQualifier
        public Dhgms.Whipstaff.Model.Difference.ServerDifference GetDifferences(Server other)
// ReSharper restore RedundantNameQualifier
        {
            if (other == null)
            {
                throw new System.ArgumentNullException("other");
            }

            // Id
            var checkResult = this.Id.CompareTo(other.Id);

            var id = checkResult != 0;

            // Name
            checkResult = string.CompareOrdinal(this.Name, other.Name);

            var name = checkResult != 0;

            // Description
            checkResult = string.CompareOrdinal(this.Description, other.Description);

            var description = checkResult != 0;

            // Population
            checkResult = this.Population.CompareTo(other.Population);

            var population = checkResult != 0;

            // Status
            checkResult = this.Status.CompareTo(other.Status);

            var status = checkResult != 0;

// ReSharper disable RedundantNameQualifier
            return new Dhgms.Whipstaff.Model.Difference.ServerDifference(
// ReSharper restore RedundantNameQualifier
                id
                ,name
                ,description
                ,population
                ,status
                );
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
    }
}
