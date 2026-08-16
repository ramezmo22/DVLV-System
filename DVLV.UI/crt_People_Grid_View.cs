using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLV.UI
{
    public partial class crt_People_Grid_View : UserControl
    {
        enum enDataFilteringOrder
        {
            None = 0,
            PersonID = 1,
            NationalNo = 2,
            FirstName = 3,
            SecondName = 4,
            ThirdName = 5,
            LastName = 6,
            Nationality = 7,
            Gendor = 8,
            Phone = 9,
            Email = 10
        }
        public crt_People_Grid_View()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public int GetNumberOfRecords()
        {
            return dgv_PeopleGrid.Rows.Count;
        }
      

    }
}
