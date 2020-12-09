---
-api-id: M:Windows.Storage.StorageFolder.TryGetItemAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.IStorageItem> TryGetItemAsync(System.String name)
-->

# Windows.Storage.StorageFolder.TryGetItemAsync

## -description
Tries to get the file or folder with the specified name from the current folder. Returns **null** instead of raising a **FileNotFoundException** if the specified file or folder is not found.

## -parameters
### -param name
The name (or path relative to the current folder) of the file or folder to get.

## -returns
When this method completes successfully, it returns an [IStorageItem](istorageitem.md) that represents the specified file or folder. If the specified file or folder is not found, this method returns **null** instead of raising an exception.

To work with the returned item, call the [IsOfType](istorageitem_isoftype_1417811226.md) method of the [IStorageItem](istorageitem.md) interface to determine whether the item is a file or a folder. Then cast the item to a [StorageFolder](storagefolder.md) or [StorageFile](storagefile.md).

## -remarks
Call the TryGetItemAsync method to try to get a file or folder by name, or to check whether a file or folder exists, without the need to handle a **FileNotFoundException**. If the file or folder can't be found, TryGetItemAsync returns **null** instead of raising an exception.

Call the [IsOfType](istorageitem_isoftype_1417811226.md) method of the [IStorageItem](istorageitem.md) interface to determine whether the returned item is a file or a folder.

## -examples
The following example shows how to try to get a single file or folder from the current folder, or to check whether the file or folder exists, by calling the TryGetItemAsync method.

```csharp
using Windows.Storage;
using System.Threading.Tasks;
using System.Diagnostics; // For writing results to Output window.

// Get the path to the app's Assets folder.
string root = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
string path = root + @"\Assets";

// Get the app's Assets folder.
StorageFolder assetsFolder = await StorageFolder.GetFolderFromPathAsync(path);

// Check whether an image with the specified scale exists.
string imageName = "Logo.scale-140.png";
if (await assetsFolder.TryGetItemAsync(imageName) != null)
    Debug.WriteLine(imageName + " exists.");
else  // Return value of TryGetItemAsync is null.
    Debug.WriteLine(imageName + " does not exist.");
```

```cppwinrt
IAsyncAction MainPage::ExampleCoroutineAsync()
{
    std::wstring imageName{ L"Wide310x150Logo.scale-200.png" };

    // Get the path to the app's Assets folder.
    std::wstring path{ Windows::ApplicationModel::Package::Current().InstalledLocation().Path() + L"\\Assets" };

    // Get the folder object that corresponds to this absolute path in the file system.
    Windows::Storage::StorageFolder assets{ co_await Windows::Storage::StorageFolder::GetFolderFromPathAsync(path) };
    IStorageItem image{ co_await assets.TryGetItemAsync(imageName) };

    std::wstring output;
    if (image)
    {
        output = L"File: " + image.Name() + L" found \n";
    }
    else
    {
        output = L"File not found\n";
    }
    ::OutputDebugString(output.c_str());
}
```

```cppcx
String^ imageName = "Logo.scale-140.png";
// Get the app'ss Assets folder
String^ path = Windows::ApplicationModel::Package::Current->InstalledLocation->Path + "\\Assets";

create_task(StorageFolder::GetFolderFromPathAsync(path)).then([=](StorageFolder^ assets) -> task < IStorageItem^ > 
{
 return create_task(assets->TryGetItemAsync(imageName));
}).then([=](IStorageItem^ image) {
 String^ output = "";
 if (image == nullptr)
 {
  output = "File not found\n";
 }
 else
 {
  //output = "File: " + image->Name + " found \n";
 }
 OutputDebugString(output->Begin());
});
```

## -see-also
[GetItemAsync](storagefolder_getitemasync_1847090456.md)
