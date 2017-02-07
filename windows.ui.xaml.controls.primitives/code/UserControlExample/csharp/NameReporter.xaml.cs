//<Snippet2>
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UserControlExample
{
    public partial class NameReporter : UserControl
    {
        public NameReporter()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder displayText = new StringBuilder("Hello, ");
            displayText.AppendFormat("{0} {1}.", firstName.Text, lastName.Text);

            //MessageBox.Show(displayText.ToString());
        }
    }
}
//</Snippet2>