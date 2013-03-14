using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Tests.Model.ControlData.SystemNotificationArea
{
    using System.Windows.Input;

    using NUnit.Framework;

    using ReactiveUI.Xaml;

    public class ContextMenuItemTest
    {
        /// <summary>
        /// Unit tests for class initialization
        /// </summary>
        public class Initializer
        {
            /// <summary>
            /// Test to ensure success under normal operation.
            /// </summary>
            [Test]
            [Category("ShouldSucceed")]
            public void ShouldSucceed()
            {
                var testCommand = new ReactiveCommand();
                const string Label = "Label";
                const string ToolTip = "Tooltip";

                var instance = new Dhgms.Whipstaff.Model.ControlData.SystemNotificationArea.ContextMenuItem()
                {
                    Command = testCommand,
                    Label = Label,
                    ToolTip = ToolTip
                };

                Assert.AreEqual(testCommand, instance.Command);
                Assert.AreEqual(Label, instance.Label);
                Assert.AreEqual(ToolTip, instance.ToolTip);
            }
        }
    }
}
