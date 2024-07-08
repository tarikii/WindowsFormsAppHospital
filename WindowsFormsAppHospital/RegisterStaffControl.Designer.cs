namespace WindowsFormsAppHospital
{
    partial class RegisterStaffControl
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
            this.registerStaff = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameStaffTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageStaffTextBox = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butSubmitStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerStaff
            // 
            this.registerStaff.AutoSize = true;
            this.registerStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerStaff.ForeColor = System.Drawing.Color.White;
            this.registerStaff.Location = new System.Drawing.Point(137, 32);
            this.registerStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerStaff.Name = "registerStaff";
            this.registerStaff.Size = new System.Drawing.Size(146, 24);
            this.registerStaff.TabIndex = 2;
            this.registerStaff.Text = "Register a staff";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(23, 108);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(65, 24);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // nameStaffTextBox
            // 
            this.nameStaffTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameStaffTextBox.Location = new System.Drawing.Point(106, 111);
            this.nameStaffTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameStaffTextBox.Name = "nameStaffTextBox";
            this.nameStaffTextBox.Size = new System.Drawing.Size(91, 23);
            this.nameStaffTextBox.TabIndex = 4;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.ForeColor = System.Drawing.Color.White;
            this.ageLabel.Location = new System.Drawing.Point(23, 228);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(48, 24);
            this.ageLabel.TabIndex = 5;
            this.ageLabel.Text = "Age";
            // 
            // ageStaffTextBox
            // 
            this.ageStaffTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageStaffTextBox.Location = new System.Drawing.Point(106, 231);
            this.ageStaffTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ageStaffTextBox.Name = "ageStaffTextBox";
            this.ageStaffTextBox.Size = new System.Drawing.Size(91, 23);
            this.ageStaffTextBox.TabIndex = 6;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLabel.ForeColor = System.Drawing.Color.White;
            this.departmentLabel.Location = new System.Drawing.Point(23, 330);
            this.departmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(117, 24);
            this.departmentLabel.TabIndex = 7;
            this.departmentLabel.Text = "Department";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentTextBox.Location = new System.Drawing.Point(157, 332);
            this.departmentTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(91, 23);
            this.departmentTextBox.TabIndex = 8;
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancel.ForeColor = System.Drawing.Color.White;
            this.butCancel.Location = new System.Drawing.Point(13, 470);
            this.butCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(122, 89);
            this.butCancel.TabIndex = 9;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butSubmitStaff
            // 
            this.butSubmitStaff.BackColor = System.Drawing.Color.Violet;
            this.butSubmitStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSubmitStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSubmitStaff.ForeColor = System.Drawing.Color.White;
            this.butSubmitStaff.Location = new System.Drawing.Point(272, 470);
            this.butSubmitStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butSubmitStaff.Name = "butSubmitStaff";
            this.butSubmitStaff.Size = new System.Drawing.Size(122, 89);
            this.butSubmitStaff.TabIndex = 10;
            this.butSubmitStaff.Text = "Submit Staff";
            this.butSubmitStaff.UseVisualStyleBackColor = false;
            this.butSubmitStaff.Click += new System.EventHandler(this.butSubmitStaff_Click);
            // 
            // RegisterStaffControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.butSubmitStaff);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.ageStaffTextBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameStaffTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.registerStaff);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegisterStaffControl";
            this.Size = new System.Drawing.Size(416, 590);
            this.Load += new System.EventHandler(this.RegisterStaffControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerStaff;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameStaffTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox ageStaffTextBox;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butSubmitStaff;
    }
}
