using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace индивидуальное_задание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Student> Students = new List<Student>();

        XmlSerializer For_serialization = new XmlSerializer(typeof(List<Student>));


        Form2 ChildAdd;
        Form3 ChildDel;
        Form4 ChildChange;
        Form5 ChildFilter;
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            dataGridView1.Location = new Point(this.Width-dataGridView1.Width-8, dataGridView1.Location.Y);
        }
       
        private void добавитьАбитуриентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ChildAdd == null)
            {
                ChildAdd = new Form2();
                ChildAdd.MdiParent = this;
                ChildAdd.FormClosed += ChildAdd_FormClosed;
                ChildAdd.Show();
            }
            else ChildAdd.Activate();
        }

        private void ChildAdd_FormClosed(object sender, FormClosedEventArgs e)
        { 
            ChildAdd = null;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream FS = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                    {
                        For_serialization.Serialize(FS, Students);
                    }
                }
            }
        }

        public void Otobrajenie()
        {
            dataGridView1.Rows.Clear();
            foreach (Student student in Students)
            {
                double srednee = (student.Math + student.Fisics + student.Literatura)/3;

                dataGridView1.Rows.Add(student.Surname, student.Name, student.Otchestvo, student.City, student.Math.ToString(), student.Fisics.ToString(), student.Literatura.ToString(), (Math.Round(srednee)).ToString());
            }
        }

        private void выгнатьАбитуриентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ChildDel == null)
            {
                ChildDel = new Form3();
                ChildDel.MdiParent = this;
                ChildDel.FormClosed += ChildDel_FormClosed;
                ChildDel.Show();
            }
            else ChildDel.Activate();
        }

        private void ChildDel_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChildDel = null;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream FS = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate))
                {
                    Students = (List<Student>)For_serialization.Deserialize(FS);
                    foreach(Student student in Students)
                    {
                        student.time = DateTime.Today.ToString();
                    }
                    Otobrajenie();
                }
            }
        }
        public Student Get_student (int Index)
        {
            foreach (Student student in Students)
            {
                if ((student.Name == dataGridView1.Rows[Index].Cells[1].Value.ToString()) && (student.Surname == dataGridView1.Rows[Index].Cells[0].Value.ToString()) && (student.Otchestvo == dataGridView1.Rows[Index].Cells[2].Value.ToString()) && (student.City == dataGridView1.Rows[Index].Cells[3].Value.ToString()) && (student.Math == Convert.ToInt32(dataGridView1.Rows[Index].Cells[4].Value)) && (student.Fisics == Convert.ToInt32(dataGridView1.Rows[Index].Cells[5].Value)) && (student.Literatura == Convert.ToInt32(dataGridView1.Rows[Index].Cells[6].Value)))
                {
                    return student;
                }
                
            }
            return null;
        }

        private void редактироватьАбитуриентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ChildChange == null)
            {
                ChildChange = new Form4();
                ChildChange.MdiParent = this;
                ChildChange.FormClosed += ChildChange_FormClosed;
                ChildChange.Show();
            }
        }

        private void ChildChange_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChildChange = null;
        }

        private void поискПоКритериямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ChildFilter == null)
            {
                ChildFilter = new Form5();
                ChildFilter.MdiParent = this;
                ChildFilter.FormClosed += ChildFilter_FormClosed;
                ChildFilter.Show();
            }
        }

        private void ChildFilter_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChildChange = null;
        }
    }
    

}

