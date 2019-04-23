using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using UCP.AICharacters;
using System.Reflection;

//StrongholdAIPersonalityHelper
namespace SAIPH
{
    public partial class MainForm : Form
    {
        const BindingFlags Flags = BindingFlags.Public | BindingFlags.GetField | BindingFlags.Instance;
        AICCollection aicCol = new AICCollection();
        string path;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the Data from the File
        /// </summary>
        private void Loaddata()
        {
            try
            {
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    aicCol = new AICCollection(stream);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary> 
        /// Display the Data on a DataGridView 
        /// </summary>
        private void DisplayData()
        {
            AICdataGridView.Rows.Clear();
            AICdataGridView.Columns.Clear();

            LoadingprogressBar.Value = 0;
            LoadingprogressBar.Visible = true;

            List<string> columns = new List<string>();

            foreach (FieldInfo fi in new AIPersonality().GetType().GetFields(Flags))
            {
                //Only display unknown variable when the CheckBox is Checked
                if (!CheBoxOnlyUnknown.Checked || fi.Name.StartsWith("Unknown"))
                {
                    columns.Add(fi.Name);
                }
            }

            //Maximum for Progressbar
            LoadingprogressBar.Maximum = columns.Count + aicCol.Count;

            for (int i = 0; i < columns.Count; i++)
            {
                LoadingprogressBar.Value++;
                AICdataGridView.Columns.Add(columns[i], columns[i]);
            }

            foreach (KeyValuePair<int, AICharacter> pair in aicCol)
            {
                LoadingprogressBar.Value++;
                AICdataGridView.Rows.Add();
                DataGridViewRow dataRow = AICdataGridView.Rows[pair.Key - 1];
                Type type = pair.Value.Personality.GetType();
                dataRow.HeaderCell.Value = pair.Value.Name;

                foreach (FieldInfo fi in type.GetFields(Flags))
                {
                    if (!CheBoxOnlyUnknown.Checked || fi.Name.StartsWith("Unknown"))
                    {
                        object value = fi.GetValue(pair.Value.Personality);
                        dataRow.Cells[fi.Name].Value = value;
                    }
                }
            }
            LoadingprogressBar.Visible = false;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            if(path != null && File.Exists(path))
            {
                Loaddata();
                DisplayData();
            }
            else
            {
                BtnPath_Click(null, null);
            }
        }

        private void BtnPath_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            path = openFileDialog.FileName;

            if(!openFileDialog.SafeFileName.EndsWith(".aic"))
            {
                MessageBox.Show("False fileformat selected.", "False Fileformat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(path != "")
            {
                Loaddata();
                DisplayData();
            }
            
        }
    }
}
