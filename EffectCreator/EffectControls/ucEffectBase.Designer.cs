
namespace EffectCreator.EffectControls {
    partial class ucEffectBase {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblEffectName = new System.Windows.Forms.Label();
            this.txtEffectType = new System.Windows.Forms.TextBox();
            this.txtEffectName = new System.Windows.Forms.TextBox();
            this.lblEffectType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEffectName
            // 
            this.lblEffectName.AutoSize = true;
            this.lblEffectName.Location = new System.Drawing.Point(0, 38);
            this.lblEffectName.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblEffectName.Name = "lblEffectName";
            this.lblEffectName.Padding = new System.Windows.Forms.Padding(5);
            this.lblEffectName.Size = new System.Drawing.Size(76, 23);
            this.lblEffectName.TabIndex = 47;
            this.lblEffectName.Text = "Effect Name";
            // 
            // txtEffectType
            // 
            this.txtEffectType.Enabled = false;
            this.txtEffectType.Location = new System.Drawing.Point(100, 6);
            this.txtEffectType.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtEffectType.Name = "txtEffectType";
            this.txtEffectType.Size = new System.Drawing.Size(121, 20);
            this.txtEffectType.TabIndex = 46;
            // 
            // txtEffectName
            // 
            this.txtEffectName.Location = new System.Drawing.Point(100, 39);
            this.txtEffectName.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtEffectName.Name = "txtEffectName";
            this.txtEffectName.Size = new System.Drawing.Size(121, 20);
            this.txtEffectName.TabIndex = 45;
            this.txtEffectName.Validating += new System.ComponentModel.CancelEventHandler(this.txtEffectName_Validating);
            // 
            // lblEffectType
            // 
            this.lblEffectType.AutoSize = true;
            this.lblEffectType.Location = new System.Drawing.Point(0, 5);
            this.lblEffectType.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblEffectType.Name = "lblEffectType";
            this.lblEffectType.Padding = new System.Windows.Forms.Padding(5);
            this.lblEffectType.Size = new System.Drawing.Size(72, 23);
            this.lblEffectType.TabIndex = 44;
            this.lblEffectType.Text = "Effect Type";
            this.lblEffectType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucEffectBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEffectName);
            this.Controls.Add(this.txtEffectType);
            this.Controls.Add(this.txtEffectName);
            this.Controls.Add(this.lblEffectType);
            this.Name = "ucEffectBase";
            this.Size = new System.Drawing.Size(225, 250);
            this.Load += new System.EventHandler(this.ucEffectBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEffectName;
        private System.Windows.Forms.Label lblEffectType;
        protected System.Windows.Forms.TextBox txtEffectType;
        protected System.Windows.Forms.TextBox txtEffectName;
    }
}
