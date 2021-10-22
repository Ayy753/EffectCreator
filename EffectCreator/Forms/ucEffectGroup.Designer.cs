
namespace EffectCreator {
    partial class ucEffectGroup {
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
            this.cbParticleType = new System.Windows.Forms.ComboBox();
            this.lbParticleType = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEffects = new System.Windows.Forms.ListBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.numRadius = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTargetArea = new System.Windows.Forms.RadioButton();
            this.radTargetIndividual = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSoundType = new System.Windows.Forms.ComboBox();
            this.lblSoundType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.numCooldown = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCooldown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbParticleType
            // 
            this.cbParticleType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbParticleType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbParticleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParticleType.FormattingEnabled = true;
            this.cbParticleType.Items.AddRange(new object[] {
            "Blood",
            "Buff",
            "Explosion",
            "Heal"});
            this.cbParticleType.Location = new System.Drawing.Point(91, 105);
            this.cbParticleType.Name = "cbParticleType";
            this.cbParticleType.Size = new System.Drawing.Size(121, 21);
            this.cbParticleType.Sorted = true;
            this.cbParticleType.TabIndex = 3;
            this.cbParticleType.SelectedIndexChanged += new System.EventHandler(this.ControlsModified);
            // 
            // lbParticleType
            // 
            this.lbParticleType.AutoSize = true;
            this.lbParticleType.Location = new System.Drawing.Point(12, 108);
            this.lbParticleType.Name = "lbParticleType";
            this.lbParticleType.Size = new System.Drawing.Size(69, 13);
            this.lbParticleType.TabIndex = 15;
            this.lbParticleType.Text = "Particle Type";
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(12, 384);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemoveEffect_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(94, 384);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNew.TabIndex = 9;
            this.btnCreateNew.Text = "Create New";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNewEfect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Effects";
            // 
            // lbEffects
            // 
            this.lbEffects.FormattingEnabled = true;
            this.lbEffects.Location = new System.Drawing.Point(12, 283);
            this.lbEffects.Name = "lbEffects";
            this.lbEffects.Size = new System.Drawing.Size(157, 95);
            this.lbEffects.TabIndex = 7;
            this.lbEffects.SelectedIndexChanged += new System.EventHandler(this.lbEffects_SelectedIndexChanged);
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(12, 238);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(40, 13);
            this.lblRadius.TabIndex = 10;
            this.lblRadius.Text = "Radius";
            this.lblRadius.Visible = false;
            // 
            // numRadius
            // 
            this.numRadius.DecimalPlaces = 1;
            this.numRadius.Location = new System.Drawing.Point(91, 239);
            this.numRadius.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numRadius.Name = "numRadius";
            this.numRadius.Size = new System.Drawing.Size(120, 20);
            this.numRadius.TabIndex = 6;
            this.numRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRadius.Visible = false;
            this.numRadius.ValueChanged += new System.EventHandler(this.ControlsModified);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radTargetArea);
            this.groupBox1.Controls.Add(this.radTargetIndividual);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Type";
            // 
            // radTargetArea
            // 
            this.radTargetArea.AutoSize = true;
            this.radTargetArea.Location = new System.Drawing.Point(6, 42);
            this.radTargetArea.Name = "radTargetArea";
            this.radTargetArea.Size = new System.Drawing.Size(47, 17);
            this.radTargetArea.TabIndex = 1;
            this.radTargetArea.Text = "Area";
            this.radTargetArea.UseVisualStyleBackColor = true;
            this.radTargetArea.CheckedChanged += new System.EventHandler(this.radTargetGroup_CheckedChanged);
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
            this.radTargetIndividual.CheckedChanged += new System.EventHandler(this.ControlsModified);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
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
            this.cbSoundType.Location = new System.Drawing.Point(91, 71);
            this.cbSoundType.Name = "cbSoundType";
            this.cbSoundType.Size = new System.Drawing.Size(121, 21);
            this.cbSoundType.TabIndex = 2;
            this.cbSoundType.SelectedIndexChanged += new System.EventHandler(this.ControlsModified);
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
            this.tbDescription.Size = new System.Drawing.Size(200, 20);
            this.tbDescription.TabIndex = 1;
            this.tbDescription.TextChanged += new System.EventHandler(this.ControlsModified);
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
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 0;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // numCooldown
            // 
            this.numCooldown.DecimalPlaces = 1;
            this.numCooldown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCooldown.Location = new System.Drawing.Point(91, 141);
            this.numCooldown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCooldown.Name = "numCooldown";
            this.numCooldown.Size = new System.Drawing.Size(120, 20);
            this.numCooldown.TabIndex = 4;
            this.numCooldown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCooldown.ValueChanged += new System.EventHandler(this.ControlsModified);
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
            this.splitContainer1.Panel1.Controls.Add(this.cbParticleType);
            this.splitContainer1.Panel1.Controls.Add(this.lbParticleType);
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
            this.splitContainer1.Size = new System.Drawing.Size(600, 425);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // ucEffectGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucEffectGroup";
            this.Size = new System.Drawing.Size(600, 425);
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCooldown)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbParticleType;
        private System.Windows.Forms.Label lbParticleType;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbEffects;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.NumericUpDown numRadius;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radTargetArea;
        private System.Windows.Forms.RadioButton radTargetIndividual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSoundType;
        private System.Windows.Forms.Label lblSoundType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.NumericUpDown numCooldown;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
