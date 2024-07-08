namespace WindowsFormsAppHospital
{
    partial class ListPersonsControl
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
            this.personListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listPersonsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // personListView
            // 
            this.personListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.personListView.GridLines = true;
            this.personListView.HideSelection = false;
            this.personListView.Location = new System.Drawing.Point(20, 62);
            this.personListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.personListView.Name = "personListView";
            this.personListView.Size = new System.Drawing.Size(501, 605);
            this.personListView.TabIndex = 0;
            this.personListView.UseCompatibleStateImageBehavior = false;
            this.personListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Person Name";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Person Age";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 250;
            // 
            // listPersonsLabel
            // 
            this.listPersonsLabel.AutoSize = true;
            this.listPersonsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPersonsLabel.ForeColor = System.Drawing.Color.White;
            this.listPersonsLabel.Location = new System.Drawing.Point(170, 15);
            this.listPersonsLabel.Name = "listPersonsLabel";
            this.listPersonsLabel.Size = new System.Drawing.Size(206, 31);
            this.listPersonsLabel.TabIndex = 1;
            this.listPersonsLabel.Text = "List of persons";
            // 
            // ListPersonsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.listPersonsLabel);
            this.Controls.Add(this.personListView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListPersonsControl";
            this.Size = new System.Drawing.Size(555, 726);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView personListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label listPersonsLabel;
    }
}
