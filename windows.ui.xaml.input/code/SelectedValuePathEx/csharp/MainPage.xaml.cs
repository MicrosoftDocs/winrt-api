using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;


namespace SelectedValuePath
{
    //<snippetCodeBehind>
    public partial class MainPage : UserControl
    {

        public System.Collections.ObjectModel.ObservableCollection<Document> MyDocs =
            new System.Collections.ObjectModel.ObservableCollection<Document>();
        public MainPage()
        {
            InitializeComponent();

            // Add items to the collection.
            MyDocs.Add(new Document("How to: Use SelectedValuePath"));
            MyDocs.Add(new Document("DataGrid Overview"));
            MyDocs.Add(new Document("Silverlight Designer Overview"));
            comboBox1.DataContext = MyDocs;
            textBlock2.DataContext = comboBox1;
        }
    }

    // Simple business object.
    public class Document
    {
        public Document() { }
        public Document(string docName)
        {
            ID = Guid.NewGuid();
            Name = docName;
        }
        public string Name { get; set; }
        public Guid ID { get; set; }

    }
    //</snippetCodeBehind>
}
