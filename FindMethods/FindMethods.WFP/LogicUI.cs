using FindMethods.BL;
using FindMethods.BL.Helper;
using System.Collections.Generic;
using System.Linq;

namespace FindMethods.WFP
{
  public class LogicUI
  {
    public LogicUI()
    {
      reader = new Reader();
      worker = new Worker();
    }

    public void LoadSolution()
    {
      var projects = reader.EnumerateAllDirectories(Constants.LS_COMMON_PATH);
      ProjectsNames = reader.GetProjectsNames(projects);
      var files = reader.GetProjectFiles(projects);
      Lines = reader.EnumerateAllLines(ProjectsNames, files);
    }


    public List<List<string>> DisplayProjects()
    {
      var definitions = worker.CreateDefinitions(Lines);
      return worker.EliminateUnknownDefinitions(definitions).ToList();
    }

    //
    private readonly Reader reader;
    private readonly Worker worker;

    private List<string> ProjectsNames { get; set; }
    private List<string> Lines { get; set; }
  }
}
