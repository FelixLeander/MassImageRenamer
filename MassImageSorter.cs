using System.ComponentModel;

namespace MassImageSorter;

public partial class MassImageSorter : Form
{
    private string? _lastPath;
    private FileInfo _currentPicutre = new(@"G:\placeholder.txt"); //A fix for a nullable error. Dosen't even matter if you have a G drive
    private readonly BindingList<FileInfo> _bindingList = new();
    private readonly BindingSource _bindingSource = new();
    public MassImageSorter() => InitializeComponent();

    private void Form1_Load(object sender, EventArgs e)
    {
        _bindingSource.DataSource = _bindingList;
        listBoxImageFiles.DataSource = _bindingSource;
        listBoxImageFiles.DisplayMember = "Name";
        listBoxImageFiles.ValueMember = "Fullname";
    }

    private void ButtonBrowseFolder_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog folderBrowserDialog = new()
        {
            AutoUpgradeEnabled = true,
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
            ShowNewFolderButton = true,
        };

        if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
            return;

        textBoxPath.Text = folderBrowserDialog.SelectedPath;

        if (folderBrowserDialog.SelectedPath.Equals(_lastPath))
            TextBoxPath_TextChanged(null, null);

        _lastPath = folderBrowserDialog.SelectedPath;
    }

    private void TextBoxPath_TextChanged(object? sender, EventArgs? e)
    {
        string path = textBoxPath.Text;
        if (!Directory.Exists(path))
        {
            textBoxPath.BackColor = Color.OrangeRed;
            return;
        }
        textBoxPath.BackColor = Color.LightGreen;

        _bindingList.Clear();
        string[] supportedFileTypes = new string[] { ".jpg", ".jpeg", ".png", ".gif", ".tiff", ".bmp", ".svg" };
        Directory.GetFiles(path).Select(filePath => new FileInfo(filePath))
            .Where(w => supportedFileTypes.FirstOrDefault(f => w.Extension.Equals(f, StringComparison.OrdinalIgnoreCase)) is not null)
            .ToList().ForEach(f => _bindingList.Add(f));

        _ = listBoxImageFiles.Focus();
    }

    private void ListBoxImageFiles_SelectedValueChanged(object sender, EventArgs e)
    {
        if (listBoxImageFiles.SelectedValue is null)
            return;

        _currentPicutre = new FileInfo($"{listBoxImageFiles.SelectedValue}");

        labelFileExtension.Text = _currentPicutre.Extension;
        textBox1.Text = Path.GetFileNameWithoutExtension(_currentPicutre.Name);
        pictureBoxMain.ImageLocation = _currentPicutre.FullName;
    }

    private void ButtonSkipRename_Click(object sender, EventArgs e)
    {
        if (_bindingList is null || _currentPicutre is null || string.IsNullOrWhiteSpace(_currentPicutre.Name))
            return;

        bool lel = _bindingList.Remove(_bindingList.FirstOrDefault(f => f.Name.Equals(_currentPicutre.Name)) ?? new(@"G:\placeholder.txt")); //A fix for a nullable error. Dosen't even matter if you have a G drive
        labelListTop.Text = $"{_bindingList.Count}";
    }

    private void ButtonRenameFile_Click(object sender, EventArgs e)
    {
        if (_bindingList is null || _currentPicutre is null)
            return;

        if (_currentPicutre.DirectoryName is null)
        {
            _ = MessageBox.Show($"Did you move or rename the folder the files are in?{Environment.NewLine} Closing the app...");
            Close();
            return;
        }

        try
        {
            File.Move(_currentPicutre.FullName, $"{Path.Combine(_currentPicutre.DirectoryName, textBox1.Text)}{_currentPicutre.Extension}");
        }
        catch (Exception ex)
        {
            _ = MessageBox.Show($"There was an Error renaming the file. If this happens all the time, try starting this app as admin.{Environment.NewLine}Error Message:{Environment.NewLine}{ex.Message}");
        }
    }
}