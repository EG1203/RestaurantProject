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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter1.Fill(this.restaurantDataSet1.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.restaurantDataSet.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantDataSet);
        }
    }
}
