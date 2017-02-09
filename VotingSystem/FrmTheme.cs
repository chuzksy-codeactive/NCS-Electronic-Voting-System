using System;
using MetroFramework;

namespace VotingSystem
{
    public partial class FrmTheme : MetroFramework.Forms.MetroForm
    {
        FrmIndex frm = new FrmIndex();
        public FrmTheme()
        {
            InitializeComponent();
        }

        private void FrmTheme_Load(object sender, EventArgs e)
        {

        }

        private void metroTileSytle_Click(object sender, EventArgs e)
        {
            var m = new Random();
            var next = m.Next(0, 13);
            frm.msmIndex.Style = (MetroColorStyle)next;
            StyleManager = frm.msmIndex;
        }

        private void metroTileSwitch_Click(object sender, EventArgs e)
        {
            frm.msmIndex.Theme = frm.msmIndex.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
            StyleManager = frm.msmIndex;
        }
    }
}
