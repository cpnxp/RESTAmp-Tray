using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RESTAmpLib;
using System.ServiceModel.Web;


namespace RESTAmpTray
{
    public partial class RESTAmpTray : Form
    {
        RESTAmp RESTAmpService;
        WebServiceHost RESTAmpHost;
        
        public RESTAmpTray()
        {
            InitializeComponent();
            RESTAmpService = new RESTAmp();
            RESTAmpHost = new WebServiceHost(RESTAmpService, new Uri("http://localhost:8000/restamp"));
            RESTAmpHost.Open();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RESTAmpHost.Close();
            this.Close();
            Application.Exit();
        }
    }
}
