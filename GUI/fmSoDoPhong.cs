using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmSoDoPhong : Form
    {
        public fmSoDoPhong()
        {
            InitializeComponent();
        }

        private void fmSoDoPhong_Load(object sender, EventArgs e)
        {



            List<Tang> ltTang = new List<Tang>();


            Phong p1 = new Phong("Đã đặt", "101","101");
            Phong p2 = new Phong("Trống", "102","102");
            Phong p3 = new Phong("Đã đặt", "103","103");
            Phong p4 = new Phong("Đã đặt", "104","104");
            Phong p5 = new Phong("Trống", "105","105");
            List<Phong> ltp1 = new List<Phong>();
            ltp1.Add(p1);
            ltp1.Add(p2);
            ltp1.Add(p3);
            ltp1.Add(p4);
            ltp1.Add(p5);
            Tang t1 = new Tang("100","Tầng 1", ltp1);


            Phong p12 = new Phong("Đã nhận", "201", "201");
            Phong p22 = new Phong("Đã đặt", "202", "202");
            Phong p32 = new Phong("Trống", "203", "203");
            Phong p42 = new Phong("Trống", "204", "204");
            Phong p52 = new Phong("Đã đặt", "205", "205");
            List<Phong> ltp2 = new List<Phong>();
            ltp2.Add(p12);
            ltp2.Add(p22);
            ltp2.Add(p32);
            ltp2.Add(p42);
            ltp2.Add(p52);
            Tang t2 = new Tang("200", "Tầng 2", ltp2);

            ltTang.Add(t1);
            ltTang.Add(t2);



            foreach (Tang t in ltTang)
            {
                Panel pnTang = new Panel();
                //if (j % 2 == 0)
                //{
                //    pnTang.BackColor = Color.FromArgb(255, 255, 255);
                //}
                //else
                //{
                //    pnTang.BackColor = Color.FromArgb(204, 204, 204);
                //}

                pnTang.BackColor = Color.FromArgb(204, 204, 204);
                pnTang.Dock = DockStyle.Top;
                pnTang.Size = new System.Drawing.Size(231, 182);

                Panel pnTitle = new Panel();
                pnTitle.Dock = DockStyle.Left;
                pnTitle.Size = new Size(120, 182);
                pnTang.Controls.Add(pnTitle);

                Label lbTang = new Label();
                lbTang.Anchor = System.Windows.Forms.AnchorStyles.None;
                lbTang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbTang.Name = "lnTang";

                int x = (int)((pnTitle.Width / 2) - (lbTang.Width / 2));
                int y = (int)((pnTitle.Height / 2) - lbTang.Height / 2);

                lbTang.Location = new Point(x, y);

                lbTang.AutoSize = true;
                lbTang.Text = t.TenTang;

                pnTitle.Controls.Add(lbTang);


                Panel pnPhong = new Panel();

                pnPhong.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
                pnPhong.Size = new System.Drawing.Size((pnTang.Width - pnTitle.Width), 282);
                pnPhong.Location = new Point(pnTitle.Width, 0);


                FlowLayoutPanel flpPhong = new FlowLayoutPanel();

                flpPhong.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
                flpPhong.AutoScroll = true;

                flpPhong.Location = new System.Drawing.Point(0, 0);
                flpPhong.Size = new System.Drawing.Size(pnPhong.Width, 210);
                flpPhong.WrapContents = false;


                foreach (Phong p in t.LtPhong)
                {

                    ucPhong uc = new ucPhong();

                    Button btn = new Button();

                    btn.Size = new Size(180, 165);
                    btn.Text = p.TenPhong;
                    btn.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                    if(p.TrangThai.Equals("Đã nhận"))
                        btn.BackColor = System.Drawing.Color.Red;
                    else if (p.TrangThai.Equals("Đã đặt"))
                        btn.BackColor = System.Drawing.Color.Gray;
                    else
                        btn.BackColor = System.Drawing.Color.Green;

                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn.ForeColor = System.Drawing.Color.White;
                    btn.ImageIndex = 0;
                    btn.ImageList = this.imageList1;
                    btn.Location = new System.Drawing.Point(589, 3);
                    btn.TabIndex = 6;
                    btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                    btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                    btn.UseVisualStyleBackColor = false;
                    btn.Cursor = System.Windows.Forms.Cursors.Hand;

                    flpPhong.Controls.Add(btn);
                    
                }


                pnPhong.Controls.Add(flpPhong);

                pnTang.Controls.Add(pnPhong);
                panel1.Controls.Add(pnTang);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
