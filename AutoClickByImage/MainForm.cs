using AutoClickByImage.exception;
using AutoClickByImage.model;
using AutoClickByImage.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AutoClickByImage
{
    public partial class MainForm : Form
    {

        private CancellationTokenSource _canceller;
        private ShellADBCLI serviceADB;
        private SearchImage serviceSearchImage;
        private ScreenCapture serviceWindowsClick;
        private ManagementClickWindows serviceMangementClickWindows;

        private int indexImage;
        private int indexOrderId;


        public MainForm()
        {
            InitializeComponent();
            this.serviceSearchImage = new SearchImage();
            this.serviceWindowsClick = new ScreenCapture();
            this.serviceMangementClickWindows = new ManagementClickWindows(serviceWindowsClick, serviceSearchImage);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewItemImage.ClearSelection();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
          
            string target = string.Empty;
            int errorTarget = -1; 

            if (radioButtonProcess.Checked)
            {
                target = this.comboBoxProcess.SelectedIndex.ToString();
                errorTarget = 1;
            }

            if (radioButtonADB.Checked)
            {
                target = this.comboBoxDevices.SelectedIndex.ToString();
                errorTarget = 2;
            }

            if (string.IsNullOrEmpty(target))
            {
                if (errorTarget == 1)
                {
                    MessageBox.Show(
                       Messages.ERROR_MESSAGE_TARGET_WINDOW_NOT_FOUND,
                       Messages.ERROR_MESSAGE_TITLE);
                }
                else
                {
                    MessageBox.Show(
                       Messages.ERROR_MESSAGE_PATH_IP_DEVICE_NOT_FOUND,
                       Messages.ERROR_MESSAGE_TITLE);
                }
                    return;
            }

            disableComponent();

            _canceller = new CancellationTokenSource();

            int sizeBindingSource = itemImageBindingSource1.Count;
            indexImage = 0;

                await Task.Run(async () =>
                {
                    do
                    {
                        try
                        {

                            if (dataGridViewItemImage.RowCount > 0)
                            {
                                itemImageBindingSource1.Position = indexImage;

                                ItemImage item = (ItemImage)itemImageBindingSource1.Current;

                                Bitmap imageShow = new Bitmap(item.pathFileImage);


                                pictureBoxDisplay.Image = imageShow;

                                bool isClick = false;

                                if (radioButtonProcess.Checked)
                                {
                                    isClick = clickWindows(target, item);
                                }
                                else
                                {
                                    isClick = await clickAdbAsync(target, item);
                                }


                                if (isClick)
                                {
                                    indexImage++;
                                }

                            }


                            if (_canceller.Token.IsCancellationRequested || indexImage == sizeBindingSource)
                            {
                                break;
                            }

                        }
                        catch (OpenCvException error)
                        {
                             MessageBox.Show(
                       Messages.ERROR_MESSAGE_CHANGE_PROCESS,
                       Messages.ERROR_MESSAGE_TITLE);
                            break;
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                            Console.WriteLine(error.Message);
                        }

                       

                    } while (true);
                });

                _canceller.Dispose();

                enableComponent();
        }

        private bool clickWindows(string target, ItemImage item)
        {
            string image = item.pathFileImage;
            double threshold = item.threshold;
            ItemProcess itemSelectProcess = getValueComboBoxProcess();
            IntPtr handle = itemSelectProcess.valueHandle;

            return serviceMangementClickWindows.SingleClickByImage(handle, image, threshold, this.checkBoxDebugimage.Checked);
        }

        private ItemProcess getValueComboBoxProcess()
        {
            if (comboBoxProcess.InvokeRequired)
                return (ItemProcess)comboBoxProcess.Invoke(new Func<ItemProcess>(getValueComboBoxProcess));
            else
                return (ItemProcess)comboBoxProcess.SelectedItem ;
        }


        private async Task<bool> clickAdbAsync(string target,ItemImage item )
        {
            string image = item.pathFileImage;
            double threshold = item.threshold;

            if (Messages.MESSAGE_SINGLE_MODE_CLICK.Equals(item.modeClick))
            {
                return await serviceADB.SingleClickByImage(target, image, threshold, this.checkBoxDebugimage.Checked);
            }
            else
            {
                return await serviceADB.MutiClickByImage(target, image, threshold, this.checkBoxDebugimage.Checked);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                _canceller.Cancel();
        }

        private async void buttonopenfileadb_Click(object sender, EventArgs e)
        {

            if (findFileAdb.ShowDialog() == DialogResult.OK)
            {
                string fullFilePathADB = findFileAdb.FileName;
                this.serviceADB = new ShellADBCLI(fullFilePathADB, serviceSearchImage);
                string[] listOfDevices = await serviceADB.GetListOfIp();

                this.comboBoxDevices.Items.Clear();

                foreach (string device in listOfDevices)
                {
                    this.comboBoxDevices.Items.Add(device);
                }

            }
        }

        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            ItemImage itemImage = new ItemImage
            {
                orderId = (indexOrderId + 1)
            };

            using (ImageForm imageform = new ImageForm("Add", itemImage))
            {
                if (imageform.ShowDialog() == DialogResult.OK)
                {
                    itemImageBindingSource1.Add(imageform.itemImage);
                    indexOrderId++;
                }
            }

        }

        private void dataGridViewItemImage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            ItemImage itemSelected = (ItemImage)itemImageBindingSource1[e.RowIndex];

            using (ImageForm imageform = new ImageForm("Edit", itemSelected))
            {
                if (imageform.ShowDialog() == DialogResult.OK)
                {
                    dataGridViewItemImage.Update();
                    dataGridViewItemImage.Refresh();         
                }
            }
        }

        private void BtnRemoveImage_Click(object sender, EventArgs e)
        {
            if (itemImageBindingSource1.Current != null)
            {
                itemImageBindingSource1.RemoveCurrent();
                dataGridViewItemImage.Update();
                dataGridViewItemImage.Refresh();
            }
          
        }


        private void disableComponent()
        {
            buttonStart.Enabled = false;
            buttonEnd.Enabled = true;

            buttonopenfileadb.Enabled = false;
            comboBoxDevices.Enabled = false;
        
            BtnAddImage.Enabled = false;
            BtnRemoveImage.Enabled = false;
        }

        private void enableComponent()
        {
            buttonStart.Enabled = true;
            buttonEnd.Enabled = false;

            buttonopenfileadb.Enabled = true;
            comboBoxDevices.Enabled = true;
          
            BtnAddImage.Enabled = true;
            BtnRemoveImage.Enabled = true;
        }

        private void radioButtonADB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonADB.Checked)
            {
                comboBoxProcess.Items.Clear();
                comboBoxProcess.ResetText();
              

                comboBoxDevices.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxProcess.DropDownStyle = ComboBoxStyle.DropDownList;


                buttonopenfileadb.Enabled = true;
            }
        }

        private void radioButtonProcess_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonProcess.Checked)
            {
                buttonopenfileadb.Enabled = false;
                comboBoxProcess.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxDevices.DropDownStyle = ComboBoxStyle.DropDownList;

                comboBoxProcess.Items.Clear();
                ItemProcess[] listProcess = serviceWindowsClick.getListProcess();
                comboBoxProcess.Items.AddRange(listProcess);

                if (listProcess.Length > 0)
                {
                    comboBoxProcess.SelectedIndex = 0;
                }

            }
        }

       
    
    }
}
