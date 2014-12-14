using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shell;
using NLog;

namespace Dhgms.Whipstaff.Desktop.Helper
{
    public abstract class JumpListHelper
    {
        private readonly Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public void Initialize(Application applicationContext)
        {
            Contract.Requires<ArgumentNullException>(applicationContext != null, "applicationContext");

            var cmdPath = Assembly.GetEntryAssembly().Location;
            var jumpItems = this.GetCustomJumpItems(cmdPath);

            var jumpList = JumpList.GetJumpList(applicationContext);
            if (jumpList == null)
            {
                this.logger.Info("No jump list registered. Creating a new one");
                jumpList = new JumpList(jumpItems, true, true);

                // do we need this?
                JumpList.SetJumpList(applicationContext, jumpList);
            }
            else
            {
            }

            jumpList.JumpItemsRejected += JumpListOnJumpItemsRejected;
            jumpList.JumpItemsRemovedByUser += JumpListOnJumpItemsRemovedByUser;
            jumpList.Apply();
        }

        protected abstract void OnJumpItemsRemovedByUser(JumpItemsRemovedEventArgs jumpItemsRemovedEventArgs);

        protected abstract void OnJumpItemsRejected(JumpItemsRejectedEventArgs jumpItemsRejectedEventArgs);

        protected abstract IEnumerable<JumpItem> GetCustomJumpItems(string cmdPath);

        private void JumpListOnJumpItemsRejected(object sender, JumpItemsRejectedEventArgs jumpItemsRejectedEventArgs)
        {
            this.logger.Warn("Jump List Items Rejected : " + jumpItemsRejectedEventArgs);
            this.OnJumpItemsRejected(jumpItemsRejectedEventArgs);
        }

        private void JumpListOnJumpItemsRemovedByUser(object sender, JumpItemsRemovedEventArgs jumpItemsRemovedEventArgs)
        {
            this.logger.Warn("Jump List Items Removed by user : " + jumpItemsRemovedEventArgs);
            this.OnJumpItemsRemovedByUser(jumpItemsRemovedEventArgs);
        }
    }
}
