﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDiyet.UI
{
    public partial class AdminPanel : Form
    {
        AdminAdditionalData AdminAdditionalData = new AdminAdditionalData();
        public AdminPanel()
        {
            InitializeComponent();
            ShowPanelControl(AdminAdditionalData);

        }

        private void ShowPanelControl(UserControl userControl)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void lblEkDegisimler_Click(object sender, EventArgs e)
        {
            ShowPanelControl(AdminAdditionalData);
        }

        private void pbOgunEkle_Click(object sender, EventArgs e)
        {
            ShowPanelControl(AdminAdditionalData);
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tŞuan admin panelindesiniz.\n\nBu panelde Öğün-Kategori-Besin-Besin Değeri üzerinde ekleme, silme, güncelleştime yapabilirsiniz.\nAnalizleri görüntüleyebilirsiniz.\n\n\tHIS saygılarla sunar. ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblDietAppA_Click(object sender, EventArgs e)
        {

        }

        private void lblBesinEkle_Click(object sender, EventArgs e)
        {
            AdminAddNutrition adminAddNutrition = new AdminAddNutrition();
            ShowPanelControl(adminAddNutrition);
        }

        private void pbBesinEkle_Click(object sender, EventArgs e)
        {
            AdminAddNutrition adminAddNutrition = new AdminAddNutrition();
            ShowPanelControl(adminAddNutrition);
        }
    }
}
