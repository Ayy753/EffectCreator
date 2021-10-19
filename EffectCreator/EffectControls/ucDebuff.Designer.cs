
namespace EffectCreator.EffectControls {
    partial class ucDebuff {
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
            this.cbExpires = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblStatType = new System.Windows.Forms.Label();
            this.cbStatType = new System.Windows.Forms.ComboBox();
            this.numPotency = new System.Windows.Forms.NumericUpDown();
            this.lblPotency = new System.Windows.Forms.Label();
            this.lblResistType = new System.Windows.Forms.Label();
            this.cbResistType = new System.Windows.Forms.ComboBox();
            this.lblEffectName = new System.Windows.Forms.Label();
            this.txtEffectType = new System.Windows.Forms.TextBox();
            this.txtEffectName = new System.Windows.Forms.TextBox();
            this.lblEffectType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotency)).BeginInit();
            this.SuspendLayout();
            // 
            // cbExpires
            // 
            this.cbExpires.AutoSize = true;
            this.cbExpires.Checked = true;
            this.cbExpires.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExpires.Location = new System.Drawing.Point(100, 174);
            this.cbExpires.Margin = new System.Windows.Forms.Padding(5);
            this.cbExpires.Name = "cbExpires";
            this.cbExpires.Size = new System.Drawing.Size(15, 14);
            this.cbExpires.TabIndex = 5;
            this.cbExpires.UseVisualStyleBackColor = true;
            this.cbExpires.CheckedChanged += new System.EventHandler(this.cbExpires_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Expires";
            // 
            // numDuration
            // 
            this.numDuration.DecimalPlaces = 1;
            this.numDuration.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDuration.Location = new System.Drawing.Point(100, 204);
            this.numDuration.Margin = new System.Windows.Forms.Padding(5);
            this.numDuration.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(121, 20);
            this.numDuration.TabIndex = 6;
            this.numDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuration.ValueChanged += new System.EventHandler(this.FieldsModified);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(0, 203);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Padding = new System.Windows.Forms.Padding(5);
            this.lblDuration.Size = new System.Drawing.Size(57, 23);
            this.lblDuration.TabIndex = 22;
            this.lblDuration.Text = "Duration";
            // 
            // lblStatType
            // 
            this.lblStatType.AutoSize = true;
            this.lblStatType.Location = new System.Drawing.Point(0, 104);
            this.lblStatType.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblStatType.Name = "lblStatType";
            this.lblStatType.Padding = new System.Windows.Forms.Padding(5);
            this.lblStatType.Size = new System.Drawing.Size(63, 23);
            this.lblStatType.TabIndex = 21;
            this.lblStatType.Text = "Stat Type";
            // 
            // cbStatType
            // 
            this.cbStatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatType.FormattingEnabled = true;
            this.cbStatType.Items.AddRange(new object[] {
            "Armor",
            "ColdResist",
            "FireResist",
            "PoisonResist",
            "LightningResist",
            "Health",
            "Speed"});
            this.cbStatType.Location = new System.Drawing.Point(100, 105);
            this.cbStatType.Margin = new System.Windows.Forms.Padding(5);
            this.cbStatType.MaxDropDownItems = 3;
            this.cbStatType.Name = "cbStatType";
            this.cbStatType.Size = new System.Drawing.Size(121, 21);
            this.cbStatType.TabIndex = 3;
            this.cbStatType.SelectedIndexChanged += new System.EventHandler(this.FieldsModified);
            // 
            // numPotency
            // 
            this.numPotency.DecimalPlaces = 1;
            this.numPotency.Location = new System.Drawing.Point(100, 72);
            this.numPotency.Margin = new System.Windows.Forms.Padding(5);
            this.numPotency.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPotency.Name = "numPotency";
            this.numPotency.Size = new System.Drawing.Size(121, 20);
            this.numPotency.TabIndex = 2;
            this.numPotency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPotency.ValueChanged += new System.EventHandler(this.FieldsModified);
            // 
            // lblPotency
            // 
            this.lblPotency.AutoSize = true;
            this.lblPotency.Location = new System.Drawing.Point(0, 71);
            this.lblPotency.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblPotency.Name = "lblPotency";
            this.lblPotency.Padding = new System.Windows.Forms.Padding(5);
            this.lblPotency.Size = new System.Drawing.Size(102, 23);
            this.lblPotency.TabIndex = 18;
            this.lblPotency.Text = "Decrease Amount";
            // 
            // lblResistType
            // 
            this.lblResistType.AutoSize = true;
            this.lblResistType.Location = new System.Drawing.Point(0, 137);
            this.lblResistType.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblResistType.Name = "lblResistType";
            this.lblResistType.Padding = new System.Windows.Forms.Padding(5);
            this.lblResistType.Size = new System.Drawing.Size(73, 23);
            this.lblResistType.TabIndex = 27;
            this.lblResistType.Text = "Resist Type";
            // 
            // cbResistType
            // 
            this.cbResistType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResistType.FormattingEnabled = true;
            this.cbResistType.Items.AddRange(new object[] {
            "Physical",
            "Cold",
            "Fire",
            "Poison",
            "Lightning"});
            this.cbResistType.Location = new System.Drawing.Point(100, 138);
            this.cbResistType.Margin = new System.Windows.Forms.Padding(5);
            this.cbResistType.Name = "cbResistType";
            this.cbResistType.Size = new System.Drawing.Size(121, 21);
            this.cbResistType.TabIndex = 4;
            this.cbResistType.SelectedIndexChanged += new System.EventHandler(this.FieldsModified);
            // 
            // lblEffectName
            // 
            this.lblEffectName.AutoSize = true;
            this.lblEffectName.Location = new System.Drawing.Point(0, 38);
            this.lblEffectName.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblEffectName.Name = "lblEffectName";
            this.lblEffectName.Padding = new System.Windows.Forms.Padding(5);
            this.lblEffectName.Size = new System.Drawing.Size(76, 23);
            this.lblEffectName.TabIndex = 35;
            this.lblEffectName.Text = "Effect Name";
            // 
            // txtEffectType
            // 
            this.txtEffectType.Enabled = false;
            this.txtEffectType.Location = new System.Drawing.Point(100, 6);
            this.txtEffectType.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtEffectType.Name = "txtEffectType";
            this.txtEffectType.Size = new System.Drawing.Size(121, 20);
            this.txtEffectType.TabIndex = 0;
            // 
            // txtEffectName
            // 
            this.txtEffectName.Location = new System.Drawing.Point(100, 39);
            this.txtEffectName.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtEffectName.Name = "txtEffectName";
            this.txtEffectName.Size = new System.Drawing.Size(121, 20);
            this.txtEffectName.TabIndex = 1;
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
            this.lblEffectType.TabIndex = 32;
            this.lblEffectType.Text = "Effect Type";
            this.lblEffectType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucDebuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEffectName);
            this.Controls.Add(this.txtEffectType);
            this.Controls.Add(this.txtEffectName);
            this.Controls.Add(this.lblEffectType);
            this.Controls.Add(this.lblResistType);
            this.Controls.Add(this.cbResistType);
            this.Controls.Add(this.cbExpires);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblStatType);
            this.Controls.Add(this.cbStatType);
            this.Controls.Add(this.numPotency);
            this.Controls.Add(this.lblPotency);
            this.Name = "ucDebuff";
            this.Size = new System.Drawing.Size(250, 250);
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbExpires;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblStatType;
        private System.Windows.Forms.ComboBox cbStatType;
        private System.Windows.Forms.NumericUpDown numPotency;
        private System.Windows.Forms.Label lblPotency;
        private System.Windows.Forms.Label lblResistType;
        private System.Windows.Forms.ComboBox cbResistType;
        private System.Windows.Forms.Label lblEffectName;
        private System.Windows.Forms.TextBox txtEffectType;
        private System.Windows.Forms.TextBox txtEffectName;
        private System.Windows.Forms.Label lblEffectType;
    }
}
