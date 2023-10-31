using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wf = System.Windows.Forms;
using Autodesk.Navisworks.Api;
using Autodesk.Navisworks.Api.Clash;
using Autodesk.Navisworks.Api.Plugins;

namespace NavisResultViewer {
    [PluginAttribute("ResultViewer", "Hyuni & Dotman", DisplayName = "ResultViewer", ToolTip = "halloween")]
    public class MainClass : AddInPlugin {


        public override int Execute(params string[] parameters) {
            ShowMessage("ResultViewer Clicked");
            return 0;
        }

        void ShowMessage(string content) {
            wf.MessageBox.Show(content);
        }
    }


}
