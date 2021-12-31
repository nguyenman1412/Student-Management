using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panel_svSubMenu.Visible = false;
            panel_DiemSubMenu.Visible = false;
            panel_KhSubMenu.Visible = false;
        }



        private void AnSubMenu()
        {
            if (panel_svSubMenu.Visible == true)
                panel_svSubMenu.Visible = false;
            if (panel_KhSubMenu.Visible == true)
                panel_KhSubMenu.Visible = false;
            if (panel_DiemSubMenu.Visible == true)
                panel_DiemSubMenu.Visible = false;
        }

        private void HienSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                AnSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button_sv_Click(object sender, EventArgs e)
        {
            HienSubMenu(panel_svSubMenu);
        }

        #region svSubMenu
        private void button_dk_Click(object sender, EventArgs e)
        {
            //..code
            AnSubMenu();
        }

        private void button_qlsv_Click(object sender, EventArgs e)
        {
            //..code
            AnSubMenu();
        }

        private void button_ttsv_Click(object sender, EventArgs e)
        {
            //..code
            AnSubMenu();
        }

        private void button_insv_Click(object sender, EventArgs e)
        {
            //..code
            AnSubMenu();
        }
        #endregion svSubMenu
        private void button_kh_Click(object sender, EventArgs e)
        {
            HienSubMenu(panel_KhSubMenu);
        }

        #region khSubMenu
        private void button_khm_Click(object sender, EventArgs e)
        {
            //..code
            AnSubMenu();
        }

        private void button_qlkh_Click(object sender, EventArgs e)
        {
            //..code
            AnSubMenu();
        }

        private void button_inkh_Click(object sender, EventArgs e)
        {
            //..code
            AnSubMenu();
        }
        #endregion khSubMenu
        private void button_diem_Click(object sender, EventArgs e)
        {
            HienSubMenu(panel_DiemSubMenu);
        }
        #region diemSubMenu
        private void button_nhapdiem_Click(object sender, EventArgs e)
        {
            //..code
            AnSubMenu();
        }

        private void button_qldiem_Click(object sender, EventArgs e)
        {
            //..code
            AnSubMenu();
        }

        private void button_indiem_Click(object sender, EventArgs e)
        {
            //..code
            AnSubMenu();
        }


        #endregion diemSubMenu


     
    }
}
