using BLL;
using DTO;
using GUI.UserControls;
using System;
using System.Collections.Generic;

namespace GUI
{
    public partial class fmChonThemPhong : DevExpress.XtraEditors.XtraForm
    {
        private readonly List<tb_Phong> PhongExcepts;
        private readonly List<tb_Phong> PhongSelecteds;

        public fmChonThemPhong(List<tb_Phong> phongSelecteds, List<tb_Phong> phongExcepts)
        {
            InitializeComponent();
            PhongSelecteds = phongSelecteds;
            PhongExcepts = phongExcepts;
        }

        private void FmChonThemPhong_Load(object sender, EventArgs e)
        {
            LoadUI(PhongSelecteds, PhongExcepts);
        }

        private void LoadUI(List<tb_Phong> phongSelecteds, List<tb_Phong> phongExcepts)
        {
            var lstTangLau = TangLauBLL.GetFloors();

            foreach (var tangLau in lstTangLau)
            {
                var ucTang = new UcTangLau(tangLau, phongSelecteds, phongExcepts);
                ucTang.Parent = pnlContainer;
                ucTang.Width = ucTang.Parent.Width - 50;
                pnlContainer.Controls.Add(ucTang);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}