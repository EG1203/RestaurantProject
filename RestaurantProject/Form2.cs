using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void меню1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.меню1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Меню1". При необходимости она может быть перемещена или удалена.
            this.меню1TableAdapter.Fill(this.restaurantDataSet.Меню1);

        }
    }
}
