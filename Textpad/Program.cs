using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textpad
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TextpadForm());

            State[] states = new State[2];
            states[0] = new State("Германия", "Берлин", 357168, 80.8);
            states[1] = new State("Франция", "Париж", 640679, 64.7);

            string path = "states.dat";

            try
            {
                // создаем объект BinaryWriter
                using (System.IO.BinaryWriter writer = new System.IO.BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    // записываем в файл значение каждого поля структуры
                    foreach (State s in states)
                    {
                        writer.Write(s.name);
                        writer.Write(s.capital);
                        writer.Write(s.area);
                        writer.Write(s.people);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
    
