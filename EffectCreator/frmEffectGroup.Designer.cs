
namespace EffectCreator {
    partial class frmEffectGroup {
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
            this.cbEffectType = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEffects = new System.Windows.Forms.ListBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.numRadius = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTargetGroup = new System.Windows.Forms.RadioButton();
            this.radTargetIndividual = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSoundType = new System.Windows.Forms.ComboBox();
            this.numCooldown = new System.Windows.Forms.NumericUpDown();
            this.lblSoundType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCooldown)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbEffectType);
            this.splitContainer1.Panel1.Controls.Add(this.btnRemove);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreateNew);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.lbEffects);
            this.splitContainer1.Panel1.Controls.Add(this.lblRadius);
            this.splitContainer1.Panel1.Controls.Add(this.numRadius);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.cbSoundType);
            this.splitContainer1.Panel1.Controls.Add(this.numCooldown);
            this.splitContainer1.Panel1.Controls.Add(this.lblSoundType);
            this.splitContainer1.Panel1.Controls.Add(this.lblDescription);
            this.splitContainer1.Panel1.Controls.Add(this.tbDescription);
            this.splitContainer1.Panel1.Controls.Add(this.lblName);
            this.splitContainer1.Panel1.Controls.Add(this.tbName);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbEffectType
            // 
            this.cbEffectType.FormattingEnabled = true;
            this.cbEffectType.Items.AddRange(new object[] {
            "Buff",
            "Debuff",
            "Damage",
            "DamageOverTime",
            "StatMod"});
            this.cbEffectType.Location = new System.Drawing.Point(93, 376);
            this.cbEffectType.Name = "cbEffectType";
            this.cbEffectType.Size = new System.Drawing.Size(121, 21);
            this.cbEffectType.TabIndex = 15;
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(12, 345);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(12, 374);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNew.TabIndex = 13;
            this.btnCreateNew.Text = "Create New";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Effects";
            // 
            // lbEffects
            // 
            this.lbEffects.FormattingEnabled = true;
            this.lbEffects.Location = new System.Drawing.Point(12, 244);
            this.lbEffects.Name = "lbEffects";
            this.lbEffects.Size = new System.Drawing.Size(157, 95);
            this.lbEffects.TabIndex = 11;
            this.lbEffects.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(12, 199);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(40, 13);
            this.lblRadius.TabIndex = 10;
            this.lblRadius.Text = "Radius";
            this.lblRadius.Visible = false;
            // 
            // numRadius
            // 
            this.numRadius.Location = new System.Drawing.Point(91, 200);
            this.numRadius.Name = "numRadius";
            this.numRadius.Size = new System.Drawing.Size(120, 20);
            this.numRadius.TabIndex = 9;
            this.numRadius.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radTargetGroup);
            this.groupBox1.Controls.Add(this.radTargetIndividual);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 71);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Type";
            // 
            // radTargetGroup
            // 
            this.radTargetGroup.AutoSize = true;
            this.radTargetGroup.Location = new System.Drawing.Point(6, 42);
            this.radTargetGroup.Name = "radTargetGroup";
            this.radTargetGroup.Size = new System.Drawing.Size(54, 17);
            this.radTargetGroup.TabIndex = 1;
            this.radTargetGroup.Text = "Group";
            this.radTargetGroup.UseVisualStyleBackColor = true;
            // 
            // radTargetIndividual
            // 
            this.radTargetIndividual.AutoSize = true;
            this.radTargetIndividual.Checked = true;
            this.radTargetIndividual.Location = new System.Drawing.Point(6, 19);
            this.radTargetIndividual.Name = "radTargetIndividual";
            this.radTargetIndividual.Size = new System.Drawing.Size(70, 17);
            this.radTargetIndividual.TabIndex = 0;
            this.radTargetIndividual.TabStop = true;
            this.radTargetIndividual.Text = "Individual";
            this.radTargetIndividual.UseVisualStyleBackColor = true;
            this.radTargetIndividual.CheckedChanged += new System.EventHandler(this.radTargetIndividual_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cooldown";
            // 
            // cbSoundType
            // 
            this.cbSoundType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSoundType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSoundType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoundType.FormattingEnabled = true;
            this.cbSoundType.Items.AddRange(new object[] {
            "arrowHitFlesh",
            "buff",
            "explosionTiny"});
            this.cbSoundType.Location = new System.Drawing.Point(91, 71);
            this.cbSoundType.Name = "cbSoundType";
            this.cbSoundType.Size = new System.Drawing.Size(121, 21);
            this.cbSoundType.Sorted = true;
            this.cbSoundType.TabIndex = 8;
            // 
            // numCooldown
            // 
            this.numCooldown.Location = new System.Drawing.Point(91, 102);
            this.numCooldown.Name = "numCooldown";
            this.numCooldown.Size = new System.Drawing.Size(120, 20);
            this.numCooldown.TabIndex = 7;
            // 
            // lblSoundType
            // 
            this.lblSoundType.AutoSize = true;
            this.lblSoundType.Location = new System.Drawing.Point(12, 74);
            this.lblSoundType.Name = "lblSoundType";
            this.lblSoundType.Size = new System.Drawing.Size(65, 13);
            this.lblSoundType.TabIndex = 6;
            this.lblSoundType.Text = "Sound Type";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 40);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(91, 40);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(237, 20);
            this.tbDescription.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(91, 9);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(237, 20);
            this.tbName.TabIndex = 0;
            // 
            // frmEffectGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmEffectGroup";
            this.Text = "frmEffectGroup";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCooldown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numCooldown;
        private System.Windows.Forms.Label lblSoundType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radTargetGroup;
        private System.Windows.Forms.RadioButton radTargetIndividual;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.ComboBox cbSoundType;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.NumericUpDown numRadius;
        private System.Windows.Forms.ListBox lbEffects;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEffectType;
    }
}