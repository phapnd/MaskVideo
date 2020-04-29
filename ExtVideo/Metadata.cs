using System;
using System.Windows.Forms;

namespace ExtVideo
{
    public partial class Metadata : Form
    {
        private string pathToMetadataFile = string.Empty;
        public Metadata(string metadata, string _pathToMetadataFile)
        {
            InitializeComponent();
            textBox1.Text = metadata;
            pathToMetadataFile = _pathToMetadataFile;
        }
        #region events
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            saveMetadata();
        }
        #endregion

        #region processing
        private void saveMetadata()
        {
            if (string.IsNullOrEmpty(pathToMetadataFile))
                if (MessageBox.Show("WARNING Metadata file does not exits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    return;

            System.IO.File.WriteAllText(pathToMetadataFile, textBox1.Text);
            if (MessageBox.Show("Save file successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                return;
        }
        #endregion
    }
}
