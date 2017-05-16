using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                this.Text = "Файл [" + saveFileDialog1.FileName + "]";

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
    }
}
