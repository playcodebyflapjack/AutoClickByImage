using AutoClickByImage.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClickByImage
{
    public partial class ImageForm : Form
    {

        public ItemImage itemImage;

        public ImageForm(string showMode, ItemImage itemImage)
        {
            InitializeComponent();

            this.buttonConfirm.Text = showMode;
            this.labelValueOrderId.Text = itemImage.orderId.ToString();
            this.itemImage = itemImage;

            this.comboBoxModeClick.Items.AddRange(new object[] {
            Messages.MESSAGE_SINGLE_MODE_CLICK,
            Messages.MESSAGE_MULTI_MODE_CLICK});

            if (showMode == "Add")
            {
                this.comboBoxModeClick.SelectedIndex = 0;
            }
            else
            {
                this.textBoxPathFileImage.Text = itemImage.pathFileImage;
                this.comboBoxModeClick.SelectedItem = itemImage.modeClick;
            }

        }
 

        private void buttonOpenFileImage_Click(object sender, EventArgs e)
        {
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                string filepathImage = openFileDialogImage.FileName;

                this.textBoxPathFileImage.Text = filepathImage;

            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.itemImage.orderId       = itemImage.orderId;
            this.itemImage.pathFileImage = textBoxPathFileImage.Text;
            this.itemImage.modeClick     = comboBoxModeClick.SelectedItem.ToString();
        }
 
    }
}
