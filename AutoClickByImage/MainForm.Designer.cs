
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
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.dataGridViewItemImage = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathFileImageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeClickDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.threshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemImageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BtnAddImage = new System.Windows.Forms.Button();
            this.BtnRemoveImage = new System.Windows.Forms.Button();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxTarget = new System.Windows.Forms.GroupBox();
            this.comboBoxProcess = new System.Windows.Forms.ComboBox();
            this.radioButtonProcess = new System.Windows.Forms.RadioButton();
            this.radioButtonADB = new System.Windows.Forms.RadioButton();
            this.itemImageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxDebugimage = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxTarget.SuspendLayout();
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
            this.buttonopenfileadb.Location = new System.Drawing.Point(249, 22);
            this.buttonopenfileadb.Name = "buttonopenfileadb";
            this.buttonopenfileadb.Size = new System.Drawing.Size(68, 22);
            this.buttonopenfileadb.TabIndex = 2;
            this.buttonopenfileadb.Text = "Browse";
            this.buttonopenfileadb.UseVisualStyleBackColor = true;
            this.buttonopenfileadb.Click += new System.EventHandler(this.buttonopenfileadb_Click);
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(71, 23);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(172, 21);
            this.comboBoxDevices.TabIndex = 4;
            // 
            // dataGridViewItemImage
            // 
            this.dataGridViewItemImage.AllowUserToAddRows = false;
            this.dataGridViewItemImage.AutoGenerateColumns = false;
            this.dataGridViewItemImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.pathFileImageDataGridViewTextBoxColumn,
            this.modeClickDataGridViewTextBoxColumn,
            this.threshold});
            this.dataGridViewItemImage.DataSource = this.itemImageBindingSource1;
            this.dataGridViewItemImage.Location = new System.Drawing.Point(18, 226);
            this.dataGridViewItemImage.MultiSelect = false;
            this.dataGridViewItemImage.Name = "dataGridViewItemImage";
            this.dataGridViewItemImage.ReadOnly = true;
            this.dataGridViewItemImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItemImage.Size = new System.Drawing.Size(361, 203);
            this.dataGridViewItemImage.TabIndex = 8;
            this.dataGridViewItemImage.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItemImage_CellDoubleClick);
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
            // threshold
            // 
            this.threshold.DataPropertyName = "threshold";
            this.threshold.HeaderText = "Threshold";
            this.threshold.Name = "threshold";
            this.threshold.ReadOnly = true;
            // 
            // itemImageBindingSource1
            // 
            this.itemImageBindingSource1.DataSource = typeof(AutoClickByImage.model.ItemImage);
            // 
            // BtnAddImage
            // 
            this.BtnAddImage.Location = new System.Drawing.Point(417, 226);
            this.BtnAddImage.Name = "BtnAddImage";
            this.BtnAddImage.Size = new System.Drawing.Size(81, 23);
            this.BtnAddImage.TabIndex = 9;
            this.BtnAddImage.Text = "Add";
            this.BtnAddImage.UseVisualStyleBackColor = true;
            this.BtnAddImage.Click += new System.EventHandler(this.BtnAddImage_Click);
            // 
            // BtnRemoveImage
            // 
            this.BtnRemoveImage.Location = new System.Drawing.Point(417, 269);
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
            this.groupBox1.Location = new System.Drawing.Point(18, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 99);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Image";
            // 
            // groupBoxTarget
            // 
            this.groupBoxTarget.Controls.Add(this.comboBoxProcess);
            this.groupBoxTarget.Controls.Add(this.radioButtonProcess);
            this.groupBoxTarget.Controls.Add(this.radioButtonADB);
            this.groupBoxTarget.Controls.Add(this.comboBoxDevices);
            this.groupBoxTarget.Controls.Add(this.buttonopenfileadb);
            this.groupBoxTarget.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTarget.Name = "groupBoxTarget";
            this.groupBoxTarget.Size = new System.Drawing.Size(367, 92);
            this.groupBoxTarget.TabIndex = 16;
            this.groupBoxTarget.TabStop = false;
            this.groupBoxTarget.Text = "Target";
            // 
            // comboBoxProcess
            // 
            this.comboBoxProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcess.FormattingEnabled = true;
            this.comboBoxProcess.Location = new System.Drawing.Point(71, 57);
            this.comboBoxProcess.Name = "comboBoxProcess";
            this.comboBoxProcess.Size = new System.Drawing.Size(172, 21);
            this.comboBoxProcess.TabIndex = 8;
            // 
            // radioButtonProcess
            // 
            this.radioButtonProcess.AutoSize = true;
            this.radioButtonProcess.Location = new System.Drawing.Point(6, 57);
            this.radioButtonProcess.Name = "radioButtonProcess";
            this.radioButtonProcess.Size = new System.Drawing.Size(63, 17);
            this.radioButtonProcess.TabIndex = 7;
            this.radioButtonProcess.Text = "Process";
            this.radioButtonProcess.UseVisualStyleBackColor = true;
            this.radioButtonProcess.CheckedChanged += new System.EventHandler(this.radioButtonProcess_CheckedChanged);
            // 
            // radioButtonADB
            // 
            this.radioButtonADB.AutoSize = true;
            this.radioButtonADB.Checked = true;
            this.radioButtonADB.Location = new System.Drawing.Point(6, 25);
            this.radioButtonADB.Name = "radioButtonADB";
            this.radioButtonADB.Size = new System.Drawing.Size(59, 17);
            this.radioButtonADB.TabIndex = 6;
            this.radioButtonADB.TabStop = true;
            this.radioButtonADB.Text = "Device";
            this.radioButtonADB.UseVisualStyleBackColor = true;
            this.radioButtonADB.CheckedChanged += new System.EventHandler(this.radioButtonADB_CheckedChanged);
            // 
            // itemImageBindingSource
            // 
            this.itemImageBindingSource.DataSource = typeof(AutoClickByImage.model.ItemImage);
            // 
            // checkBoxDebugimage
            // 
            this.checkBoxDebugimage.AutoSize = true;
            this.checkBoxDebugimage.Location = new System.Drawing.Point(233, 129);
            this.checkBoxDebugimage.Name = "checkBoxDebugimage";
            this.checkBoxDebugimage.Size = new System.Drawing.Size(87, 17);
            this.checkBoxDebugimage.TabIndex = 17;
            this.checkBoxDebugimage.Text = "debug image";
            this.checkBoxDebugimage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 437);
            this.Controls.Add(this.checkBoxDebugimage);
            this.Controls.Add(this.groupBoxTarget);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnRemoveImage);
            this.Controls.Add(this.BtnAddImage);
            this.Controls.Add(this.dataGridViewItemImage);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "AutoClickByImage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxTarget.ResumeLayout(false);
            this.groupBoxTarget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemImageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonStart;
    private System.Windows.Forms.Button buttonEnd;
    private System.Windows.Forms.OpenFileDialog findFileAdb;
    private System.Windows.Forms.Button buttonopenfileadb;
    private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.BindingSource itemImageBindingSource;
        private System.Windows.Forms.BindingSource itemImageBindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewItemImage;
        private System.Windows.Forms.Button BtnAddImage;
        private System.Windows.Forms.Button BtnRemoveImage;
        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathFileImageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeClickDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxTarget;
        private System.Windows.Forms.ComboBox comboBoxProcess;
        private System.Windows.Forms.RadioButton radioButtonProcess;
        private System.Windows.Forms.RadioButton radioButtonADB;
        private System.Windows.Forms.DataGridViewTextBoxColumn threshold;
        private System.Windows.Forms.CheckBox checkBoxDebugimage;
    }
}

