using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiniUppgiftF
{
    public partial class Form1 : Form
    {
        List<ApartmentComplex> ac = new List<ApartmentComplex>();

        
        public Form1()
        {
            InitializeComponent();
        }

        //Updaterar Comboboxen med de olika complexerna i.
        void UpdateCbx()
        {
            cbxApartmentComplex.Items.Clear();
            for (int i = 0; i < ac.Count; i++)
            {
                cbxApartmentComplex.Items.Add("Complex " + i + 1);
            }
        }

        //Updaterar listboxen så att man får fram info om lägenheterna.
        void UpdateLbx()
        {
            lbxApartmens.Items.Clear();
            List<string> s = ac[cbxApartmentComplex.SelectedIndex].GetApartmentns();
            foreach (string item in s)
            {
                lbxApartmens.Items.Add(item);
            }
        }

        //Skapar ett nytt komplex med lägenheter
        void CreateComplex()
        {
            ac.Add(new ApartmentComplex());
            UpdateCbx();
        }

        //Byter status på den markerade lägenheten
        void ChangeStatus()
        {
            try
            {
                ac[cbxApartmentComplex.SelectedIndex].ChangeApartmentStatus(lbxApartmens.SelectedIndex);
                UpdateLbx();
            }
            catch (Exception e)
            {
                MessageBox.Show("No Apartment selected!\n\n" + e,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        void UpdateInfo()
        {
            lblApartmentNum.Text = $"Apartment : {lbxApartmens.SelectedIndex + 1}";
        }

        //Events

        private void menuItemNewApartmentComplex_Click(object sender, EventArgs e)
        {
            CreateComplex();
        }

        private void cbxApartmentComplex_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLbx();
        }

        private void lbxApartmens_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            ChangeStatus();
        }
    }
}
