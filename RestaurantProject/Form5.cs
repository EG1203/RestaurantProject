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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.restaurantDataSet.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantDataSet);
        }
    }
}
