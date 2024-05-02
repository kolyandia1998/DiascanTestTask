using DiascanTestTask.DB.Models;
using DiascanTestTask.HashCalculator;

namespace DiascanTestTask;

public partial class MainForm : Form
{
    public MainForm(IHashCalculator hashCalculator)
    {
        this._hashCalculator = hashCalculator;
        InitializeComponent();
    }

    private string[]? _files;

    private IHashCalculator _hashCalculator;

    private async void button1_Click(object sender, EventArgs e)
    {
        List<Task> tasks = new List<Task>();
        if (_files == null)
        {
            return;
        }
        foreach (var file in _files)
        {
            var task = Task.Run(() =>
            {
                using var db = new DB.ApplicationContext();
                var hash = _hashCalculator.CalculateHash(file);
                var model = new DataModel { Hash = hash, FileName = file };
                if (db.DataModels.Contains(model))
                    return;
                db.DataModels.Add(model);
                db.SaveChanges();
            });
            tasks.Add(task);
        }
        await Task.WhenAll(tasks);
    }

    private void button2_click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            _files = openFileDialog1.FileNames;
            textBox1.Text = string.Join('|', openFileDialog1.FileNames);
        }
    }
}