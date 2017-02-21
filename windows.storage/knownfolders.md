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


+ `    StorageFolder storageFolder = KnownFolders.PicturesLibrary;`


### Prerequisites

To access the folders and libraries represented by the properties of this class, specify the corresponding capabilities in your app manifest. For example, to access **KnownFolders.PicturesLibrary**, specify the **Pictures Library** capability in the app manifest. Learn more about capabilities in [App capability declarations](https://aka.ms/appcapabilitydeclarations).

### Return value

The properties of the [KnownFolders](knownfolders.md) class return a [StorageFolder](storagefolder.md). To work with the known folder and its contents, call the methods and properties of the [StorageFolder](storagefolder.md) class.

+ For info about how to use pictures, music, and videos in your app, see [Audio, video, and camera](http://msdn.microsoft.com/library/0fc12d26-f1cf-4da7-b5a7-735a5074b74a).
+ For general info about how to use files and folders, see [Enumerate and query files and folders](http://msdn.microsoft.com/library/4c59d5ac-58f7-4863-a884-e9e54228a5ad).


### More info

Here's how to access some other commonly used locations.

+ Get the app's local folder from the [Windows.Storage.ApplicationData.Current.LocalFolder](applicationdata_localfolder.md) property.
+ Get the app's installation folder from the [Windows.ApplicationModel.Package.Current.InstalledLocation](../windows.applicationmodel/package_installedlocation.md) property.
To learn more about the locations that your app can access, see [File access permissions](http://msdn.microsoft.com/library/3a404cc0-a997-45c8-b2e8-44745539759d).

## -examples
The [File access sample]( http://go.microsoft.com/fwlink/p/?linkid=231445) shows you how to use the [PicturesLibrary](knownfolders_pictureslibrary.md) property to create a new file in the Pictures library.

```csharp
StorageFolder storageFolder = KnownFolders.PicturesLibrary;
StorageFile file = await storageFolder.CreateFileAsync("sample.png", CreationCollisionOption.ReplaceExisting);
// Do something with the new file.
```

```javascript
Windows.Storage.KnownFolders.picturesLibrary.createFileAsync("sample.png", Windows.Storage.CreationCollisionOption.replaceExisting).done(
   function (file) {
       // Process file
   },
   // Handle errors with an error function
   function (error) {
       // Process errors
   }
);
```

After the [CreateFileAsync](storagefolder_createfileasync.md) method completes, the `file` variable contains a [StorageFile](storagefile.md) that represents the new file.

## -see-also
[File access sample]( http://go.microsoft.com/fwlink/p/?linkid=231445), [File access permissions](http://msdn.microsoft.com/library/3a404cc0-a997-45c8-b2e8-44745539759d), [Enumerate and query files and folders](http://msdn.microsoft.com/library/4c59d5ac-58f7-4863-a884-e9e54228a5ad), [StorageFile class](storagefile.md), [StorageFolder class](storagefolder.md), [Windows.Storage.Search namespace](../windows.storage.search/windows_storage_search.md), [HomeGroup sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620549)
