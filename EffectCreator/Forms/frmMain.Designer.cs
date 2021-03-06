
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucEffectGroup1 = new EffectCreator.ucEffectGroup();
            this.btnDuplicate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDuplicate);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteEffectGroup);
            this.splitContainer1.Panel1.Controls.Add(this.btnNewEffectGroup);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lbEffectGroups);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucEffectGroup1);
            this.splitContainer1.Size = new System.Drawing.Size(979, 537);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDeleteEffectGroup
            // 
            this.btnDeleteEffectGroup.Location = new System.Drawing.Point(5, 467);
            this.btnDeleteEffectGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteEffectGroup.Name = "btnDeleteEffectGroup";
            this.btnDeleteEffectGroup.Size = new System.Drawing.Size(189, 28);
            this.btnDeleteEffectGroup.TabIndex = 3;
            this.btnDeleteEffectGroup.Text = "Delete";
            this.btnDeleteEffectGroup.UseVisualStyleBackColor = true;
            this.btnDeleteEffectGroup.Click += new System.EventHandler(this.btnDeleteEffectGroup_Click);
            // 
            // btnNewEffectGroup
            // 
            this.btnNewEffectGroup.Location = new System.Drawing.Point(5, 431);
            this.btnNewEffectGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewEffectGroup.Name = "btnNewEffectGroup";
            this.btnNewEffectGroup.Size = new System.Drawing.Size(189, 28);
            this.btnNewEffectGroup.TabIndex = 2;
            this.btnNewEffectGroup.Text = "New";
            this.btnNewEffectGroup.UseVisualStyleBackColor = true;
            this.btnNewEffectGroup.Click += new System.EventHandler(this.btnNewEffectGroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Effect Groups";
            // 
            // lbEffectGroups
            // 
            this.lbEffectGroups.FormattingEnabled = true;
            this.lbEffectGroups.ItemHeight = 16;
            this.lbEffectGroups.Location = new System.Drawing.Point(4, 71);
            this.lbEffectGroups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbEffectGroups.Name = "lbEffectGroups";
            this.lbEffectGroups.Size = new System.Drawing.Size(188, 356);
            this.lbEffectGroups.TabIndex = 1;
            this.lbEffectGroups.SelectedIndexChanged += new System.EventHandler(this.lbEffectGroups_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(198, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.saveToolStripMenuItem.Text = "Save                CTLR+S";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.saveAsToolStripMenuItem.Text = "Save As           CTRL+ALT+S";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.openToolStripMenuItem.Text = "Open               CTRL+O";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.newToolStripMenuItem.Text = "New                CTRL+N";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.exitToolStripMenuItem.Text = "Exit                 CTRL+X";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ucEffectGroup1
            // 
            this.ucEffectGroup1.Location = new System.Drawing.Point(0, -1);
            this.ucEffectGroup1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucEffectGroup1.Name = "ucEffectGroup1";
            this.ucEffectGroup1.Size = new System.Drawing.Size(776, 537);
            this.ucEffectGroup1.TabIndex = 0;
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Location = new System.Drawing.Point(5, 503);
            this.btnDuplicate.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(189, 28);
            this.btnDuplicate.TabIndex = 7;
            this.btnDuplicate.Text = "Duplicate";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDuplicate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 537);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Effect Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDeleteEffectGroup;
        private System.Windows.Forms.Button btnNewEffectGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbEffectGroups;
        private ucEffectGroup ucEffectGroup1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Button btnDuplicate;
    }
}