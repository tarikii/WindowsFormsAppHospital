namespace WindowsFormsAppHospital
{
    partial class ListDoctorsControl
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
            this.doctorListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listDoctorsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doctorListView
            // 
            this.doctorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.doctorListView.GridLines = true;
            this.doctorListView.HideSelection = false;
            this.doctorListView.Location = new System.Drawing.Point(19, 73);
            this.doctorListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctorListView.Name = "doctorListView";
            this.doctorListView.Size = new System.Drawing.Size(512, 632);
            this.doctorListView.TabIndex = 0;
            this.doctorListView.UseCompatibleStateImageBehavior = false;
            this.doctorListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Doctor Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Doctor Age";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Special Field";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 220;
            // 
            // listDoctorsLabel
            // 
            this.listDoctorsLabel.AutoSize = true;
            this.listDoctorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDoctorsLabel.ForeColor = System.Drawing.Color.White;
            this.listDoctorsLabel.Location = new System.Drawing.Point(162, 24);
            this.listDoctorsLabel.Name = "listDoctorsLabel";
            this.listDoctorsLabel.Size = new System.Drawing.Size(204, 31);
            this.listDoctorsLabel.TabIndex = 1;
            this.listDoctorsLabel.Text = "List of Doctors";
            // 
            // ListDoctorsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.listDoctorsLabel);
            this.Controls.Add(this.doctorListView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListDoctorsControl";
            this.Size = new System.Drawing.Size(555, 726);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView doctorListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label listDoctorsLabel;
    }
}
