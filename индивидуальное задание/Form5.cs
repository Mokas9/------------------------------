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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        Form1 Parent1;

        private void button1_Click(object sender, EventArgs e)
        {
            Parent1 = (Form1)MdiParent;

            if(radioButton1.Checked)
            {
                Parent1.dataGridView1.Rows.Clear();
               
                foreach (Student student in Parent1.Students)
                {
                    bool find = true;
                    if (student.City.Length >= textBox1.Text.Length)
                    {
                        for (int i = 0; i < textBox1.Text.Length; i++)
                        {
                            if (student.City[i] != textBox1.Text[i]) find = false;
                        }

                        if (find)
                        {
                            double srednee = (student.Math + student.Fisics + student.Literatura) / 3;
                            Parent1.dataGridView1.Rows.Add(student.Surname, student.Name, student.Otchestvo, student.City, student.Math.ToString(), student.Fisics.ToString(), student.Literatura.ToString(), (Math.Round(srednee)).ToString());
                        }
                    }
                  
                }
            }

            if(radioButton2.Checked)
            {
                Parent1.dataGridView1.Rows.Clear();

                foreach(Student student in Parent1.Students)
                {
                    double srednee = (student.Math + student.Fisics + student.Literatura) / 3;
                    if (Math.Round(srednee) == Convert.ToInt32(textBox1.Text))
                    {
                        Parent1.dataGridView1.Rows.Add(student.Surname, student.Name, student.Otchestvo, student.City, student.Math.ToString(), student.Fisics.ToString(), student.Literatura.ToString(), (Math.Round(srednee)).ToString());
                    }
                }
            }

        }
    }
}
