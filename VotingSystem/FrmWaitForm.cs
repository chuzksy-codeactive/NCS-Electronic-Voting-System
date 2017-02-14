using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class FrmWaitForm : MetroFramework.Forms.MetroForm
    {
        public BackgroundWorker Worker { get; set; }
        public FrmWaitForm(Form form)
        {
            InitializeComponent();
        }

        private void FrmWaitForm_Load(object sender, EventArgs e)
        {

        }
    }
}
