---
-api-id: T:Windows.Storage.KnownFolders
-api-type: winrt class
---

<!-- Class syntax.
public class KnownFolders 
-->

# Windows.Storage.KnownFolders

## -description

Provides access to common locations that contain user content. This includes content from a user's local libraries (such as Documents, Pictures, Music, and Videos), HomeGroup, removable devices, and media server devices.

## -remarks

This class is static and cannot be instantiated. Access its properties directly, as shown in the following example.

+ `StorageFolder storageFolder = KnownFolders.PicturesLibrary;`

### Prerequisites

To access the folders and libraries represented by the properties of this class, specify the corresponding capabilities in your app manifest. For example, to access **KnownFolders.PicturesLibrary**, specify the **Pictures Library** capability in the app manifest. Learn more about capabilities in [App capability declarations](/windows/uwp/packaging/app-capability-declarations).

### Return value

The properties of the KnownFolders class return a [StorageFolder](storagefolder.md). To work with the known folder and its contents, call the methods and properties of the [StorageFolder](storagefolder.md) class.

+ For info about how to use pictures, music, and videos in your app, see [Audio, video, and camera](/windows/uwp/audio-video-camera/index).
+ For general info about how to use files and folders, see [Enumerate and query files and folders](/windows/uwp/files/quickstart-listing-files-and-folders).

### More info

Here's how to access some other commonly used locations.

+ Get the app's local folder from the [Windows.Storage.ApplicationData.Current.LocalFolder](applicationdata_localfolder.md) property.
+ Get the app's installation folder from the [Windows.ApplicationModel.Package.Current.InstalledLocation](../windows.applicationmodel/package_installedlocation.md) property.

To learn more about the locations that your app can access, see [File access permissions](/windows/uwp/files/file-access-permissions).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | GetFolderForUserAsync |
| 2004 | 19041 | GetFolderAsync |
| 2004 | 19041 | RequestAccessAsync |
| 2004 | 19041 | RequestAccessForUserAsync |

## -examples

The [File access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess) shows you how to use the [PicturesLibrary](knownfolders_pictureslibrary.md) property to create a new file in the Pictures library.

```csharp
StorageFolder storageFolder = KnownFolders.PicturesLibrary;
StorageFile file = await storageFolder.CreateFileAsync("sample.png", CreationCollisionOption.ReplaceExisting);
// Do something with the new file.
```

After the [CreateFileAsync](storagefolder_createfileasync_1058061470.md) method completes, the `file` variable contains a [StorageFile](storagefile.md) that represents the new file.

## -see-also

[File access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess), [File access permissions](/windows/uwp/files/file-access-permissions), [Enumerate and query files and folders](/windows/uwp/files/quickstart-listing-files-and-folders), [StorageFile class](storagefile.md), [StorageFolder class](storagefolder.md), [Windows.Storage.Search namespace](../windows.storage.search/windows_storage_search.md), [HomeGroup sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HomeGroup)