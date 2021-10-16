
namespace AutoClickByImage
{
    partial class MainForm
    { 
        /// <summary>
        /// Required designer variable.
        /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.findFileAdb = new System.Windows.Forms.OpenFileDialog();
            this.buttonopenfileadb = new System.Windows.Forms.Button();
            this.txtBoxPathADB = new System.Windows.Forms.TextBox();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewItemImage = new System.Windows.Forms.DataGridView();
            this.BtnAddImage = new System.Windows.Forms.Button();
            this.BtnRemoveImage = new System.Windows.Forms.Button();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelthreshold = new System.Windows.Forms.Label();
            this.numericUpDownThreshold = new System.Windows.Forms.NumericUpDown();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathFileImageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeClickDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemImageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemImageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(423, 34);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Enabled = false;
            this.buttonEnd.Location = new System.Drawing.Point(423, 81);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(75, 23);
            this.buttonEnd.TabIndex = 1;
            this.buttonEnd.Text = "End";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.button2_Click);
            // 
            // findFileAdb
            // 
            this.findFileAdb.FileName = "findFileAdb";
            // 
            // buttonopenfileadb
            // 
            this.buttonopenfileadb.Location = new System.Drawing.Point(12, 32);
            this.buttonopenfileadb.Name = "buttonopenfileadb";
            this.buttonopenfileadb.Size = new System.Drawing.Size(68, 24);
            this.buttonopenfileadb.TabIndex = 2;
            this.buttonopenfileadb.Text = "Browse";
            this.buttonopenfileadb.UseVisualStyleBackColor = true;
            this.buttonopenfileadb.Click += new System.EventHandler(this.buttonopenfileadb_Click);
            // 
            // txtBoxPathADB
            // 
            this.txtBoxPathADB.Location = new System.Drawing.Point(86, 32);
            this.txtBoxPathADB.Multiline = true;
            this.txtBoxPathADB.Name = "txtBoxPathADB";
            this.txtBoxPathADB.ReadOnly = true;
            this.txtBoxPathADB.Size = new System.Drawing.Size(293, 24);
            this.txtBoxPathADB.TabIndex = 3;
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(86, 78);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(172, 21);
            this.comboBoxDevices.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Device";
            // 
            // dataGridViewItemImage
            // 
            this.dataGridViewItemImage.AllowUserToAddRows = false;
            this.dataGridViewItemImage.AutoGenerateColumns = false;
            this.dataGridViewItemImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.pathFileImageDataGridViewTextBoxColumn,
            this.modeClickDataGridViewTextBoxColumn});
            this.dataGridViewItemImage.DataSource = this.itemImageBindingSource1;
            this.dataGridViewItemImage.Location = new System.Drawing.Point(18, 222);
            this.dataGridViewItemImage.MultiSelect = false;
            this.dataGridViewItemImage.Name = "dataGridViewItemImage";
            this.dataGridViewItemImage.ReadOnly = true;
            this.dataGridViewItemImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItemImage.Size = new System.Drawing.Size(361, 203);
            this.dataGridViewItemImage.TabIndex = 8;
            // 
            // BtnAddImage
            // 
            this.BtnAddImage.Location = new System.Drawing.Point(417, 222);
            this.BtnAddImage.Name = "BtnAddImage";
            this.BtnAddImage.Size = new System.Drawing.Size(81, 23);
            this.BtnAddImage.TabIndex = 9;
            this.BtnAddImage.Text = "Add";
            this.BtnAddImage.UseVisualStyleBackColor = true;
            this.BtnAddImage.Click += new System.EventHandler(this.BtnAddImage_Click);
            // 
            // BtnRemoveImage
            // 
            this.BtnRemoveImage.Location = new System.Drawing.Point(417, 265);
            this.BtnRemoveImage.Name = "BtnRemoveImage";
            this.BtnRemoveImage.Size = new System.Drawing.Size(81, 23);
            this.BtnRemoveImage.TabIndex = 10;
            this.BtnRemoveImage.Text = "Remove";
            this.BtnRemoveImage.UseVisualStyleBackColor = true;
            this.BtnRemoveImage.Click += new System.EventHandler(this.BtnRemoveImage_Click);
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(188, 69);
            this.pictureBoxDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisplay.TabIndex = 11;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxDisplay);
            this.groupBox1.Location = new System.Drawing.Point(18, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 99);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Image";
            // 
            // labelthreshold
            // 
            this.labelthreshold.AutoSize = true;
            this.labelthreshold.Location = new System.Drawing.Point(224, 162);
            this.labelthreshold.Name = "labelthreshold";
            this.labelthreshold.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelthreshold.Size = new System.Drawing.Size(54, 13);
            this.labelthreshold.TabIndex = 13;
            this.labelthreshold.Text = "Threshold";
            // 
            // numericUpDownThreshold
            // 
            this.numericUpDownThreshold.DecimalPlaces = 2;
            this.numericUpDownThreshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownThreshold.Location = new System.Drawing.Point(284, 160);
            this.numericUpDownThreshold.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownThreshold.Name = "numericUpDownThreshold";
            this.numericUpDownThreshold.Size = new System.Drawing.Size(95, 20);
            this.numericUpDownThreshold.TabIndex = 15;
            this.numericUpDownThreshold.Value = new decimal(new int[] {
            90,
            0,
            0,
            131072});
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "orderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "Order Id";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pathFileImageDataGridViewTextBoxColumn
            // 
            this.pathFileImageDataGridViewTextBoxColumn.DataPropertyName = "pathFileImage";
            this.pathFileImageDataGridViewTextBoxColumn.HeaderText = "File Image";
            this.pathFileImageDataGridViewTextBoxColumn.Name = "pathFileImageDataGridViewTextBoxColumn";
            this.pathFileImageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeClickDataGridViewTextBoxColumn
            // 
            this.modeClickDataGridViewTextBoxColumn.DataPropertyName = "modeClick";
            this.modeClickDataGridViewTextBoxColumn.HeaderText = "Mode Click";
            this.modeClickDataGridViewTextBoxColumn.Name = "modeClickDataGridViewTextBoxColumn";
            this.modeClickDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemImageBindingSource1
            // 
            this.itemImageBindingSource1.DataSource = typeof(AutoClickByImage.model.ItemImage);
            // 
            // itemImageBindingSource
            // 
            this.itemImageBindingSource.DataSource = typeof(AutoClickByImage.model.ItemImage);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 446);
            this.Controls.Add(this.numericUpDownThreshold);
            this.Controls.Add(this.labelthreshold);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnRemoveImage);
            this.Controls.Add(this.BtnAddImage);
            this.Controls.Add(this.dataGridViewItemImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDevices);
            this.Controls.Add(this.txtBoxPathADB);
            this.Controls.Add(this.buttonopenfileadb);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "AutoClickByImage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonStart;
    private System.Windows.Forms.Button buttonEnd;
    private System.Windows.Forms.OpenFileDialog findFileAdb;
    private System.Windows.Forms.Button buttonopenfileadb;
    private System.Windows.Forms.TextBox txtBoxPathADB;
    private System.Windows.Forms.ComboBox comboBoxDevices;
    private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource itemImageBindingSource;
        private System.Windows.Forms.BindingSource itemImageBindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewItemImage;
        private System.Windows.Forms.Button BtnAddImage;
        private System.Windows.Forms.Button BtnRemoveImage;
        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelthreshold;
        private System.Windows.Forms.NumericUpDown numericUpDownThreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathFileImageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeClickDataGridViewTextBoxColumn;
    }
}

