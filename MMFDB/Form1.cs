using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMFDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void разработчикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.разработчикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Детали". При необходимости она может быть перемещена или удалена.
            this.деталиTableAdapter.Fill(this.database1DataSet.Детали);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Разработчики". При необходимости она может быть перемещена или удалена.
            this.разработчикиTableAdapter.Fill(this.database1DataSet.Разработчики);

        }
    }
}
