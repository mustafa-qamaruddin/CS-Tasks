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
        DataGridView_Helpers obj_dgrdview_helpers;

        public ReadTestCasesFromFile()
        {
        }

        public ReadTestCasesFromFile(Form parent_form, DataGridView dgrdv)
        {
            dgrdv.Rows.Clear();
            Stream fstream = open_file_dialog(parent_form);
            if (fstream == null)
                return;
            StreamReader sr = new StreamReader(fstream);
            string line = sr.ReadLine();
            while (!String.IsNullOrEmpty(line))
            {
                String[] tokens = line.Split(' ');
                dgrdv.Rows.Add(tokens);
                line = sr.ReadLine();
            }
        }

        public ReadTestCasesFromFile(Form parent_form, DataGridView dgrdv_meus_sigmas, DataGridView dgrdv_lambda)
        {
            obj_dgrdview_helpers = new DataGridView_Helpers();
            Stream fstream = open_file_dialog(parent_form);
            if (fstream == null)
                return;
            dgrdv_meus_sigmas.Rows.Clear();
            dgrdv_lambda.Rows.Clear();
            dgrdv_lambda.Columns.Clear();
            obj_dgrdview_helpers.add_grid_column("actions", "a", dgrdv_meus_sigmas.Rows[0].Cells[0], dgrdv_lambda);
            StreamReader sr = new StreamReader(fstream);

            // read first line
            // #_of_states_of_nature #_of_actions
            string line = sr.ReadLine();
            if (String.IsNullOrEmpty(line))
                return;
            String[] tokens = line.Split(' ');

            int num_of_states_of_nature = int.Parse(tokens[0]);
            int num_of_actions = int.Parse(tokens[1]);

            for (int i = 0; i < num_of_states_of_nature; i++)
            {
                line = sr.ReadLine();
                if (String.IsNullOrEmpty(line))
                    return;
                tokens = line.Split(' ');
                dgrdv_meus_sigmas.Rows.Add(tokens);
                
                int col_index = i + 1;
                obj_dgrdview_helpers.add_grid_column("w_" + col_index, "w" + col_index, dgrdv_meus_sigmas.Rows[i].Cells[0], dgrdv_lambda);
            }

            for (int i = 0; i < num_of_actions; i++)
            {
                line = sr.ReadLine();
                if (String.IsNullOrEmpty(line))
                    return;
                int row_index = i + 1;
                
                tokens = line.Split(' ');
                string[] row_vals = new string[tokens.Length+1];
                row_vals[0] = "a" + row_index;
                for (int j = 0; j < tokens.Length; j++)
                {
                    row_vals[j+1] = tokens[j];
                }
                dgrdv_lambda.Rows.Add(row_vals);
            }
        }

        public Stream open_file_dialog(Form parent_form, TextBox file_path_text_box = null)
        {
            OpenFileDialog file_dialog = new OpenFileDialog();
            file_dialog.Filter = "Text Files (*.txt)|*.txt|(*.dat)|*.dat";
            file_dialog.FilterIndex = 1;
            DialogResult clicked_result = file_dialog.ShowDialog(parent_form);
            if (clicked_result == DialogResult.OK)
            {
                if (file_path_text_box != null)
                    file_path_text_box.Text = file_dialog.FileName;
                return file_dialog.OpenFile();
            }
            else
            {
                return null;
            }
        }
    }
}
