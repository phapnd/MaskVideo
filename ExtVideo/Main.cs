using System.Windows.Forms;
using System.Configuration;
using System.IO;
using MetadataExtractor;
using MetadataExtractor.Formats.QuickTime;
using System.Collections.Generic;
using System;
using MediaInfoDotNet;

namespace ExtVideo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        #region events

        private void btFileInput_MouseClick(object sender, MouseEventArgs e)
        {
            dialogFile(0);
        }

        private void btFileOutput_MouseClick(object sender, MouseEventArgs e)
        {
            dialogFile(1);
        }

        private void btFileMeta_MouseClick(object sender, MouseEventArgs e)
        {
            dialogFile(2);
        }

        private void btExtract_MouseClick(object sender, MouseEventArgs e)
        {
            string metadata = string.Empty;
            metadata = extractMetadata();
            if (!metadata.Equals("N/A"))
            {
                Metadata _metaData = new Metadata(metadata, txtMetadataFile.Text);
                _metaData.Show();
            }

        }

        private void btRender_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btExit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
        #endregion

        #region processing

        private string extractMetadata()
        {
            string res = string.Empty;
            if (string.IsNullOrEmpty(txtVideoInput.Text))
                if (MessageBox.Show("WARNING Source video does not exits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    res = "N/A";
                    return res;
                }
            if (string.IsNullOrEmpty(txtMetadataFile.Text))
                if (MessageBox.Show("WARNING Metadata file does not exits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    res = "N/A";
                    return res;
                }
            /*
             * 
             * 
            IEnumerable<MetadataExtractor.Directory> directories = QuickTimeMetadataReader.ReadMetadata(new FileStream(txtVideoInput.Text, FileMode.Open, FileAccess.Read, FileShare.Read));
            foreach (var directory in directories)
                foreach (var tag in directory.Tags)
                    //Console.WriteLine($"{directory.Name} - {tag.Name} = {tag.Description}");
                    res += directory.Name + " - " + tag.Name + " = " + tag.Description + System.Environment.NewLine;
            */
            var myVideo = new MediaFile(txtVideoInput.Text);
            if (myVideo.Video.Count > 0)
            {
                var vid = myVideo.Video[0];
                res += "General" + System.Environment.NewLine;
                res += "Complete name		: " + System.IO.Path.GetFileName(txtVideoInput.Text) + System.Environment.NewLine;
                res += "Format		    : " + vid.Format + System.Environment.NewLine;
                res += "Format profile		: " + vid.FormatProfile + System.Environment.NewLine;
                res += "Codec ID		    : " + vid.CodecId + System.Environment.NewLine;
                res += "File size		    : " + vid.Size + System.Environment.NewLine;
                res += "Duration		    : " + vid.Duration + System.Environment.NewLine;
                res += "Overall bit rate mode	: " + vid.bitRateMode + System.Environment.NewLine;
                res += "Overall bit rate		: " + vid.BitRateNominal + System.Environment.NewLine;
                res += "Encoded date		: " + vid.EncodedDate + System.Environment.NewLine;
                res += "Tagged date		: " + System.Environment.NewLine;

                res += System.Environment.NewLine;

                res += "Video" + System.Environment.NewLine;
                res += "ID		    : " + vid.ID + System.Environment.NewLine;
                res += "Format		    : " + vid.FormatInfo + System.Environment.NewLine;
                res += "Format/Info		: " + vid.FormatInfo + System.Environment.NewLine;
                res += "Format profile		: " + vid.FormatProfile + System.Environment.NewLine;
                res += "Format settings, CABAC	: " + vid.Format + System.Environment.NewLine;
                res += "Format settings, ReFrames	: " + vid.FrameCount + System.Environment.NewLine;
                res += "Codec ID		    : " + vid.CodecId + System.Environment.NewLine;
                res += "Codec ID/Info		: " + vid.CodecCommonName + System.Environment.NewLine;
                res += "Duration		    : " + vid.Duration + System.Environment.NewLine;
                res += "Bit rate		    : " + vid.BitRate + System.Environment.NewLine;
                res += "Width		    : " + vid.Width + System.Environment.NewLine;
                res += "Height		    : " + vid.Height + System.Environment.NewLine;
                res += "Display aspect ratio		: " + vid.DisplayAspectRatio + System.Environment.NewLine;
                res += "Frame rate mode		: " + vid.FrameRateMode + System.Environment.NewLine;
                res += "Frame rate		: " + vid.FrameRate + System.Environment.NewLine;
                res += "Standard		    : " + System.Environment.NewLine;
                res += "Color space		: " + vid.ColorSpace + System.Environment.NewLine;
                res += "Chroma subsampling	: " + vid.ChromaSubsampling + System.Environment.NewLine;
                res += "Bit depth		    : " + vid.BitDepth + System.Environment.NewLine;
                res += "Scan type		    : " + System.Environment.NewLine;
                res += "Bits/(Pixel*Frame)		: " + vid.BitDepth + System.Environment.NewLine;
                res += "Stream size		: " + System.Environment.NewLine;
                res += "Language		    : " + vid.Language + System.Environment.NewLine;
                res += "Encoded date		: " + vid.EncodedDate + System.Environment.NewLine;
                res += "Tagged date		: " + vid.EncodedDate + System.Environment.NewLine;
                res += "Color range		: " + System.Environment.NewLine;
                res += "Color primaries		: " + System.Environment.NewLine;
                res += "Transfer characteristics	: " + System.Environment.NewLine;
                res += "Matrix coefficients		: " + System.Environment.NewLine;

                res += System.Environment.NewLine;

                res += "Audio" + System.Environment.NewLine;
                res += "ID		    : " + vid.ID + System.Environment.NewLine;
                res += "Format		    : " + vid.FormatInfo + System.Environment.NewLine;
                res += "Format/Info		: " + vid.FormatInfo + System.Environment.NewLine;
                res += "Format profile		: " + vid.FormatProfile + System.Environment.NewLine;
                res += "Codec ID		    : " + vid.CodecId + System.Environment.NewLine;
                res += "Duration		    : " + vid.Duration + System.Environment.NewLine;
                res += "Source duration		: " + vid.Duration + System.Environment.NewLine;
                res += "Bit rate mode		: " + vid.BitRateMode + System.Environment.NewLine;
                res += "Nominal bit rate		: " + vid.BitRateNominal + System.Environment.NewLine;
                res += "Channel(s)		: " + System.Environment.NewLine;
                res += "Channel positions		: " + System.Environment.NewLine;
                res += "Sampling rate		: " + System.Environment.NewLine;
                res += "Frame rate		: " + vid.FrameRate + System.Environment.NewLine;
                res += "Compression mode		: " + vid.CompressionMode + System.Environment.NewLine;
                res += "Source stream size		: " + System.Environment.NewLine;
                res += "Language		    : " + vid.Language + System.Environment.NewLine;
                res += "Encoded date		: " + vid.EncodedDate + System.Environment.NewLine;
                res += "Tagged date		: " + vid.EncodedDate + System.Environment.NewLine;

            }
            return res;
        }
        /*
         * Open dialog filter base flag mode
         * param: flag
         * 0 - Input file
         * 1 - Output file
         * 2 - Metadata file
        */
        private void dialogFile(int flag)
        {
            string pathToFile = string.Empty;//to save the location of the selected object
            string titleDialog = string.Empty;
            string filterReg = string.Empty;
            string initDirectory = string.Empty;

            if (flag == 0)
            {
                titleDialog = "Source Video";
                filterReg = "Media Files| *.mpg; *.avi; *.wma; *.mov; *.wav; *.mp4; *.mp3 | All Files | *.*";
                initDirectory = Properties.Settings.Default.inputFile;
            }
            else if (flag == 1)
            {
                titleDialog = "Destination Video";
                filterReg = "Media Files| *.mpg; *.avi; *.wma; *.mov; *.wav; *.mp4; *.mp3 | All Files | *.*";
                initDirectory = Properties.Settings.Default.outputFile;
            }
            else if (flag == 2)
            {
                titleDialog = "Metadata File";
                filterReg = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                initDirectory = Properties.Settings.Default.metadataFile;
            }
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = titleDialog;
            theDialog.Filter = filterReg;
            if (string.IsNullOrEmpty(initDirectory)) theDialog.RestoreDirectory = true;
            else theDialog.InitialDirectory = initDirectory;
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                pathToFile = theDialog.FileName;//doesn't need .tostring because .filename returns a string// saves the location of the selected object
                if (flag == 0)
                {
                    txtVideoInput.Text = "";
                    txtVideoInput.Text = pathToFile;
                    Properties.Settings.Default.inputFile = pathToFile;
                }
                else if (flag == 1)
                {
                    txtVideoInput.Text = "";
                    txtVideoInput.Text = pathToFile;
                    Properties.Settings.Default.outputFile = pathToFile;
                }
                else if (flag == 2)
                {
                    txtMetadataFile.Text = "";
                    txtMetadataFile.Text = pathToFile;
                    Properties.Settings.Default.metadataFile = pathToFile;
                }

            }
        }
        #endregion

    }
}
