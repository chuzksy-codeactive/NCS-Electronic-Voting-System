
using System;
using System.Windows.Forms;

namespace VotingSystem.UserControlSlides
{
    public partial class PnlMenu : pnlSlider
    {
        private Form _owner = null;
        public event EventHandler LogOff;
        public event EventHandler Exit;
        public PnlMenu(Form owner) : base(owner)
        {
            InitializeComponent();
            _owner = owner;
        }

        private void metroTile2_Click(object sender, System.EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, System.EventArgs e)
        {

        }
    }
}
