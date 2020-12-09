---
-api-id: P:Windows.Storage.StorageFolder.Path
-api-type: winrt property
---

<!-- Property syntax
public string Path { get; }
-->

# Windows.Storage.StorageFolder.Path

## -description
Gets the full path of the current folder in the file system, if the path is available.

## -property-value
The full path of the current folder in the file system, if the path is available.

## -remarks
Don't rely on this property to access a folder, because a file system path is not available for some folders. For example, in the following cases, the folder may not have a file system path, or the file system path may not be available.

+ The folder represents a container for a group of files (for example, the return value from some overloads of the [GetFoldersAsync](storagefolder_getfoldersasync_592765033.md) method) instead of an actual folder in the file system.
+ The folder is backed by a URI.
+ The folder was picked by using a file picker.


## -examples
The following example gets the app's installation folder and displays the value of the folder's Path.

```csharp
using Windows.Storage;
using System.Diagnostics; // For writing results to the Output window.

// Get the app's installation folder.
StorageFolder appFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;

// Print the folder's path to the Visual Studio Output window.
Debug.WriteLine(appFolder.Name + " folder path: " + appFolder.Path);
```

```cppwinrt
// Get the app's installation folder.
Windows::Storage::StorageFolder appFolder{ Windows::ApplicationModel::Package::Current().InstalledLocation() };

// Print the path to the debug window.
::OutputDebugString(appFolder.Path().c_str());
```

```cppcx
 // Get the app's installation folder
 StorageFolder^ appFolder = Windows::ApplicationModel::Package::Current->InstalledLocation;

 //Print the path to the debug window
 String^ path = appFolder->Path;
 OutputDebugString(path->Begin());
```

## -see-also
