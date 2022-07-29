using Order_Management.Database;
using Order_Management.Properties;
using System;
using System.Windows.Forms;

namespace Order_Management.View.SettingsForms
{
    public partial class InterfaceForm : Form
    {
        public InterfaceForm()
        {
            InitializeComponent();

            chbxWindowMax.Checked = Settings.Default.chbxWindowsMax == FormWindowState.Maximized;

            cbxShop.DataSource = Shops.LoadShops();
            cbxShop.DisplayMember = "shop";
            cbxShop.ValueMember = "id";
            cbxShop.SelectedValue = Settings.Default.defaultShop;
        }

        private void chbxWindowMax_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.chbxWindowsMax = chbxWindowMax.Checked ? FormWindowState.Maximized : FormWindowState.Normal;
            Settings.Default.Save();
        }

        private void cbxShop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Settings.Default.defaultShop = Convert.ToInt32(cbxShop.SelectedValue);
            Settings.Default.Save();
        }
    }
}
