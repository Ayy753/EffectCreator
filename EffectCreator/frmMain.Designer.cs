
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDeleteEffectGroup = new System.Windows.Forms.Button();
            this.btnNewEffectGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEffectGroups = new System.Windows.Forms.ListBox();
            this.ucEffectGroup1 = new EffectCreator.ucEffectGroup();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteEffectGroup);
            this.splitContainer1.Panel1.Controls.Add(this.btnNewEffectGroup);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lbEffectGroups);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucEffectGroup1);
            this.splitContainer1.Size = new System.Drawing.Size(709, 436);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDeleteEffectGroup
            // 
            this.btnDeleteEffectGroup.Enabled = false;
            this.btnDeleteEffectGroup.Location = new System.Drawing.Point(15, 159);
            this.btnDeleteEffectGroup.Name = "btnDeleteEffectGroup";
            this.btnDeleteEffectGroup.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEffectGroup.TabIndex = 9;
            this.btnDeleteEffectGroup.Text = "Delete";
            this.btnDeleteEffectGroup.UseVisualStyleBackColor = true;
            // 
            // btnNewEffectGroup
            // 
            this.btnNewEffectGroup.Enabled = false;
            this.btnNewEffectGroup.Location = new System.Drawing.Point(15, 130);
            this.btnNewEffectGroup.Name = "btnNewEffectGroup";
            this.btnNewEffectGroup.Size = new System.Drawing.Size(75, 23);
            this.btnNewEffectGroup.TabIndex = 7;
            this.btnNewEffectGroup.Text = "New";
            this.btnNewEffectGroup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Effect Groups";
            // 
            // lbEffectGroups
            // 
            this.lbEffectGroups.FormattingEnabled = true;
            this.lbEffectGroups.Location = new System.Drawing.Point(12, 28);
            this.lbEffectGroups.Name = "lbEffectGroups";
            this.lbEffectGroups.Size = new System.Drawing.Size(120, 95);
            this.lbEffectGroups.TabIndex = 5;
            this.lbEffectGroups.SelectedIndexChanged += new System.EventHandler(this.lbEffectGroups_SelectedIndexChanged);
            // 
            // ucEffectGroup1
            // 
            this.ucEffectGroup1.Location = new System.Drawing.Point(3, 3);
            this.ucEffectGroup1.Name = "ucEffectGroup1";
            this.ucEffectGroup1.Size = new System.Drawing.Size(554, 428);
            this.ucEffectGroup1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 436);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDeleteEffectGroup;
        private System.Windows.Forms.Button btnNewEffectGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbEffectGroups;
        private ucEffectGroup ucEffectGroup1;
    }
}