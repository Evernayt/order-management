using Order_Management.Database;
using System.Drawing;
using System.Windows.Forms;

namespace Order_Management
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.25F);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9.25F);
        }

        public void LoadData(int id_order)
        {
            dataGridView1.DataSource = Info.LoadInfo(id_order);
        }

        private void InfoForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                Close();
        }
    }
}
