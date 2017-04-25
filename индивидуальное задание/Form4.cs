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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Form1 Parent1;
        Student student;

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "") && (textBox5.Text != "") && (textBox6.Text != "") && (textBox7.Text != ""))
            {
                student.Name = textBox1.Text;
                student.Surname = textBox2.Text;
                student.Otchestvo = textBox3.Text;
                student.City = textBox4.Text;
                student.Math = Convert.ToInt32(textBox5.Text);
                student.Fisics = Convert.ToInt32(textBox6.Text);
                student.Literatura = Convert.ToInt32(textBox7.Text);
                Parent1.Otobrajenie();
            }
            else MessageBox.Show("Все поля должны быть заполнены", "FatalError");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Parent1 = (Form1)MdiParent;

            groupBox2.Enabled = true;

            Load_student(Parent1.Get_student(Parent1.dataGridView1.CurrentRow.Index));
        }
        
        public void Load_student (Student st)
        {
            student = st;

            textBox1.Text = student.Name;
            textBox2.Text = student.Surname;
            textBox3.Text = student.Otchestvo;
            textBox4.Text = student.City;
            textBox5.Text = student.Math.ToString();
            textBox6.Text = student.Fisics.ToString();
            textBox7.Text = student.Literatura.ToString();
        }
    }
}
