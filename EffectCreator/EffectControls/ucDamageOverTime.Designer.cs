
namespace EffectCreator.EffectControls {
    partial class ucDamageOverTime {
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
            this.lblDamageType = new System.Windows.Forms.Label();
            this.cbDamageType = new System.Windows.Forms.ComboBox();
            this.numPotency = new System.Windows.Forms.NumericUpDown();
            this.lblPotency = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblEffectName = new System.Windows.Forms.Label();
            this.txtEffectType = new System.Windows.Forms.TextBox();
            this.txtEffectName = new System.Windows.Forms.TextBox();
            this.lblEffectType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPotency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDamageType
            // 
            this.lblDamageType.AutoSize = true;
            this.lblDamageType.Location = new System.Drawing.Point(0, 104);
            this.lblDamageType.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblDamageType.Name = "lblDamageType";
            this.lblDamageType.Padding = new System.Windows.Forms.Padding(5);
            this.lblDamageType.Size = new System.Drawing.Size(84, 23);
            this.lblDamageType.TabIndex = 7;
            this.lblDamageType.Text = "Damage Type";
            // 
            // cbDamageType
            // 
            this.cbDamageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDamageType.FormattingEnabled = true;
            this.cbDamageType.Items.AddRange(new object[] {
            "Physical",
            "Cold",
            "Fire",
            "Poison",
            "Lightning"});
            this.cbDamageType.Location = new System.Drawing.Point(100, 105);
            this.cbDamageType.Margin = new System.Windows.Forms.Padding(5);
            this.cbDamageType.Name = "cbDamageType";
            this.cbDamageType.Size = new System.Drawing.Size(121, 21);
            this.cbDamageType.TabIndex = 6;
            this.cbDamageType.SelectedIndexChanged += new System.EventHandler(this.FieldsModified);
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
            this.numPotency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPotency.Name = "numPotency";
            this.numPotency.Size = new System.Drawing.Size(121, 20);
            this.numPotency.TabIndex = 5;
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
            this.lblPotency.Size = new System.Drawing.Size(96, 23);
            this.lblPotency.TabIndex = 4;
            this.lblPotency.Text = "Damage Amount";
            // 
            // numDuration
            // 
            this.numDuration.DecimalPlaces = 1;
            this.numDuration.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDuration.Location = new System.Drawing.Point(100, 138);
            this.numDuration.Margin = new System.Windows.Forms.Padding(5);
            this.numDuration.Maximum = new decimal(new int[] {
            9999999,
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
            this.numDuration.TabIndex = 9;
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
            this.lblDuration.Location = new System.Drawing.Point(0, 137);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Padding = new System.Windows.Forms.Padding(5);
            this.lblDuration.Size = new System.Drawing.Size(57, 23);
            this.lblDuration.TabIndex = 8;
            this.lblDuration.Text = "Duration";
            // 
            // lblEffectName
            // 
            this.lblEffectName.AutoSize = true;
            this.lblEffectName.Location = new System.Drawing.Point(0, 38);
            this.lblEffectName.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblEffectName.Name = "lblEffectName";
            this.lblEffectName.Padding = new System.Windows.Forms.Padding(5);
            this.lblEffectName.Size = new System.Drawing.Size(76, 23);
            this.lblEffectName.TabIndex = 31;
            this.lblEffectName.Text = "Effect Name";
            // 
            // txtEffectType
            // 
            this.txtEffectType.Enabled = false;
            this.txtEffectType.Location = new System.Drawing.Point(100, 6);
            this.txtEffectType.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtEffectType.Name = "txtEffectType";
            this.txtEffectType.Size = new System.Drawing.Size(121, 20);
            this.txtEffectType.TabIndex = 30;
            // 
            // txtEffectName
            // 
            this.txtEffectName.Location = new System.Drawing.Point(100, 39);
            this.txtEffectName.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtEffectName.Name = "txtEffectName";
            this.txtEffectName.Size = new System.Drawing.Size(121, 20);
            this.txtEffectName.TabIndex = 29;
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
            this.lblEffectType.TabIndex = 28;
            this.lblEffectType.Text = "Effect Type";
            this.lblEffectType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucDamageOverTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEffectName);
            this.Controls.Add(this.txtEffectType);
            this.Controls.Add(this.txtEffectName);
            this.Controls.Add(this.lblEffectType);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblDamageType);
            this.Controls.Add(this.cbDamageType);
            this.Controls.Add(this.numPotency);
            this.Controls.Add(this.lblPotency);
            this.Name = "ucDamageOverTime";
            this.Size = new System.Drawing.Size(225, 175);
            ((System.ComponentModel.ISupportInitialize)(this.numPotency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDamageType;
        private System.Windows.Forms.ComboBox cbDamageType;
        private System.Windows.Forms.NumericUpDown numPotency;
        private System.Windows.Forms.Label lblPotency;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblEffectName;
        private System.Windows.Forms.TextBox txtEffectType;
        private System.Windows.Forms.TextBox txtEffectName;
        private System.Windows.Forms.Label lblEffectType;
    }
}
