using Windows.Media.Protection;
using Windows.Media.Protection.PlayReady;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PlayReadyStaticsSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            //<SnippetSetUpMediaProtectionManager>
            MediaProtectionManager protectionManager = new MediaProtectionManager();
            protectionManager.Properties.Add(
                "Windows.Media.Protection.MediaProtectionContainerGuid", 
                PlayReadyStatics.ProtectionSystemId.ToString());
            Windows.Foundation.Collections.PropertySet cpSystems = 
                new Windows.Foundation.Collections.PropertySet();
            cpSystems.Add(
                PlayReadyStatics.MediaProtectionSystemId.ToString(), 
                PlayReadyStatics.InputTrustAuthorityToCreate);
            //</SnippetSetUpMediaProtectionManager>
        }
    }
}
