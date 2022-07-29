using System;
using System.Windows.Forms;

namespace Order_Management.UserControls
{
    public partial class ucUpdater : UserControl
    {
        public bool restart = false;

        public ucUpdater()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (restart)
                Application.Restart();

            Hide();
        }
    }
}
