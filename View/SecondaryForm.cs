using Order_Management.Database;
using System.Windows.Forms;

namespace Order_Management
{
    public partial class SecondaryForm : Form
    {
        public int id_order;
        public string status;
        public bool isComment;
        public int id;
        public int quantity;

        public SecondaryForm()
        {
            InitializeComponent();
        }

        private void SecondaryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isComment)
            {
                Services.UpdateService(id, quantity, tbxArea.Text);
            }
            else
            {
                Info.AddInfo(id_order, status, tbxArea.Text);
            }
        }
    }
}
