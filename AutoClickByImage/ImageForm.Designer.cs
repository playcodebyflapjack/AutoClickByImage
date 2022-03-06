
namespace AutoClickByImage
{
    partial class ImageForm
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
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenFileImage = new System.Windows.Forms.Button();
            this.textBoxPathFileImage = new System.Windows.Forms.TextBox();
            this.labelModeClick = new System.Windows.Forms.Label();
            this.labelOrderId = new System.Windows.Forms.Label();
            this.labelValueOrderId = new System.Windows.Forms.Label();
            this.comboBoxModeClick = new System.Windows.Forms.ComboBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.numericUpDownThreshold = new System.Windows.Forms.NumericUpDown();
            this.labelthreshold = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialogImage";
            // 
            // buttonOpenFileImage
            // 
            this.buttonOpenFileImage.Location = new System.Drawing.Point(12, 60);
            this.buttonOpenFileImage.Name = "buttonOpenFileImage";
            this.buttonOpenFileImage.Size = new System.Drawing.Size(91, 23);
            this.buttonOpenFileImage.TabIndex = 0;
            this.buttonOpenFileImage.Text = "Browse File";
            this.buttonOpenFileImage.UseVisualStyleBackColor = true;
            this.buttonOpenFileImage.Click += new System.EventHandler(this.buttonOpenFileImage_Click);
            // 
            // textBoxPathFileImage
            // 
            this.textBoxPathFileImage.Location = new System.Drawing.Point(109, 61);
            this.textBoxPathFileImage.Multiline = true;
            this.textBoxPathFileImage.Name = "textBoxPathFileImage";
            this.textBoxPathFileImage.ReadOnly = true;
            this.textBoxPathFileImage.Size = new System.Drawing.Size(258, 22);
            this.textBoxPathFileImage.TabIndex = 1;
            // 
            // labelModeClick
            // 
            this.labelModeClick.AutoSize = true;
            this.labelModeClick.Location = new System.Drawing.Point(25, 101);
            this.labelModeClick.Name = "labelModeClick";
            this.labelModeClick.Size = new System.Drawing.Size(60, 13);
            this.labelModeClick.TabIndex = 2;
            this.labelModeClick.Text = "Mode Click";
            // 
            // labelOrderId
            // 
            this.labelOrderId.AutoSize = true;
            this.labelOrderId.Location = new System.Drawing.Point(25, 23);
            this.labelOrderId.Name = "labelOrderId";
            this.labelOrderId.Size = new System.Drawing.Size(45, 13);
            this.labelOrderId.TabIndex = 3;
            this.labelOrderId.Text = "Order Id";
            // 
            // labelValueOrderId
            // 
            this.labelValueOrderId.AutoSize = true;
            this.labelValueOrderId.Location = new System.Drawing.Point(106, 23);
            this.labelValueOrderId.Name = "labelValueOrderId";
            this.labelValueOrderId.Size = new System.Drawing.Size(0, 13);
            this.labelValueOrderId.TabIndex = 4;
            // 
            // comboBoxModeClick
            // 
            this.comboBoxModeClick.FormattingEnabled = true;
            this.comboBoxModeClick.Location = new System.Drawing.Point(109, 98);
            this.comboBoxModeClick.Name = "comboBoxModeClick";
            this.comboBoxModeClick.Size = new System.Drawing.Size(140, 21);
            this.comboBoxModeClick.TabIndex = 5;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonConfirm.Location = new System.Drawing.Point(109, 178);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(92, 22);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(222, 178);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 21);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // numericUpDownThreshold
            // 
            this.numericUpDownThreshold.DecimalPlaces = 2;
            this.numericUpDownThreshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownThreshold.Location = new System.Drawing.Point(109, 132);
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
            this.numericUpDownThreshold.TabIndex = 17;
            this.numericUpDownThreshold.Value = new decimal(new int[] {
            90,
            0,
            0,
            131072});
            // 
            // labelthreshold
            // 
            this.labelthreshold.AutoSize = true;
            this.labelthreshold.Location = new System.Drawing.Point(28, 134);
            this.labelthreshold.Name = "labelthreshold";
            this.labelthreshold.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelthreshold.Size = new System.Drawing.Size(54, 13);
            this.labelthreshold.TabIndex = 16;
            this.labelthreshold.Text = "Threshold";
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 212);
            this.Controls.Add(this.numericUpDownThreshold);
            this.Controls.Add(this.labelthreshold);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.comboBoxModeClick);
            this.Controls.Add(this.labelValueOrderId);
            this.Controls.Add(this.labelOrderId);
            this.Controls.Add(this.labelModeClick);
            this.Controls.Add(this.textBoxPathFileImage);
            this.Controls.Add(this.buttonOpenFileImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ImageForm";
            this.Text = "Item Image";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Button buttonOpenFileImage;
        private System.Windows.Forms.TextBox textBoxPathFileImage;
        private System.Windows.Forms.Label labelModeClick;
        private System.Windows.Forms.Label labelOrderId;
        private System.Windows.Forms.Label labelValueOrderId;
        private System.Windows.Forms.ComboBox comboBoxModeClick;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDownThreshold;
        private System.Windows.Forms.Label labelthreshold;
    }
}