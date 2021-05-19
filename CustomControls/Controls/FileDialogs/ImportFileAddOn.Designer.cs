namespace devDept.Controls.WinForms
{
    partial class ImportFileAddOn
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
            this.yAxisUpCb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // yAxisUpCb
            // 
            this.yAxisUpCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yAxisUpCb.AutoSize = true;
            this.yAxisUpCb.Location = new System.Drawing.Point(15, 350);
            this.yAxisUpCb.Name = "yAxisUpCb";
            this.yAxisUpCb.Size = new System.Drawing.Size(135, 17);
            this.yAxisUpCb.TabIndex = 15;
            this.yAxisUpCb.Text = "Geometry in \'Y Axis Up\'";
            this.yAxisUpCb.UseVisualStyleBackColor = true;
            this.yAxisUpCb.CheckedChanged += new System.EventHandler(this.yAxisUpCb_CheckedChanged);
            // 
            // ImportFileAddOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.yAxisUpCb);
            this.FileDlgCaption = "Import";
            this.Name = "ImportFileAddOn";
            this.Size = new System.Drawing.Size(190, 385);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox yAxisUpCb;
    }
}
