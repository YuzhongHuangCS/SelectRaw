
namespace SelectRaw
{
    public partial class MainForm : Form
    {
        public MainForm() {
            InitializeComponent();
        }

        private void JPGTargetButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                JPGTargetBox.Text = dialog.SelectedPath;
            }
        }

        private void RawSourceButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                RawSourceBox.Text = dialog.SelectedPath;
            }
        }

        private void RawTargetButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                RawTargetBox.Text = dialog.SelectedPath;
            }
        }

        private async void StartButton_Click(object sender, EventArgs e) {
            StartButton.Enabled = false;
            var files = Directory.GetFiles(JPGTargetBox.Text);
            DialogResult dialogResult = DialogResult.None;

            for (int i = 0; i < files.Length; i++) {
                var f = files[i];
                var raw_f = Path.GetFileName(f).Replace(JPGBox.Text, RawBox.Text);
                var src = Path.Join(RawSourceBox.Text, raw_f);
                var dst = Path.Join(RawTargetBox.Text, raw_f);
                try {
                    await Task.Run(() => {
                        File.Copy(src, dst);
                    });
                } catch (FileNotFoundException) {
                    dialogResult = MessageBox.Show($"{src} not found\nOk to Skip\nCancel to Stop", $"{src} not found", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Cancel) {
                        break;
                    } // nothing to do for DialogResult.Ok
                } catch (IOException) {
                    dialogResult = MessageBox.Show($"{dst} already exists\nYes to Overwrite\nNo to Skip\nCancel to Stop", $"{dst} already exists", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes) {
                        await Task.Run(() => {
                            File.Copy(src, dst, true);
                        });
                    } else {
                        if (dialogResult == DialogResult.Cancel) {
                            break;
                        } // nothing to do for DialogResult.No
                    }
                }
                CopyProgressBar.Value = (int)(100.0 * (i + 1) / files.Length);
            }
            if (dialogResult == DialogResult.Cancel) {
                MessageBox.Show("Task Aborted!");
            } else {
                MessageBox.Show("Task Completed!");
            }
            StartButton.Enabled = true;
        }

        private void TextBox_CheckExt(object sender, EventArgs e) {
            var box = sender as TextBox;
            if (box != null) {
                if (box.Text[0] != '.') {
                    box.Text = '.' + box.Text;
                }
            }
        }
    }
}
