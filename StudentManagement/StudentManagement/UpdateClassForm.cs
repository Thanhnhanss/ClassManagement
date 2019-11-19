using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class UpdateClassForm : Form
    {
        private int ClassId;
        private ClassManagement Business;
        public UpdateClassForm(int id)
        {
            InitializeComponent();
            this.ClassId = id;
            this.Business = new ClassManagement();
            this.btnsave.Click += btnsave_Click;
            this.btncancel.Click += btncancel_Click;
            this.Load += UpdateClassForm_Load;
        }

        void UpdateClassForm_Load(object sender, EventArgs e)
        {
            var @class = this.Business.GetClass(this.ClassId);
            this.txtname.Text = @class.Name;
            this.txtdescription.Text = @class.Description;
        }

        void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnsave_Click(object sender, EventArgs e)
        {
            var name = this.txtname.Text;
            var description = this.txtdescription.Text;
            this.Business.EditClass(this.ClassId, name, description);
            MessageBox.Show(" update class successfully.");
            this.Close();
        }
    }
}
