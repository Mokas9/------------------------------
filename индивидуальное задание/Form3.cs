using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace индивидуальное_задание
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form1 Parent1;
        private void button1_Click(object sender, EventArgs e)
        {

            Parent1 = (Form1)this.MdiParent;
            if (Parent1.dataGridView1.RowCount != 0)
            {
                Parent1.Students.Remove(Parent1.Get_student(Parent1.dataGridView1.CurrentRow.Index));
                Parent1.Otobrajenie();
            }
            else MessageBox.Show("Список пуст...", "Ошибка!");
        }
    }
}
