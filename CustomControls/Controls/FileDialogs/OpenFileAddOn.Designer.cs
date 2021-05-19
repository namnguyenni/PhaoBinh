using devDept.Controls.WinForms.Win32Types;

namespace devDept.Controls.WinForms
{
    partial class OpenFileAddOn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.geomAndTessRb = new System.Windows.Forms.RadioButton();
            this.tessellationRb = new System.Windows.Forms.RadioButton();
            this.geometryRb = new System.Windows.Forms.RadioButton();
            this.contentGroupBox = new System.Windows.Forms.GroupBox();
            this.thumbPicBox = new System.Windows.Forms.PictureBox();
            this.txtFileInfo = new System.Windows.Forms.TextBox();
            this.contentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // geomAndTessRb
            // 
            this.geomAndTessRb.AutoSize = true;
            this.geomAndTessRb.Location = new System.Drawing.Point(10, 65);
            this.geomAndTessRb.Name = "geomAndTessRb";
            this.geomAndTessRb.Size = new System.Drawing.Size(150, 17);
            this.geomAndTessRb.TabIndex = 13;
            this.geomAndTessRb.TabStop = true;
            this.geomAndTessRb.Text = "Geometry and Tessellation";
            this.geomAndTessRb.UseVisualStyleBackColor = true;
            this.geomAndTessRb.CheckedChanged += new System.EventHandler(this.geomAndTessRb_CheckedChanged);
            // 
            // tessellationRb
            // 
            this.tessellationRb.AutoSize = true;
            this.tessellationRb.Location = new System.Drawing.Point(10, 42);
            this.tessellationRb.Name = "tessellationRb";
            this.tessellationRb.Size = new System.Drawing.Size(81, 17);
            this.tessellationRb.TabIndex = 12;
            this.tessellationRb.TabStop = true;
            this.tessellationRb.Text = "Tessellation";
            this.tessellationRb.UseVisualStyleBackColor = true;
            this.tessellationRb.CheckedChanged += new System.EventHandler(this.tessellationRb_CheckedChanged);
            // 
            // geometryRb
            // 
            this.geometryRb.AutoSize = true;
            this.geometryRb.Location = new System.Drawing.Point(10, 19);
            this.geometryRb.Name = "geometryRb";
            this.geometryRb.Size = new System.Drawing.Size(70, 17);
            this.geometryRb.TabIndex = 11;
            this.geometryRb.TabStop = true;
            this.geometryRb.Text = "Geometry";
            this.geometryRb.UseVisualStyleBackColor = true;
            this.geometryRb.CheckedChanged += new System.EventHandler(this.geometryRb_CheckedChanged);
            // 
            // contentGroupBox
            // 
            this.contentGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.contentGroupBox.Controls.Add(this.geometryRb);
            this.contentGroupBox.Controls.Add(this.geomAndTessRb);
            this.contentGroupBox.Controls.Add(this.tessellationRb);
            this.contentGroupBox.Location = new System.Drawing.Point(3, 421);
            this.contentGroupBox.Name = "contentGroupBox";
            this.contentGroupBox.Size = new System.Drawing.Size(256, 95);
            this.contentGroupBox.TabIndex = 14;
            this.contentGroupBox.TabStop = false;
            this.contentGroupBox.Text = "Content";
            // 
            // thumbPicBox
            // 
            this.thumbPicBox.BackColor = System.Drawing.Color.White;
            this.thumbPicBox.Location = new System.Drawing.Point(3, 36);
            this.thumbPicBox.Name = "thumbPicBox";
            this.thumbPicBox.Size = new System.Drawing.Size(256, 256);
            this.thumbPicBox.TabIndex = 15;
            this.thumbPicBox.TabStop = false;
            // 
            // txtFileInfo
            // 
            this.txtFileInfo.BackColor = System.Drawing.SystemColors.Control;
            this.txtFileInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileInfo.Location = new System.Drawing.Point(3, 298);
            this.txtFileInfo.Multiline = true;
            this.txtFileInfo.Name = "txtFileInfo";
            this.txtFileInfo.Size = new System.Drawing.Size(256, 117);
            this.txtFileInfo.TabIndex = 16;
            // 
            // OpenFileAddOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFileInfo);
            this.Controls.Add(this.thumbPicBox);
            this.Controls.Add(this.contentGroupBox);
            this.FileDlgCaption = "Open";
            this.Name = "OpenFileAddOn";
            this.Size = new System.Drawing.Size(266, 524);
            this.contentGroupBox.ResumeLayout(false);
            this.contentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton geomAndTessRb;
        private System.Windows.Forms.RadioButton tessellationRb;
        private System.Windows.Forms.RadioButton geometryRb;
        private System.Windows.Forms.PictureBox thumbPicBox;
        public System.Windows.Forms.GroupBox contentGroupBox;
        private System.Windows.Forms.TextBox txtFileInfo;
    }
}
