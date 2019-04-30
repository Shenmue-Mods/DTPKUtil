using System;
using System.IO;
using System.Windows.Forms;

namespace DTPKutil
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void btnPickInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "AM2 DTPK Digital Track PacKage (*.snd)|*.snd|All Files (*.*)|*.*";
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                txtInput.Text = ofd.FileName;
                if (string.IsNullOrEmpty(txtOutput.Text))
                {
                    txtOutput.Text = Path.GetDirectoryName(txtInput.Text);
                }
            }
        }

        private void btnPickOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(txtOutput.Text))
            {
                fbd.SelectedPath = txtOutput.Text;
            }
            else if (!string.IsNullOrEmpty(txtInput.Text))
            {
                fbd.SelectedPath = Path.GetDirectoryName(txtInput.Text);
            }
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                txtOutput.Text = fbd.SelectedPath;
            }
        }

        private void btnReadInfo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                txtTrackInfo.Text = LoadTrack().PrintSamplesInfo();
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text) && !string.IsNullOrEmpty(txtOutput.Text))
            {
                var track = LoadTrack();
                txtTrackInfo.Text = track.PrintSamplesInfo();
                for(int i=0; i<track.Samples.Count;i++)
                {
                    string fileOut = Path.GetFileNameWithoutExtension(txtInput.Text) + "_" + (i+1) + ".pcm";
                    fileOut = Path.Combine(txtOutput.Text, fileOut);
                    File.WriteAllBytes(fileOut, track.GetSampleData(track.Samples[i], true));
                }
            }
        }

        private DtpkFile LoadTrack()
        {
            try
            {
                return new DtpkFile(File.ReadAllBytes(txtInput.Text));
            }
            catch (Exception ex)
            {
                txtTrackInfo.Text = "Bad File. Note the XBOX DTPK is not yet implemented.";
                MessageBox.Show($"Processing Failed: {ex.Message}");
            }
            return null;
        }
    }
}
