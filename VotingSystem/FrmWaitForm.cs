using System;
using System.Threading.Tasks;

namespace VotingSystem
{
    public partial class FrmWaitForm : MetroFramework.Forms.MetroForm
    {
        public Action Worker { get; set; }
        public FrmWaitForm(Action worker)
        {
            InitializeComponent();
            if(worker == null)
                throw new ArgumentNullException();
            Worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker)
                .ContinueWith(t => { Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
