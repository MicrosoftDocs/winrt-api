using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SelectiveWipeSnippets
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        private async void TestButton_Click(object sender, RoutedEventArgs e)
        {
            var folder = await AddFolder("NewFolder1");
            var status = await Windows.Security.EnterpriseData.FileRevocationManager.GetStatusAsync(folder);
            var file = await AddFile("NewFile1.txt", folder);
            InitializeApp("testuser");
            var newFile = GetFileContents(file.Path);
        }

        //<Snippet_Global>
        ApplicationData appRootFolder = ApplicationData.Current;
        string enterpriseIdentity = "example.com";
        int AccessDeniedHResult = -2147024891;  // Access Denied (0x80070005)
        //</Snippet_Global>

        //<Snippet_Protect>
        // Add a folder and protect it using Selective Wipe.
        private async Task<StorageFolder> AddFolder(string folderName)
        {
            StorageFolder newFolder = await appRootFolder.LocalFolder.CreateFolderAsync(folderName);

            var status = await ProtectItem(newFolder, enterpriseIdentity);

            return newFolder;
        }

        // Add a file and protect it using Selective Wipe.
        private async Task<StorageFile> AddFile(string fileName, StorageFolder folder)
        {
            StorageFile newFile = await folder.CreateFileAsync(fileName);

            var status = 
                await Windows.Security.EnterpriseData.FileRevocationManager.
                    GetStatusAsync(newFile);

            if (status != Windows.Security.EnterpriseData.FileProtectionStatus.Protected)
            {
                status = await ProtectItem(newFile, enterpriseIdentity);
            }

            return newFile;
        }

        private async Task<Windows.Security.EnterpriseData.FileProtectionStatus> 
            ProtectItem(IStorageItem item, string enterpriseIdentity)
        {
            var status = 
                await Windows.Security.EnterpriseData.FileRevocationManager.
                    ProtectAsync(item, enterpriseIdentity);

            return status;
        }
        //</Snippet_Protect>

        //<Snippet_GetStatus>
        private async Task<IRandomAccessStream> GetFileContents(string filePath)
        {
            IRandomAccessStream stream = null;
            StorageFile file = null;

            try
            {
                file = await StorageFile.GetFileFromPathAsync(filePath);
                stream = await file.OpenReadAsync();
            }
            catch (UnauthorizedAccessException e)
            {
                if (e.HResult == AccessDeniedHResult)
                {
                    // Delete file if it has been revoked.
                    SelectiveWipeCleanup(file);
                }

                return null;
            }

            return stream;
        }

        // Delete items revoked by Selective Wipe.
        private async void SelectiveWipeCleanup(StorageFile file)
        {
            var status = await Windows.Security.EnterpriseData.FileRevocationManager.GetStatusAsync(file);
            if (status == Windows.Security.EnterpriseData.FileProtectionStatus.Revoked)
            {
                await file.DeleteAsync();
            }
        }
        //</Snippet_GetStatus>

        //<Snippet_Revoke>
        private void InitializeApp(string userName)
        {
            if (GetUserStatus(userName) == AppUserStatus.NotFound)
            {
                Windows.Security.EnterpriseData.FileRevocationManager.Revoke(enterpriseIdentity);
            }
        }
        //</Snippet_Revoke>

        private AppUserStatus GetUserStatus(string userName)
        {
            return AppUserStatus.NotFound;
        }

        //<Snippet_CopyProtection>
        public async Task<bool> CopyFile(StorageFile file, StorageFolder newFolder) 
        {
            bool result = false;

            try
            {
                var newFile = await file.CopyAsync(newFolder);
                result = await 
                    Windows.Security.EnterpriseData.FileRevocationManager.
                    CopyProtectionAsync(file, newFile);
                }
            catch (Exception e) 
            {
                // Handle exception. For example, copy already exists.
            }

            return result;
        }
        //</Snippet_CopyProtection>
    }

    public enum AppUserStatus
    {
        NotFound,
        Valid,
        Elevated
    }
}
