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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] spisok = File.ReadAllLines("students_data.txt");
            List<Student> student = new List<Student>();
            List<Student> badstudent = new List<Student>();
            string[] newspisok;
            char[] mas;

            for (int i = 0; i < spisok.Length; i++)
            {
                mas = spisok[i].ToCharArray();
                int id = Convert.ToInt32(mas[2].ToString() + mas[3].ToString());
                char[] name = { mas[14], mas[15], mas[16], mas[17], mas[18], mas[19],
                                mas[20], mas[21], mas[22]};
                char[] group = { mas[6], mas[7], mas[8], mas[9], mas[10], mas[11] };
                int firstGrade = Convert.ToInt32(mas[28].ToString());
                int secondGrade = Convert.ToInt32(mas[31].ToString());
                int thirdGrade = Convert.ToInt32(mas[34].ToString());
                student.Add(new Student(id, group, name, firstGrade, secondGrade, thirdGrade));
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                for (int i = 0; i < student.Count; i++)
                {
                    if (student[i].getFG() == 2 || student[i].getSG() == 2 || student[i].getTG() == 2) { badstudent.Add(student[i]); }
                }
                newspisok = new string[badstudent.Count];
                for (int i = 0; i < badstudent.Count; i++) { newspisok[i] = badstudent[i].ToString(); }
                File.WriteAllLines("newstudents.txt", newspisok);
                this.richTextBox1.Text = File.ReadAllText("newstudents.txt", Encoding.UTF8);

            }
            else { string podstroka = textBox1.Text;
                
               
                for (int i = 0; i < student.Count; i++)
                {
                    if (student[i].getName().ToLower().Contains(podstroka)&&(student[i].getFG() == 2 || student[i].getSG() == 2 || student[i].getTG() == 2)) { badstudent.Add(student[i]); }
                }
                newspisok = new string[badstudent.Count];
                for (int i = 0; i < badstudent.Count; i++) { newspisok[i] = badstudent[i].ToString(); }
                File.WriteAllLines("newstudents.txt", newspisok);
                this.richTextBox1.Text = File.ReadAllText("newstudents.txt", Encoding.UTF8);

            }
        }
    }
}
