using System.Drawing;
using System.Windows.Forms;

namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            lblCarID = new Label();
            txtCarName = new TextBox();
            txtPrice = new MaskedTextBox();
            cboManufacturer = new ComboBox();
            btnSave = new Button();
            lblCarName = new Label();
            lblManufacturer = new Label();
            lblPrice = new Label();
            lblReleaseYear = new Label();
            txtReleaseYear = new MaskedTextBox();
            txtCarID = new TextBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblCarID
            // 
            lblCarID.AutoSize = true;
            lblCarID.Location = new Point(94, 103);
            lblCarID.Name = "lblCarID";
            lblCarID.Size = new Size(39, 15);
            lblCarID.TabIndex = 0;
            lblCarID.Text = "Car ID";
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(195, 148);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(200, 23);
            txtCarName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(195, 243);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 2;
            txtPrice.Text = "0";
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford ", "Honda", "Huyndai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(195, 197);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(200, 23);
            cboManufacturer.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(129, 372);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Location = new Point(94, 151);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(60, 15);
            lblCarName.TabIndex = 5;
            lblCarName.Text = "Car Name";
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(94, 200);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(79, 15);
            lblManufacturer.TabIndex = 6;
            lblManufacturer.Text = "Manufacturer";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(94, 246);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price";
            // 
            // lblReleaseYear
            // 
            lblReleaseYear.AutoSize = true;
            lblReleaseYear.Location = new Point(94, 293);
            lblReleaseYear.Name = "lblReleaseYear";
            lblReleaseYear.Size = new Size(78, 15);
            lblReleaseYear.TabIndex = 8;
            lblReleaseYear.Text = "Released Year";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(195, 290);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(200, 23);
            txtReleaseYear.TabIndex = 9;
            txtReleaseYear.Text = "0";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(195, 100);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(200, 23);
            txtCarID.TabIndex = 10;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(274, 372);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 445);
            Controls.Add(btnCancel);
            Controls.Add(txtCarID);
            Controls.Add(txtReleaseYear);
            Controls.Add(lblReleaseYear);
            Controls.Add(lblPrice);
            Controls.Add(lblManufacturer);
            Controls.Add(lblCarName);
            Controls.Add(btnSave);
            Controls.Add(cboManufacturer);
            Controls.Add(txtPrice);
            Controls.Add(txtCarName);
            Controls.Add(lblCarID);
            Name = "frmCarDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCarID;
        private TextBox txtCarName;
        private MaskedTextBox txtPrice;
        private ComboBox cboManufacturer;
        private Button btnSave;
        private Label lblCarName;
        private Label lblManufacturer;
        private Label lblPrice;
        private Label lblReleaseYear;
        private MaskedTextBox txtReleaseYear;
        private TextBox txtCarID;
        private Button btnCancel;
    }
}