
namespace EffectCreator.EffectControls {
    partial class ucDamage {
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
            this.lblPotency = new System.Windows.Forms.Label();
            this.numPotency = new System.Windows.Forms.NumericUpDown();
            this.cbDamageType = new System.Windows.Forms.ComboBox();
            this.lblDamageType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPotency)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPotency
            // 
            this.lblPotency.AutoSize = true;
            this.lblPotency.Location = new System.Drawing.Point(0, 5);
            this.lblPotency.Name = "lblPotency";
            this.lblPotency.Size = new System.Drawing.Size(86, 13);
            this.lblPotency.TabIndex = 0;
            this.lblPotency.Text = "Damage Amount";
            // 
            // numPotency
            // 
            this.numPotency.DecimalPlaces = 1;
            this.numPotency.Location = new System.Drawing.Point(100, 5);
            this.numPotency.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPotency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPotency.Name = "numPotency";
            this.numPotency.Size = new System.Drawing.Size(121, 20);
            this.numPotency.TabIndex = 1;
            this.numPotency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPotency.ValueChanged += new System.EventHandler(this.FieldsModified);
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
            this.cbDamageType.Location = new System.Drawing.Point(100, 30);
            this.cbDamageType.Name = "cbDamageType";
            this.cbDamageType.Size = new System.Drawing.Size(121, 21);
            this.cbDamageType.TabIndex = 2;
            this.cbDamageType.SelectedIndexChanged += new System.EventHandler(this.FieldsModified);
            // 
            // lblDamageType
            // 
            this.lblDamageType.AutoSize = true;
            this.lblDamageType.Location = new System.Drawing.Point(0, 30);
            this.lblDamageType.Name = "lblDamageType";
            this.lblDamageType.Size = new System.Drawing.Size(74, 13);
            this.lblDamageType.TabIndex = 3;
            this.lblDamageType.Text = "Damage Type";
            // 
            // ucDamage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDamageType);
            this.Controls.Add(this.cbDamageType);
            this.Controls.Add(this.numPotency);
            this.Controls.Add(this.lblPotency);
            this.Name = "ucDamage";
            this.Size = new System.Drawing.Size(225, 60);
            ((System.ComponentModel.ISupportInitialize)(this.numPotency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPotency;
        private System.Windows.Forms.NumericUpDown numPotency;
        private System.Windows.Forms.ComboBox cbDamageType;
        private System.Windows.Forms.Label lblDamageType;
    }
}
