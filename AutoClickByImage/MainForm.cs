using AutoClickByImage.model;
using System;
using System.Drawing;
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

        private int indexImage;
        private int indexOrderId;


        public MainForm()
        {
            InitializeComponent();
            this.serviceSearchImage = new SearchImage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewItemImage.ClearSelection();

        }

        private async void button1_Click(object sender, EventArgs e)
        {


            string device = this.comboBoxDevices.SelectedItem != null ? comboBoxDevices.SelectedItem.ToString() : "";

            if (string.IsNullOrEmpty(device))
            {
                MessageBox.Show(
                    Messages.ERROR_MESSAGE_PATH_IP_DEVICE_NOT_FOUND,
                    Messages.ERROR_MESSAGE_TITLE);
                return;
            }


            disableComponent();


            _canceller = new CancellationTokenSource();

        
            double threshold = ((double)numericUpDownThreshold.Value);
            int sizeBindingSource = itemImageBindingSource1.Count;
            indexImage = 0;

            try
            {

                await Task.Run(async () =>
                {
                    do
                    {

                        if (dataGridViewItemImage.RowCount > 0)
                        {
                            itemImageBindingSource1.Position = indexImage;

                            ItemImage item =  (ItemImage)itemImageBindingSource1.Current;

                            Bitmap imageShow = new Bitmap(item.pathFileImage);

                            Console.WriteLine(item.pathFileImage);

                            pictureBoxDisplay.Image = imageShow;

                            bool clickIconGame = false;

                            if (Messages.MESSAGE_SINGLE_MODE_CLICK.Equals(item.modeClick))
                            {
                                clickIconGame = await serviceADB.SingleClickByImage(device, item.pathFileImage, threshold);
                            }
                            else 
                            {
                                clickIconGame = await serviceADB.MutiClickByImage(device, item.pathFileImage, threshold);
                            }

                           
                            if (clickIconGame)
                            {
                                indexImage++;
                            }

                        }

                       
                        if (_canceller.Token.IsCancellationRequested || indexImage == sizeBindingSource)
                        {
                            break;
                        }
      

                    } while (true);
                });



                _canceller.Dispose();
                pictureBoxDisplay.Dispose();

                enableComponent();

            }
            catch (Exception error)
            {
                throw error;
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

                this.txtBoxPathADB.Text = fullFilePathADB;

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
            ItemImage itemImage = new ItemImage();
            
            itemImage.orderId = (indexOrderId + 1) ;

            using (ImageForm imageform = new ImageForm("Add", itemImage))
            {
                if (imageform.ShowDialog() == DialogResult.OK)
                {
                    itemImageBindingSource1.Add(imageform.itemImage);
                    indexOrderId++;
                }
            }

        }

        private void BtnRemoveImage_Click(object sender, EventArgs e)
        {
            if (itemImageBindingSource1.Current != null)
            {
                itemImageBindingSource1.RemoveCurrent();
            }
          
        }


        private void disableComponent()
        {
            buttonStart.Enabled = false;
            buttonEnd.Enabled = true;

            buttonopenfileadb.Enabled = false;
            comboBoxDevices.Enabled = false;
            numericUpDownThreshold.Enabled = false;
            BtnAddImage.Enabled = false;
            BtnRemoveImage.Enabled = false;
        }

        private void enableComponent()
        {
            buttonStart.Enabled = true;
            buttonEnd.Enabled = false;

            buttonopenfileadb.Enabled = true;
            comboBoxDevices.Enabled = true;
            numericUpDownThreshold.Enabled = true;
            BtnAddImage.Enabled = true;
            BtnRemoveImage.Enabled = true;
        }
    }
}
