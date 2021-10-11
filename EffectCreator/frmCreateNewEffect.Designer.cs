
namespace EffectCreator {
    partial class frmCreateNewEffect {
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
            this.cbEffectType = new System.Windows.Forms.ComboBox();
            this.lblEffectType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtEffectName = new System.Windows.Forms.TextBox();
            this.lblEffectName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbEffectType
            // 
            this.cbEffectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEffectType.FormattingEnabled = true;
            this.cbEffectType.Items.AddRange(new object[] {
            "Buff",
            "Debuff",
            "Damage",
            "DamageOverTime",
            "StatMod",
            "Heal"});
            this.cbEffectType.Location = new System.Drawing.Point(113, 64);
            this.cbEffectType.Name = "cbEffectType";
            this.cbEffectType.Size = new System.Drawing.Size(121, 21);
            this.cbEffectType.TabIndex = 17;
            this.cbEffectType.SelectedIndexChanged += new System.EventHandler(this.cbEffectType_SelectedIndexChanged);
            // 
            // lblEffectType
            // 
            this.lblEffectType.AutoSize = true;
            this.lblEffectType.Location = new System.Drawing.Point(30, 64);
            this.lblEffectType.Name = "lblEffectType";
            this.lblEffectType.Size = new System.Drawing.Size(62, 13);
            this.lblEffectType.TabIndex = 16;
            this.lblEffectType.Text = "Effect Type";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 18);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Create New Effect";
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(33, 126);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 19;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(115, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtEffectName
            // 
            this.txtEffectName.Location = new System.Drawing.Point(113, 92);
            this.txtEffectName.Name = "txtEffectName";
            this.txtEffectName.Size = new System.Drawing.Size(121, 20);
            this.txtEffectName.TabIndex = 21;
            this.txtEffectName.TextChanged += new System.EventHandler(this.txtEffectName_TextChanged);
            // 
            // lblEffectName
            // 
            this.lblEffectName.AutoSize = true;
            this.lblEffectName.Location = new System.Drawing.Point(30, 92);
            this.lblEffectName.Name = "lblEffectName";
            this.lblEffectName.Size = new System.Drawing.Size(66, 13);
            this.lblEffectName.TabIndex = 22;
            this.lblEffectName.Text = "Effect Name";
            // 
            // frmCreateNewEffect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblEffectName);
            this.Controls.Add(this.txtEffectName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbEffectType);
            this.Controls.Add(this.lblEffectType);
            this.Name = "frmCreateNewEffect";
            this.Text = "Create New Effect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEffectType;
        private System.Windows.Forms.Label lblEffectType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtEffectName;
        private System.Windows.Forms.Label lblEffectName;
    }
}