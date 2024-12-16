using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mario
{
    public partial class begin : Form
    {
        public begin()
        {
            InitializeComponent();
        }
        private void begin_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.nen, 0, 0);
        }

        private void EnterName(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            if(cmb_Subject.Items.Count <= 0)
            {
                List<SubjectBus> list = SubjectBus.listSubjects();
                foreach(SubjectBus item in list)
                {
                    cmb_Subject.Items.Add(item);
                }
            }
        }

        private void subbox_Click(object sender, EventArgs e)
        {

        }
    }
}
