using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class fmThanhToan : Form
    {
        public fmThanhToan()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fmThanhToan_Load(object sender, EventArgs e)
        {
            flPhong.Controls.Clear();

            ComponentResourceManager resources = new ComponentResourceManager(typeof(fmThanhToan));
            for (int i=0;i< 16; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.Red;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.White;
                btn.Image = ((Image)(resources.GetObject("button2.Image")));
                btn.Location = new Point(202, 3);
                btn.Name = "button2";
                btn.Size = new Size(193, 173);
                btn.TabIndex = 1;
                btn.Text = "Phòng 102";
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.TextImageRelation = TextImageRelation.ImageAboveText;
                btn.UseVisualStyleBackColor = false;

                flPhong.Controls.Add(btn);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //xuất hóa hơn
        }
    }
}
