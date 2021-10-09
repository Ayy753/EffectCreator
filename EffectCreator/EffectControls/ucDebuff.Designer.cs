
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
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotency)).BeginInit();
            this.SuspendLayout();
            // 
            // cbExpires
            // 
            this.cbExpires.AutoSize = true;
            this.cbExpires.Checked = true;
            this.cbExpires.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExpires.Location = new System.Drawing.Point(116, 96);
            this.cbExpires.Name = "cbExpires";
            this.cbExpires.Size = new System.Drawing.Size(15, 14);
            this.cbExpires.TabIndex = 25;
            this.cbExpires.UseVisualStyleBackColor = true;
            this.cbExpires.CheckedChanged += new System.EventHandler(this.cbExpires_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
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
            this.numDuration.Location = new System.Drawing.Point(116, 119);
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
            this.numDuration.TabIndex = 23;
            this.numDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(14, 118);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(47, 13);
            this.lblDuration.TabIndex = 22;
            this.lblDuration.Text = "Duration";
            // 
            // lblStatType
            // 
            this.lblStatType.AutoSize = true;
            this.lblStatType.Location = new System.Drawing.Point(14, 44);
            this.lblStatType.Name = "lblStatType";
            this.lblStatType.Size = new System.Drawing.Size(53, 13);
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
            this.cbStatType.Location = new System.Drawing.Point(116, 41);
            this.cbStatType.Name = "cbStatType";
            this.cbStatType.Size = new System.Drawing.Size(121, 21);
            this.cbStatType.TabIndex = 20;
            // 
            // numPotency
            // 
            this.numPotency.DecimalPlaces = 1;
            this.numPotency.Location = new System.Drawing.Point(116, 14);
            this.numPotency.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPotency.Name = "numPotency";
            this.numPotency.Size = new System.Drawing.Size(121, 20);
            this.numPotency.TabIndex = 19;
            this.numPotency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPotency
            // 
            this.lblPotency.AutoSize = true;
            this.lblPotency.Location = new System.Drawing.Point(14, 18);
            this.lblPotency.Name = "lblPotency";
            this.lblPotency.Size = new System.Drawing.Size(46, 13);
            this.lblPotency.TabIndex = 18;
            this.lblPotency.Text = "Potency";
            // 
            // lblResistType
            // 
            this.lblResistType.AutoSize = true;
            this.lblResistType.Location = new System.Drawing.Point(14, 70);
            this.lblResistType.Name = "lblResistType";
            this.lblResistType.Size = new System.Drawing.Size(63, 13);
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
            this.cbResistType.Location = new System.Drawing.Point(116, 69);
            this.cbResistType.Name = "cbResistType";
            this.cbResistType.Size = new System.Drawing.Size(121, 21);
            this.cbResistType.TabIndex = 26;
            // 
            // ucDebuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Size = new System.Drawing.Size(250, 150);
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
    }
}
