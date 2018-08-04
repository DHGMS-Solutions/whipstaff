//using Dhgms.Nucleotide.Model.Info.PropertyInfo;

//namespace Dhgms.Whipstaff.CodeGeneration
//{
//    /// <summary>
//    /// Generation information for a server object
//    /// </summary>
//    public class Server : Dhgms.Nucleotide.Model.Info.ClassGenerationParameters
//    {
//        public override string MainNamespaceName
//        {
//            get { return "Dhgms.Whipstaff"; }
//        }

//        public override string SubNamespace
//        {
//            get { return null; }
//        }

//        public override string ClassName
//        {
//            get { return "Server"; }
//        }

//        public override Base[] Properties
//        {
//            get
//            {
//                return new Dhgms.Nucleotide.Model.Info.PropertyInfo.Base[]
//                {
//                    new Dhgms.Nucleotide.Model.Info.PropertyInfo.Integer32(Dhgms.Nucleotide.Model.Info.CollectionType.None, "Id", "Unique Id", false, 0, null, true, null),
//                    new Dhgms.Nucleotide.Model.Info.PropertyInfo.ClrString(Dhgms.Nucleotide.Model.Info.CollectionType.None, "Name", "Name of project", false, 0, null, false, true, null),
//                    new Dhgms.Nucleotide.Model.Info.PropertyInfo.ClrString(Dhgms.Nucleotide.Model.Info.CollectionType.None, "Description", "Description of project", false, 0, null, false, true, null),
//                    new Dhgms.Nucleotide.Model.Info.PropertyInfo.Integer32(Dhgms.Nucleotide.Model.Info.CollectionType.None, "Population", "Server Population", false, 0, null, false, null),
//                    new Dhgms.Whipstaff.Nucleotide.Model.Info.PropertyInfo.ServerStatus(Dhgms.Nucleotide.Model.Info.CollectionType.None, "Status", "Server Status", false, false, null)
//                };
//            }
//        }

//        public override Base[] BaseClassProperties
//        {
//            get { return null; }
//        }

//        public override string CompanyName
//        {
//            get { return "DHGMS Solutions"; }
//        }

//        public override string[] CopyrightBanner
//        {
//            get { return new []{"Copyright 2012-2014. All Rights Reserved."}; }
//        }

//        public override int CopyrightStartYear
//        {
//            get { return 2012; }
//        }

//        public override string BaseClassName
//        {
//            get { return null; }
//        }

//        public override string ClassRemarks
//        {
//            get { return null; }
//        }
//    }
//}
