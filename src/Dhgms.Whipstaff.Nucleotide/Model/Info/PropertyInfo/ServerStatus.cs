//namespace Dhgms.Whipstaff.Nucleotide.Model.Info.PropertyInfo
//{
//    using Dhgms.Nucleotide.Model.Info;
//    using Dhgms.Nucleotide.Model.Info.PropertyInfo;

//    /// <summary>
//    /// Property Information for the Boolean Data Type
//    /// </summary>
//    public class ServerStatus : Base
//    {
//        /// <summary>
//        /// Initializes a new instance of the <see cref="ServerStatus"/> class. 
//        /// Constructor
//        /// </summary>
//        /// <param name="collection">
//        /// Wether the field is a collection
//        /// </param>
//        /// <param name="name">
//        /// Name of the field
//        /// </param>
//        /// <param name="description">
//        /// Description for the field, used for commenting
//        /// </param>
//        /// <param name="optional">
//        /// Whether the field is optionable \ nullable
//        /// </param>
//        /// <param name="isKey">
//        /// Whether the property is the primary key
//        /// </param>
//        public ServerStatus(
//            CollectionType collection,
//            string name,
//            string description,
//            bool optional,
//            bool isKey,
//            string alternativeDatabaseColumnName)
//            : base(
//                collection,
//                name,
//                description,
//                optional,
//                "Dhgms.Whipstaff.Common.Model.Info.ServerStatus",
//                "Dhgms.Whipstaff.Common.Model.SearchFilter.ServerStatus",
//                "Int32",
//                true,
//                "Dhgms.Whipstaff.Common.Model.Info.ServerStatus.Unknown",
//                true,
//                isKey,
//                true,
//                typeof(Dhgms.Whipstaff.Common.Model.Info.ServerStatus),
//                alternativeDatabaseColumnName)
//        {
//        }

//        public override string GetDataAnnotations()
//        {
//            return null;
//        }

//        /// <summary>
//        /// Whether to generate an auto property, or a property that uses a field
//        /// </summary>
//        public override bool GenerateAutoProperty
//        {
//            get
//            {
//                return true;
//            }
//        }

//        /// <summary>
//        /// Gets the code used for outputting a value as part of a string array
//        /// </summary>
//        public override string ToStringArrayCode
//        {
//            get
//            {
//                return "ToString()";
//            }
//        }

//        /// <summary>
//        /// Whether the type is disposable
//        /// </summary>
//        public override bool DisposableType
//        {
//            get
//            {
//                return false;
//            }
//        }

//        public override string RandomUnitTestValue
//        {
//            get
//            {
//                return "";
//            }
//        }
//    }
//}
