
namespace EffectCreator.EffectControls {
    partial class ucStatMod {
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
            this.lblStatType = new System.Windows.Forms.Label();
            this.cbStatType = new System.Windows.Forms.ComboBox();
            this.numPotency = new System.Windows.Forms.NumericUpDown();
            this.lblPotency = new System.Windows.Forms.Label();
            this.lblEffectName = new System.Windows.Forms.Label();
            this.txtEffectType = new System.Windows.Forms.TextBox();
            this.txtEffectName = new System.Windows.Forms.TextBox();
            this.lblEffectType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPotency)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatType
            // 
            this.lblStatType.AutoSize = true;
            this.lblStatType.Location = new System.Drawing.Point(0, 104);
            this.lblStatType.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblStatType.Name = "lblStatType";
            this.lblStatType.Padding = new System.Windows.Forms.Padding(5);
            this.lblStatType.Size = new System.Drawing.Size(63, 23);
            this.lblStatType.TabIndex = 17;
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
            this.cbStatType.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.cbStatType.Name = "cbStatType";
            this.cbStatType.Size = new System.Drawing.Size(121, 21);
            this.cbStatType.TabIndex = 16;
            this.cbStatType.SelectedIndexChanged += new System.EventHandler(this.FieldsModified);
            // 
            // numPotency
            // 
            this.numPotency.DecimalPlaces = 1;
            this.numPotency.Location = new System.Drawing.Point(100, 72);
            this.numPotency.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.numPotency.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPotency.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numPotency.Name = "numPotency";
            this.numPotency.Size = new System.Drawing.Size(121, 20);
            this.numPotency.TabIndex = 15;
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
            this.lblPotency.Size = new System.Drawing.Size(93, 23);
            this.lblPotency.TabIndex = 14;
            this.lblPotency.Text = "Change Amount";
            // 
            // lblEffectName
            // 
            this.lblEffectName.AutoSize = true;
            this.lblEffectName.Location = new System.Drawing.Point(0, 38);
            this.lblEffectName.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblEffectName.Name = "lblEffectName";
            this.lblEffectName.Padding = new System.Windows.Forms.Padding(5);
            this.lblEffectName.Size = new System.Drawing.Size(76, 23);
            this.lblEffectName.TabIndex = 43;
            this.lblEffectName.Text = "Effect Name";
            // 
            // txtEffectType
            // 
            this.txtEffectType.Enabled = false;
            this.txtEffectType.Location = new System.Drawing.Point(100, 6);
            this.txtEffectType.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtEffectType.Name = "txtEffectType";
            this.txtEffectType.Size = new System.Drawing.Size(121, 20);
            this.txtEffectType.TabIndex = 42;
            // 
            // txtEffectName
            // 
            this.txtEffectName.Location = new System.Drawing.Point(100, 39);
            this.txtEffectName.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtEffectName.Name = "txtEffectName";
            this.txtEffectName.Size = new System.Drawing.Size(121, 20);
            this.txtEffectName.TabIndex = 41;
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
            this.lblEffectType.TabIndex = 40;
            this.lblEffectType.Text = "Effect Type";
            this.lblEffectType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucStatMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEffectName);
            this.Controls.Add(this.txtEffectType);
            this.Controls.Add(this.txtEffectName);
            this.Controls.Add(this.lblEffectType);
            this.Controls.Add(this.lblStatType);
            this.Controls.Add(this.cbStatType);
            this.Controls.Add(this.numPotency);
            this.Controls.Add(this.lblPotency);
            this.Name = "ucStatMod";
            this.Size = new System.Drawing.Size(250, 150);
            ((System.ComponentModel.ISupportInitialize)(this.numPotency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatType;
        private System.Windows.Forms.ComboBox cbStatType;
        private System.Windows.Forms.NumericUpDown numPotency;
        private System.Windows.Forms.Label lblPotency;
        private System.Windows.Forms.Label lblEffectName;
        private System.Windows.Forms.TextBox txtEffectType;
        private System.Windows.Forms.TextBox txtEffectName;
        private System.Windows.Forms.Label lblEffectType;
    }
}
