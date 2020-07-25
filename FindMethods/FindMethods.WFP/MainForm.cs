using System.Windows.Forms;

namespace FindMethods.WFP
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      logicUI = new LogicUI();
    }

    //
    private void Setup() => lstBoxMethods.Items.Clear();

    //
    private readonly LogicUI logicUI;
    private void btnLoad_Click(object sender, System.EventArgs e)
    {
      Setup();
      logicUI.LoadSolution();

      var projects = logicUI.DisplayProjects();
      foreach (var project in projects)
        lstBoxMethods.Items.Add(project);
    }

    private void btnExit_Click(object sender, System.EventArgs e)
    {
      Application.Exit();
    }
  }
}
