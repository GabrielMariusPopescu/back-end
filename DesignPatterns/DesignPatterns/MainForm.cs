using DesignPatterns.Business;
using System;
using System.Windows.Forms;

namespace DesignPatterns
{
    public partial class MainForm : Form
    {
        public MainForm(IBusinessLogic businessLogic)
        {
            InitializeComponent();
            this.businessLogic = businessLogic;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var notes = businessLogic.ReadNotes();
        }

        //

        private readonly IBusinessLogic businessLogic;
    }
}
