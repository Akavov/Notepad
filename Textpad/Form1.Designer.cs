﻿namespace Textpad
{
    partial class TextpadForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRTB = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskCLR = new System.Windows.Forms.ToolStripMenuItem();
            this.averageGradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpButon = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.бинарныеФайлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.clearRTB,
            this.TaskCLR,
            this.бинарныеФайлыToolStripMenuItem,
            this.helpButon});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.saveFile,
            this.closeFile});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(132, 22);
            this.openFile.Text = "&Открыть";
            this.openFile.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(132, 22);
            this.saveFile.Text = "&Сохранить";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // closeFile
            // 
            this.closeFile.Name = "closeFile";
            this.closeFile.Size = new System.Drawing.Size(152, 22);
            this.closeFile.Text = "&Закрыть";
            this.closeFile.Click += new System.EventHandler(this.closeFile_Click);
            // 
            // clearRTB
            // 
            this.clearRTB.Name = "clearRTB";
            this.clearRTB.Size = new System.Drawing.Size(71, 20);
            this.clearRTB.Text = "&Очистить";
            this.clearRTB.Click += new System.EventHandler(this.clearRTB_Click);
            // 
            // TaskCLR
            // 
            this.TaskCLR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageGradeToolStripMenuItem,
            this.fmenToolStripMenuItem});
            this.TaskCLR.Name = "TaskCLR";
            this.TaskCLR.Size = new System.Drawing.Size(64, 20);
            this.TaskCLR.Text = "&Задание";
            // 
            // averageGradeToolStripMenuItem
            // 
            this.averageGradeToolStripMenuItem.Name = "averageGradeToolStripMenuItem";
            this.averageGradeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.averageGradeToolStripMenuItem.Text = "Средний балл";
            this.averageGradeToolStripMenuItem.Click += new System.EventHandler(this.averageGradeToolStripMenuItem_Click);
            // 
            // fmenToolStripMenuItem
            // 
            this.fmenToolStripMenuItem.Name = "fmenToolStripMenuItem";
            this.fmenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fmenToolStripMenuItem.Text = "Должники";
            this.fmenToolStripMenuItem.Click += new System.EventHandler(this.fmenToolStripMenuItem_Click);
            // 
            // helpButon
            // 
            this.helpButon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutButton});
            this.helpButon.Name = "helpButon";
            this.helpButon.Size = new System.Drawing.Size(44, 20);
            this.helpButon.Text = "&Help";
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(152, 22);
            this.aboutButton.Text = "&About";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "RTF files|*.rtf|Text files|*.txt|All files|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "RTF files|*.rtf|Text files|*.txt|All files|*.*";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(559, 328);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // бинарныеФайлыToolStripMenuItem
            // 
            this.бинарныеФайлыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.бинарныеФайлыToolStripMenuItem.Name = "бинарныеФайлыToolStripMenuItem";
            this.бинарныеФайлыToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.бинарныеФайлыToolStripMenuItem.Text = "Бинарные файлы";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.открытьToolStripMenuItem.Text = "&Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click_1);
            // 
            // TextpadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 352);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextpadForm";
            this.Text = "Блокнот";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ToolStripMenuItem closeFile;
        private System.Windows.Forms.ToolStripMenuItem clearRTB;
        private System.Windows.Forms.ToolStripMenuItem TaskCLR;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem helpButon;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
        private System.Windows.Forms.ToolStripMenuItem averageGradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бинарныеФайлыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
    }
}

