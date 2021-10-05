
namespace EffectCreator {
    partial class frmMain {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbEffectGroups = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewEffectGroup = new System.Windows.Forms.Button();
            this.btnOpenEffectGroup = new System.Windows.Forms.Button();
            this.btnDeleteEffectGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEffectGroups
            // 
            this.lbEffectGroups.FormattingEnabled = true;
            this.lbEffectGroups.Location = new System.Drawing.Point(12, 28);
            this.lbEffectGroups.Name = "lbEffectGroups";
            this.lbEffectGroups.Size = new System.Drawing.Size(120, 95);
            this.lbEffectGroups.TabIndex = 0;
            this.lbEffectGroups.SelectedIndexChanged += new System.EventHandler(this.lbEffectGroups_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Effect Groups";
            // 
            // btnNewEffectGroup
            // 
            this.btnNewEffectGroup.Enabled = false;
            this.btnNewEffectGroup.Location = new System.Drawing.Point(15, 130);
            this.btnNewEffectGroup.Name = "btnNewEffectGroup";
            this.btnNewEffectGroup.Size = new System.Drawing.Size(75, 23);
            this.btnNewEffectGroup.TabIndex = 2;
            this.btnNewEffectGroup.Text = "New";
            this.btnNewEffectGroup.UseVisualStyleBackColor = true;
            // 
            // btnOpenEffectGroup
            // 
            this.btnOpenEffectGroup.Enabled = false;
            this.btnOpenEffectGroup.Location = new System.Drawing.Point(15, 160);
            this.btnOpenEffectGroup.Name = "btnOpenEffectGroup";
            this.btnOpenEffectGroup.Size = new System.Drawing.Size(75, 23);
            this.btnOpenEffectGroup.TabIndex = 3;
            this.btnOpenEffectGroup.Text = "Open";
            this.btnOpenEffectGroup.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEffectGroup
            // 
            this.btnDeleteEffectGroup.Enabled = false;
            this.btnDeleteEffectGroup.Location = new System.Drawing.Point(15, 190);
            this.btnDeleteEffectGroup.Name = "btnDeleteEffectGroup";
            this.btnDeleteEffectGroup.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEffectGroup.TabIndex = 4;
            this.btnDeleteEffectGroup.Text = "Delete";
            this.btnDeleteEffectGroup.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteEffectGroup);
            this.Controls.Add(this.btnOpenEffectGroup);
            this.Controls.Add(this.btnNewEffectGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEffectGroups);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEffectGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewEffectGroup;
        private System.Windows.Forms.Button btnOpenEffectGroup;
        private System.Windows.Forms.Button btnDeleteEffectGroup;
    }
}