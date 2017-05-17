using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textpad
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] spisok = File.ReadAllLines("students_data.txt");
            List<Student> students = new List<Student>();
            
            char[] mass;
            string iu7 = "ИУ7-41";
            string iu8 = "ИУ8-41";
            string iu9 = "ИУ9-41";
            int divide = 0;
            int count = 0;
            for (int i=0;i<spisok.Length;i++) {
                mass = spisok[i].ToCharArray();
                int id = Convert.ToInt32(mass[2].ToString()+ mass[3].ToString());
                char[] name = { mass[14], mass[15], mass[16], mass[17], mass[18], mass[19],
                                mass[20], mass[21], mass[22]};
                char[] group ={mass[6], mass[7], mass[8], mass[9], mass[10], mass[11] };
                int firstGrade = Convert.ToInt32(mass[28].ToString());
                int secondGrade = Convert.ToInt32(mass[31].ToString());
                int thirdGrade = Convert.ToInt32(mass[34].ToString());
                students.Add(new Student(id, group, name, firstGrade, secondGrade, thirdGrade));
            }

            if (radioButton1.Checked) {
                for (int i = 0; i < students.Count; i++) {
                    if (students[i].getGroup().Equals(iu7)) { count += students[i].getFG() + students[i].getSG() + students[i].getTG(); divide += 3; }
                   }
                this.richTextBox1.Text = "Средний балл группы " + iu7 + " равен = " + (count / divide);


            }
            if (radioButton2.Checked)
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].getGroup().Equals(iu8)) { count += students[i].getFG() + students[i].getSG() + students[i].getTG(); divide += 3; }
                }
                this.richTextBox1.Text = "Средний балл группы " + iu8 + " равен = " + (count / divide);

            }
            if (radioButton3.Checked)
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].getGroup().Equals(iu9)) { count += students[i].getFG() + students[i].getSG() + students[i].getTG(); divide += 3; }
                }
                this.richTextBox1.Text = "Средний балл группы " + iu9 + " равен = " + (count / divide);

            }

        }
    }

    
}
