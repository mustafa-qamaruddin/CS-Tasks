using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Patterns_Recognition___Task_1
{
    class ReadTestCasesFromFile
    {
        public ReadTestCasesFromFile(Form parent_form, DataGridView dgrdv)
        {
            dgrdv.Rows.Clear();
            Stream fstream = open_file_dialog(parent_form);
            StreamReader sr = new StreamReader(fstream);
            string line = sr.ReadLine();
            while( !String.IsNullOrEmpty(line) ){
                String[] tokens = line.Split(' ');
                dgrdv.Rows.Add(tokens);
                line = sr.ReadLine();
            }
        }

        public Stream open_file_dialog(Form parent_form)
        {
            OpenFileDialog file_dialog = new OpenFileDialog();
            file_dialog.Filter = "Text Files (*.txt)|*.txt|(*.dat)|*.dat";
            file_dialog.FilterIndex = 1;
            DialogResult clicked_result = file_dialog.ShowDialog(parent_form);
            if (clicked_result == DialogResult.OK)
            {
                return file_dialog.OpenFile();
            }
            else
            {
                return null;
            }
        }
    }
}
