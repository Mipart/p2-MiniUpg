using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniUppgiftF
{
    public partial class ApartmentComplexCreator : Form
    {
        Apartment apart;
        bool isChecked = false;

        public ApartmentComplexCreator(int apartmentNumber)
        {
            InitializeComponent();
            lblApartmentNumber.Text = apartmentNumber.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int numberOfRooms;
            bool r = int.TryParse(txtNumberOfRooms.Text, out numberOfRooms);

            bool status = radioStatus.Checked;

            if (r)
            {
                apart = new Apartment(numberOfRooms, status);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        public Apartment GetApartment()
        {
            return apart;
        }


        private void radioStatus_Click(object sender, EventArgs e)
        {
            if (radioStatus.Checked && !isChecked)
                radioStatus.Checked = false;
            else
            {
                radioStatus.Checked = true;
                isChecked = false;
            }
        }

        private void radioStatus_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = radioStatus.Checked;
        }
    }
}
