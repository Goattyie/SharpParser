using System;
using System.Collections.Generic;
using Parser.Model.AliExpress;
using System.Windows.Forms;
using Parser.Model;

namespace Parser
{
    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser = new ParserWorker<string[]>(new HabrFreelance());
        public Form1()
        {
            InitializeComponent();
            parser.OnComplete += Parser_OnComplete;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            Listbox.Items.AddRange(arg2);
        }

        private void Parser_OnComplete(object obj)
        {
            MessageBox.Show("Процесс завершен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            parser.ParserSettings = new HabrFreelanceSettings((int)StartUpDown.Value, (int)EndUpDown.Value);
            parser.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            parser.End();
        }
    }
}
