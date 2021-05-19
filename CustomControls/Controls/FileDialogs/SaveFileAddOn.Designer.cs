namespace devDept.Controls.WinForms
{
    partial class SaveFileAddOn
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
            this.compressCb = new System.Windows.Forms.CheckBox();
            this.contentGb = new System.Windows.Forms.GroupBox();
            this.geometryRb = new System.Windows.Forms.RadioButton();
            this.geomAndTessRb = new System.Windows.Forms.RadioButton();
            this.tessellationRb = new System.Windows.Forms.RadioButton();
            this.selectedOnlyCb = new System.Windows.Forms.CheckBox();
            this.purgeCb = new System.Windows.Forms.CheckBox();
            this.contentGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // compressCb
            // 
            this.compressCb.AutoSize = true;
            this.compressCb.Location = new System.Drawing.Point(15, 355);
            this.compressCb.Name = "compressCb";
            this.compressCb.Size = new System.Drawing.Size(91, 17);
            this.compressCb.TabIndex = 9;
            this.compressCb.Text = "Compress File";
            this.compressCb.UseVisualStyleBackColor = true;
            this.compressCb.CheckedChanged += new System.EventHandler(this.compressCb_CheckedChanged);
            // 
            // contentGb
            // 
            this.contentGb.Controls.Add(this.geometryRb);
            this.contentGb.Controls.Add(this.geomAndTessRb);
            this.contentGb.Controls.Add(this.tessellationRb);
            this.contentGb.Location = new System.Drawing.Point(5, 255);
            this.contentGb.Name = "contentGb";
            this.contentGb.Size = new System.Drawing.Size(180, 95);
            this.contentGb.TabIndex = 15;
            this.contentGb.TabStop = false;
            this.contentGb.Text = "Content";
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
            // selectedOnlyCb
            // 
            this.selectedOnlyCb.AutoSize = true;
            this.selectedOnlyCb.Location = new System.Drawing.Point(15, 207);
            this.selectedOnlyCb.Name = "selectedOnlyCb";
            this.selectedOnlyCb.Size = new System.Drawing.Size(92, 17);
            this.selectedOnlyCb.TabIndex = 16;
            this.selectedOnlyCb.Text = "Selected Only";
            this.selectedOnlyCb.UseVisualStyleBackColor = true;
            this.selectedOnlyCb.CheckedChanged += new System.EventHandler(this.selectedOnlyCb_CheckedChanged);
            // 
            // purgeCb
            // 
            this.purgeCb.AutoSize = true;
            this.purgeCb.Location = new System.Drawing.Point(15, 230);
            this.purgeCb.Name = "purgeCb";
            this.purgeCb.Size = new System.Drawing.Size(54, 17);
            this.purgeCb.TabIndex = 17;
            this.purgeCb.Text = "Purge";
            this.purgeCb.UseVisualStyleBackColor = true;
            this.purgeCb.CheckedChanged += new System.EventHandler(this.purgeCb_CheckedChanged);
            // 
            // SaveFileAddOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.purgeCb);
            this.Controls.Add(this.selectedOnlyCb);
            this.Controls.Add(this.contentGb);
            this.Controls.Add(this.compressCb);
            this.FileDlgType = devDept.Controls.WinForms.Win32Types.FileDialogType.SaveFileDlg;
            this.Name = "SaveFileAddOn";
            this.Size = new System.Drawing.Size(190, 385);
            this.contentGb.ResumeLayout(false);
            this.contentGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox compressCb;
        private System.Windows.Forms.GroupBox contentGb;
        private System.Windows.Forms.RadioButton geometryRb;
        private System.Windows.Forms.RadioButton geomAndTessRb;
        private System.Windows.Forms.RadioButton tessellationRb;
        private System.Windows.Forms.CheckBox selectedOnlyCb;
        private System.Windows.Forms.CheckBox purgeCb;
    }
}
