using System;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class EmployeeForm : Form
    {
        public string EmployeeID
        {
            get { return txtMSNV.Text; }
            set { txtMSNV.Text = value; }
        }

        public string EmployeeName
        {
            get { return txtTenNV.Text; }
            set { txtTenNV.Text = value; }
        }

        public string Salary
        {
            get { return txtLuongCB.Text; }
            set { txtLuongCB.Text = value; }
        }

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // Optional: Logic khi form tải
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmployeeID) || string.IsNullOrWhiteSpace(EmployeeName) || string.IsNullOrWhiteSpace(Salary))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
