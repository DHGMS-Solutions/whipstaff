namespace Dhgms.Whipstaff.Tests.Model.ControlData.StatusBar
{
    using System.Windows.Input;

    using NUnit.Framework;

    /// <summary>
    /// Unit Test for the Status Bar Item
    /// </summary>
    public class StatusBarItemTest
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
                ICommand testCommand = null;
                const string Label = "Label";
                const string ToolTip = "Tooltip";

                var instance = new Dhgms.Whipstaff.Model.ControlData.StatusBar.StatusBarItem()
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
