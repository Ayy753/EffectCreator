
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblResistType = new System.Windows.Forms.Label();
            this.cbResistType = new System.Windows.Forms.ComboBox();
            this.cbExpires = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblStatType = new System.Windows.Forms.Label();
            this.cbStatType = new System.Windows.Forms.ComboBox();
            this.numPotency = new System.Windows.Forms.NumericUpDown();
            this.lblPotency = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotency)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEffectType
            // 
            this.txtEffectType.TabIndex = 0;
            // 
            // txtEffectName
            // 
            this.txtEffectName.TabIndex = 1;
            this.txtEffectName.TextChanged += new System.EventHandler(this.FieldsModified);
            // 
            // lblResistType
            // 
            this.lblResistType.AutoSize = true;
            this.lblResistType.Location = new System.Drawing.Point(0, 135);
            this.lblResistType.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblResistType.Name = "lblResistType";
            this.lblResistType.Padding = new System.Windows.Forms.Padding(5);
            this.lblResistType.Size = new System.Drawing.Size(73, 23);
            this.lblResistType.TabIndex = 57;
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
            this.cbResistType.Location = new System.Drawing.Point(100, 136);
            this.cbResistType.Margin = new System.Windows.Forms.Padding(5);
            this.cbResistType.Name = "cbResistType";
            this.cbResistType.Size = new System.Drawing.Size(121, 21);
            this.cbResistType.TabIndex = 4;
            this.cbResistType.SelectedIndexChanged += new System.EventHandler(this.FieldsModified);
            // 
            // cbExpires
            // 
            this.cbExpires.AutoSize = true;
            this.cbExpires.Checked = true;
            this.cbExpires.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExpires.Location = new System.Drawing.Point(100, 172);
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
            this.label1.Location = new System.Drawing.Point(0, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 54;
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
            this.numDuration.Location = new System.Drawing.Point(100, 202);
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
            this.lblDuration.Location = new System.Drawing.Point(0, 201);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Padding = new System.Windows.Forms.Padding(5);
            this.lblDuration.Size = new System.Drawing.Size(57, 23);
            this.lblDuration.TabIndex = 52;
            this.lblDuration.Text = "Duration";
            // 
            // lblStatType
            // 
            this.lblStatType.AutoSize = true;
            this.lblStatType.Location = new System.Drawing.Point(0, 102);
            this.lblStatType.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblStatType.Name = "lblStatType";
            this.lblStatType.Padding = new System.Windows.Forms.Padding(5);
            this.lblStatType.Size = new System.Drawing.Size(63, 23);
            this.lblStatType.TabIndex = 51;
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
            this.cbStatType.Location = new System.Drawing.Point(100, 103);
            this.cbStatType.Margin = new System.Windows.Forms.Padding(5);
            this.cbStatType.Name = "cbStatType";
            this.cbStatType.Size = new System.Drawing.Size(121, 21);
            this.cbStatType.TabIndex = 3;
            this.cbStatType.SelectedIndexChanged += new System.EventHandler(this.FieldsModified);
            // 
            // numPotency
            // 
            this.numPotency.DecimalPlaces = 1;
            this.numPotency.Location = new System.Drawing.Point(100, 70);
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
            this.lblPotency.Location = new System.Drawing.Point(0, 69);
            this.lblPotency.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblPotency.Name = "lblPotency";
            this.lblPotency.Padding = new System.Windows.Forms.Padding(5);
            this.lblPotency.Size = new System.Drawing.Size(102, 23);
            this.lblPotency.TabIndex = 48;
            this.lblPotency.Text = "Decrease Amount";
            // 
            // ucDebuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Controls.SetChildIndex(this.txtEffectName, 0);
            this.Controls.SetChildIndex(this.txtEffectType, 0);
            this.Controls.SetChildIndex(this.lblPotency, 0);
            this.Controls.SetChildIndex(this.numPotency, 0);
            this.Controls.SetChildIndex(this.cbStatType, 0);
            this.Controls.SetChildIndex(this.lblStatType, 0);
            this.Controls.SetChildIndex(this.lblDuration, 0);
            this.Controls.SetChildIndex(this.numDuration, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cbExpires, 0);
            this.Controls.SetChildIndex(this.cbResistType, 0);
            this.Controls.SetChildIndex(this.lblResistType, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResistType;
        private System.Windows.Forms.ComboBox cbResistType;
        private System.Windows.Forms.CheckBox cbExpires;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblStatType;
        private System.Windows.Forms.ComboBox cbStatType;
        private System.Windows.Forms.NumericUpDown numPotency;
        private System.Windows.Forms.Label lblPotency;
    }
}
