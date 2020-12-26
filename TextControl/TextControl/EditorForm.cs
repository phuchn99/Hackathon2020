using System;
using System.IO;
using System.Windows.Forms;

namespace LiveSwitch.TextControl
{
    public partial class EditorForm : Form
    {
        private string _filename = null;
        private static int id_inc = 0;

        public EditorForm()
        {
            InitializeComponent();
            editor.Tick += new Editor.TickDelegate(editor_Tick);
        }

        private void editor_Tick()
        {
            undoToolStripMenuItem.Enabled = editor.CanUndo();
            redoToolStripMenuItem.Enabled = editor.CanRedo();
            cutToolStripMenuItem.Enabled = editor.CanCut();
            copyToolStripMenuItem.Enabled = editor.CanCopy();
            pasteToolStripMenuItem.Enabled = editor.CanPaste();
            imageToolStripMenuItem.Enabled = editor.CanInsertLink();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _filename = null;
            Text = null;
            editor.BodyHtml = string.Empty;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_filename == null)
            {
                if (!SaveFileDialog())
                    return;
            }
            SaveFile(_filename);
        }

        private bool SaveFileDialog()
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.AddExtension = true;
                dlg.DefaultExt = "htm";
                dlg.Filter = "HTML files (*.html;*.htm)|*.html;*.htm";
                DialogResult res = dlg.ShowDialog(this);
                if (res == DialogResult.OK)
                {
                    _filename = dlg.FileName;
                    return true;
                }
                else
                    return false;
            }
        }

        private void SaveFile(string filename)
        {
            using (StreamWriter writer = File.CreateText(filename))
            {
                writer.Write(editor.DocumentText);
                writer.Flush();
                writer.Close();
            }
        }

        private void LoadFile(string filename)
        {
            using (StreamReader reader = File.OpenText(filename))
            {
                editor.Html = reader.ReadToEnd();
                Text = editor.DocumentTitle;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "HTML files (*.html;*.htm)|*.html;*.htm";
                DialogResult res = dlg.ShowDialog(this);
                if (res == DialogResult.OK)
                {
                    _filename = dlg.FileName;
                }
                else
                    return;
            }
            LoadFile(_filename);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog())
                SaveFile(_filename);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SearchDialog dlg = new SearchDialog(editor))
            {
                dlg.ShowDialog(this);
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.SelectAll();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Redo();
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, editor.BodyText);
        }

        private void htmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, editor.BodyHtml);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Print();
        }

        private void breakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.InsertBreak();
        }

        private void textToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (TextInsertForm form = new TextInsertForm(editor.BodyHtml))
            {
                form.ShowDialog(this);
                if (form.Accepted)
                {
                    editor.BodyHtml = form.HTML;
                    /*string html = "<!DOCTYPE HTML PUBLIC ' -//W3C//DTD HTML 4.0 Transitional//EN'>";
                    html += "<html><head>";
                    html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/></head><body>";
                    html += form.HTML; // "<iframe id='video' src='\Video\test.mp4' width='420' height='250' frameborder='0' allowfullscreen></iframe>";
                    html += "</body></html>";
                    editor.DocumentText = html;*/

                }
            }
        }

        private void paragraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.InsertParagraph();
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.InsertImage();
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ConfigureSMTPForm(null, 25, SMTPAuthenticationType.UsernamePassword, null, null, true, editor.ToMailMessage());
            form.ShowDialog();
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertIframe("Video", "Video file (*.mp4, *.avi, *.amv, *.3gp, *.m4v, *.mov)|*.mp4;*.avi;*.amv;*.3gp;*.m4v;*.mov");
        }

        private void pptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertIframe("PowerPoint", "PowerPoint Presentation (*.pptx)|*.pptx|PowerPoint 97-2003 Presentation (*.ppt)|*.ppt");
        }

        private void InsertIframe(string fileFormat, string filter)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = filter;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(fileFormat))
                    Directory.CreateDirectory(fileFormat);
                string name = fileFormat + "/" + fileFormat + (new DirectoryInfo(fileFormat).GetFiles().Length + 1) + dialog.FileName.Substring(dialog.FileName.LastIndexOf('.'));
                File.Copy(dialog.FileName, name);
                editor.BodyHtml += "<iframe style='border: solid red 3px' id='" + name.Substring(name.LastIndexOf('/') + 1) + "' src='" + name + "' width='420' height='250' frameborder='0' allowfullscreen> </iframe>";
            }
        }

        private void EditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(editor.BodyText) || !string.IsNullOrEmpty(editor.BodyHtml))
            {
                DialogResult result = MessageBox.Show("Thông báo", "Tệp chưa được lưu. Lưu ngay?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    saveToolStripMenuItem_Click(this, EventArgs.Empty);
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void questionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                editor.BodyHtml += GenarateQuestionSet(dialog.FileName);
            }
        }

        private string GenarateQuestionSet(string path)
        {
            try
            {
                id_inc++;
                StreamReader streamReader = new StreamReader(path);
                string input = "var test" + id_inc + " = new Test(new Array());";
                int q_id = 0;
                while (!streamReader.EndOfStream)
                {
                    input += @"test" + id_inc + ".AddQuestion(new Question('question" + id_inc + "_" + q_id +
                        "','" + streamReader.ReadLine() +
                        "', " + streamReader.ReadLine() +
                        ", new Array('" + string.Join("','", streamReader.ReadLine().Split('|')) + "')" +
                        ",'" + streamReader.ReadLine() + "', 'obj_handicapping'));";
                    q_id++;
                }
                streamReader.Close();
                return @"<script type='text/javascript'>" + input + @" RenderTest(test" + id_inc + ", 'test" + id_inc + "'); </script>";
            }
            catch
            {
                MessageBox.Show("Thông báo", "File không đúng định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PreviewForm(editor.DocumentText).Show();
        }
    }
}