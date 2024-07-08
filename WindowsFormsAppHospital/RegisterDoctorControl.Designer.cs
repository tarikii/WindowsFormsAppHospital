namespace WindowsFormsAppHospital
{
    partial class RegisterDoctorControl
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
            this.registerDoctor = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameDoctorTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageDoctorTextBox = new System.Windows.Forms.TextBox();
            this.specialFieldLabel = new System.Windows.Forms.Label();
            this.specialFieldTextBox = new System.Windows.Forms.TextBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butSubmitDoctor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerDoctor
            // 
            this.registerDoctor.AutoSize = true;
            this.registerDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerDoctor.ForeColor = System.Drawing.Color.White;
            this.registerDoctor.Location = new System.Drawing.Point(160, 27);
            this.registerDoctor.Name = "registerDoctor";
            this.registerDoctor.Size = new System.Drawing.Size(214, 29);
            this.registerDoctor.TabIndex = 1;
            this.registerDoctor.Text = "Register a doctor";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(27, 144);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(82, 29);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // nameDoctorTextBox
            // 
            this.nameDoctorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDoctorTextBox.Location = new System.Drawing.Point(135, 148);
            this.nameDoctorTextBox.Name = "nameDoctorTextBox";
            this.nameDoctorTextBox.Size = new System.Drawing.Size(120, 26);
            this.nameDoctorTextBox.TabIndex = 3;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.ForeColor = System.Drawing.Color.White;
            this.ageLabel.Location = new System.Drawing.Point(27, 270);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(59, 29);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Age";
            // 
            // ageDoctorTextBox
            // 
            this.ageDoctorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageDoctorTextBox.Location = new System.Drawing.Point(135, 274);
            this.ageDoctorTextBox.Name = "ageDoctorTextBox";
            this.ageDoctorTextBox.Size = new System.Drawing.Size(120, 26);
            this.ageDoctorTextBox.TabIndex = 5;
            // 
            // specialFieldLabel
            // 
            this.specialFieldLabel.AutoSize = true;
            this.specialFieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialFieldLabel.ForeColor = System.Drawing.Color.White;
            this.specialFieldLabel.Location = new System.Drawing.Point(27, 412);
            this.specialFieldLabel.Name = "specialFieldLabel";
            this.specialFieldLabel.Size = new System.Drawing.Size(168, 29);
            this.specialFieldLabel.TabIndex = 6;
            this.specialFieldLabel.Text = "Special Field";
            // 
            // specialFieldTextBox
            // 
            this.specialFieldTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialFieldTextBox.Location = new System.Drawing.Point(224, 415);
            this.specialFieldTextBox.Name = "specialFieldTextBox";
            this.specialFieldTextBox.Size = new System.Drawing.Size(120, 26);
            this.specialFieldTextBox.TabIndex = 7;
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancel.ForeColor = System.Drawing.Color.White;
            this.butCancel.Location = new System.Drawing.Point(33, 574);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(162, 109);
            this.butCancel.TabIndex = 8;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butSubmitDoctor
            // 
            this.butSubmitDoctor.BackColor = System.Drawing.Color.Violet;
            this.butSubmitDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSubmitDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSubmitDoctor.ForeColor = System.Drawing.Color.White;
            this.butSubmitDoctor.Location = new System.Drawing.Point(350, 574);
            this.butSubmitDoctor.Name = "butSubmitDoctor";
            this.butSubmitDoctor.Size = new System.Drawing.Size(162, 109);
            this.butSubmitDoctor.TabIndex = 9;
            this.butSubmitDoctor.Text = "Submit Doctor";
            this.butSubmitDoctor.UseVisualStyleBackColor = false;
            this.butSubmitDoctor.Click += new System.EventHandler(this.butSubmitDoctor_Click);
            // 
            // RegisterDoctorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.butSubmitDoctor);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.specialFieldTextBox);
            this.Controls.Add(this.specialFieldLabel);
            this.Controls.Add(this.ageDoctorTextBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameDoctorTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.registerDoctor);
            this.Name = "RegisterDoctorControl";
            this.Size = new System.Drawing.Size(555, 726);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerDoctor;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameDoctorTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox ageDoctorTextBox;
        private System.Windows.Forms.Label specialFieldLabel;
        private System.Windows.Forms.TextBox specialFieldTextBox;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butSubmitDoctor;
    }
}
