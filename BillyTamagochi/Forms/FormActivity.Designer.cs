
namespace BillyTamagochi.Forms
{
    partial class FormActivity
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
            this.activityImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.activityImage)).BeginInit();
            this.SuspendLayout();
            // 
            // activityImage
            // 
            this.activityImage.BackColor = System.Drawing.Color.Black;
            this.activityImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityImage.Image = global::BillyTamagochi.Properties.Resources.IMAGEAsleep;
            this.activityImage.Location = new System.Drawing.Point(0, 0);
            this.activityImage.Name = "activityImage";
            this.activityImage.Size = new System.Drawing.Size(466, 352);
            this.activityImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.activityImage.TabIndex = 2;
            this.activityImage.TabStop = false;
            // 
            // FormActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 352);
            this.Controls.Add(this.activityImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormActivity";
            ((System.ComponentModel.ISupportInitialize)(this.activityImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox activityImage;
    }
}