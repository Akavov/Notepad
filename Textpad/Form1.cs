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
    
    public partial class TextpadForm : Form
    {
        public TextpadForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Открытие существующего файла
        /// </summary>
        private void MenuFileOpen()
        {
            if (openFileDialog1.ShowDialog() ==
               System.Windows.Forms.DialogResult.OK &&
               openFileDialog1.FileName.Length > 0)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName,
                       RichTextBoxStreamType.RichText);
                }
                catch (System.ArgumentException ex)
                {
                    
                    richTextBox1.LoadFile(openFileDialog1.FileName,
                       RichTextBoxStreamType.PlainText);
                }

                this.Text = "Файл [" + openFileDialog1.FileName + "]";
            }
        }

        /// <summary>
        /// Сохранение документа в новом файле
        /// </summary>
        private void MenuFileSaveAs()
        {
            if (saveFileDialog1.ShowDialog() ==
               System.Windows.Forms.DialogResult.OK &&
            saveFileDialog1.FileName.Length > 0)
            {
                try
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    this.Text = "Файл [" + saveFileDialog1.FileName + "]";
                }  catch (Exception ex)
                {
                    // Display message box dialog
                    MessageBox.Show("Save canceled. \n\nCode: " + ex.Message, "Save Error!");
                }

            }
        }


        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuFileOpen();
            
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clearRTB_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            MenuFileSaveAs();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void averageGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void открытьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string path = "states.dat";
            try { 
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                // пока не достигнут конец файла
                // считываем каждое значение из файла
                while (reader.PeekChar() > -1)
                {
                    string name = reader.ReadString();
                    string capital = reader.ReadString();
                    int area = reader.ReadInt32();
                    double population = reader.ReadDouble();

                        this.richTextBox1.Text = "Страна: " + name + " столица: " + capital + " площадь " + area + " кв. км,   численность населения: " + population + " млн. чел.";
                      
                }
            }
        }
        catch (Exception ee)
        {
            Console.WriteLine(ee.Message);
        }
}

        private void closeFile_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class Student
    {

        int id;
        char[] name;
        string nameString;
        char[] group;
        string groupString;
        int firstGrade, secondGrade, thirdGrade;

        public Student(int id, char[] group, char[] name, int firstGrade, int secondGrade, int thirdGrade)
        {

            this.id = id;
            this.group = group;
            this.groupString = new string(group);
            this.name = name;
            this.nameString = new string(name);
            this.firstGrade = firstGrade;
            this.secondGrade = secondGrade;
            this.thirdGrade = thirdGrade;
        }

        public override string ToString()
        {
            return id + " " + groupString + " " + nameString + " " + firstGrade + " " + secondGrade + " " + thirdGrade;
        }
        public string getName() { return nameString; }
        public string getGroup() {
            return groupString;
        }
        public int getFG() { return firstGrade; }
        public int getSG() { return secondGrade; }
        public int getTG() { return thirdGrade; }

    }
    struct State
    {
        public string name;
        public string capital;
        public int area;
        public double people;

        public State(string n, string c, int a, double p)
        {
            name = n;
            capital = c;
            people = p;
            area = a;
        }
    }
    public class FileNameNotFoundException : ApplicationException
    {
        public FileNameNotFoundException() { MessageBox.Show("Не введено имя файлы"); }

 
    }
}
