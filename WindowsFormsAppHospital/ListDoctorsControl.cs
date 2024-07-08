using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHospital
{
    public partial class ListDoctorsControl : UserControl
    {
        public ListView ListDoctorsView { get { return doctorListView; } } 
        public ListDoctorsControl()
        {
            InitializeComponent();
        }
    }
}
