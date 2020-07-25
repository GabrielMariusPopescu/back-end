using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TreeView
{
    public partial class MainForm : RadForm
    {
        private RadTreeNode dragNode;

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            radTreeView1.ImageList = iconsList;
        }

        public MainForm()
        {
            InitializeComponent();
            radTreeView1.ItemHeight = 27;
            radTreeView2.ItemHeight = 27;
            radTreeView1.ExpandAnimation = ExpandAnimation.None;
            radTreeView2.ExpandAnimation = ExpandAnimation.None;
            radTreeView2.FullRowSelect = false;
            radTreeView1.FullRowSelect = false;
            radTreeView1.MultiSelect = true;
            radTextBox1.TextBoxElement.AllowDrop = true;
            var dragDropService1 = radTreeView1.TreeViewElement.DragDropService;
            var dragDropService2 = radTreeView2.TreeViewElement.DragDropService;
            dragDropService1.PreviewDragOver += DragDropService_PreviewDragOver;
            dragDropService2.PreviewDragOver += DragDropService_PreviewDragOver;
        }

        private void DragDropService_PreviewDragOver(object sender, RadDragOverEventArgs e)
        {
            var textBox = e.HitTarget as RadTextBoxElement;
            if (textBox == radTextBox1.TextBoxElement) e.CanDrop = true;
        }

        private void radTreeView1_DragEnded(object sender, RadTreeViewDragEventArgs e)
        {
            if (dragNode != null) radTextBox1.Text = dragNode.Text;
        }

        private void radTreeView1_ItemDrag(object sender, RadTreeViewEventArgs e) { dragNode = e.Node; }
    }
}