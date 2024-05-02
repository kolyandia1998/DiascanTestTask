using DiascanTestTask.DB.Models;
using DiascanTestTask.HashCalculator;

namespace DiascanTestTask
{
    public partial class Form1 : Form
    {
        public Form1(IHashCalculator hashCalculator)
        {
            this.hashCalculator = hashCalculator;
            InitializeComponent();
        }

        private IHashCalculator hashCalculator;

        private async void button1_Click(object sender, EventArgs e)
        {
            List<Task> tasks = new List<Task>();
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            var files = textBox1.Text.Split('|');
            foreach (var file in files)
            {
                var task = Task.Run(() =>
                {
                    using var db = new DB.ApplicationContext();
                    var hash = hashCalculator.CalculateHash(file);
                    var model = new DataModel { Hash = hash, FileName = file };
                    if (db.dataModels.Contains(model))
                        return;
                    db.dataModels.Add(model);
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
                textBox1.Text = string.Join('|', openFileDialog1.FileNames);
            }
        }
    }
}