namespace WindowsFormsAppHospital
{
    partial class RemovePatientControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.removePatient = new System.Windows.Forms.Label();
            this.selectNameLabel = new System.Windows.Forms.Label();
            this.butCancel = new System.Windows.Forms.Button();
            this.butRemovePatient = new System.Windows.Forms.Button();
            this.listPatientsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // removePatient
            // 
            this.removePatient.AutoSize = true;
            this.removePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePatient.ForeColor = System.Drawing.Color.White;
            this.removePatient.Location = new System.Drawing.Point(164, 41);
            this.removePatient.Name = "removePatient";
            this.removePatient.Size = new System.Drawing.Size(216, 29);
            this.removePatient.TabIndex = 3;
            this.removePatient.Text = "Remove a patient";
            // 
            // selectNameLabel
            // 
            this.selectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectNameLabel.ForeColor = System.Drawing.Color.White;
            this.selectNameLabel.Location = new System.Drawing.Point(89, 229);
            this.selectNameLabel.Name = "selectNameLabel";
            this.selectNameLabel.Size = new System.Drawing.Size(396, 82);
            this.selectNameLabel.TabIndex = 4;
            this.selectNameLabel.Text = "Type the name of the patient you want to remove";
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancel.ForeColor = System.Drawing.Color.White;
            this.butCancel.Location = new System.Drawing.Point(15, 601);
            this.butCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(163, 110);
            this.butCancel.TabIndex = 12;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butRemovePatient
            // 
            this.butRemovePatient.BackColor = System.Drawing.Color.Violet;
            this.butRemovePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRemovePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRemovePatient.ForeColor = System.Drawing.Color.White;
            this.butRemovePatient.Location = new System.Drawing.Point(371, 601);
            this.butRemovePatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butRemovePatient.Name = "butRemovePatient";
            this.butRemovePatient.Size = new System.Drawing.Size(163, 110);
            this.butRemovePatient.TabIndex = 13;
            this.butRemovePatient.Text = "Remove Patient";
            this.butRemovePatient.UseVisualStyleBackColor = false;
            this.butRemovePatient.Click += new System.EventHandler(this.butRemovePatient_Click);
            // 
            // listPatientsComboBox
            // 
            this.listPatientsComboBox.FormattingEnabled = true;
            this.listPatientsComboBox.Location = new System.Drawing.Point(183, 349);
            this.listPatientsComboBox.Name = "listPatientsComboBox";
            this.listPatientsComboBox.Size = new System.Drawing.Size(146, 24);
            this.listPatientsComboBox.TabIndex = 14;
            // 
            // RemovePatientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.listPatientsComboBox);
            this.Controls.Add(this.butRemovePatient);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.selectNameLabel);
            this.Controls.Add(this.removePatient);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RemovePatientControl";
            this.Size = new System.Drawing.Size(555, 726);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label removePatient;
        private System.Windows.Forms.Label selectNameLabel;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butRemovePatient;
        private System.Windows.Forms.ComboBox listPatientsComboBox;
    }
}
