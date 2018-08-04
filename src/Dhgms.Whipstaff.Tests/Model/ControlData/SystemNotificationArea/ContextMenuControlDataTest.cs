//namespace Dhgms.Whipstaff.Tests.Model.ControlData.SystemNotificationArea
//{
//    using Dhgms.Whipstaff.Model.ControlData.SystemNotificationArea;

//    using NUnit.Framework;

//    public class ContextMenuControlDataTest
//    {
//        /// <summary>
//        /// Unit tests for class initialization
//        /// </summary>
//        public class Initializer
//        {
//            /// <summary>
//            /// Test to ensure success under normal operation.
//            /// </summary>
//            [Test]
//            [Category("ShouldSucceed")]
//            public void ShouldSucceed()
//            {
//                var items = new[]
//                                {
//                                    new ContextMenuItem { Label = "Label1", ToolTip = "ToolTip1" },
//                                    new ContextMenuItem { Label = "Label2", ToolTip = "ToolTip2" },
//                                    new ContextMenuItem { Label = "Label3", ToolTip = "ToolTip3" },
//                                    new ContextMenuItem { Label = "Label4", ToolTip = "ToolTip4" },
//                                    new ContextMenuItem { Label = "Label5", ToolTip = "ToolTip5" }
//                                };

//                var instance = new ContextMenuControlData
//                                   {
//                                       Items
//                                           =
//                                           items
//                                   };

//                Assert.NotNull(instance.Items);
//                Assert.AreEqual(5, instance.Items.Length);

//                for (var i = 0; i < 5; i++)
//                {
//                    Assert.AreEqual("Label" + i, instance.Items[i].Label);
//                    Assert.AreEqual("ToolTip" + i, instance.Items[i].ToolTip);
//                }
//            }
//        }
//    }
//}
