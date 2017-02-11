---
-api-id: P:Windows.Storage.StorageFolder.Attributes
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.FileAttributes Attributes { get; }
-->

# Windows.Storage.StorageFolder.Attributes

## -description
Gets the attributes of the current folder.

## -property-value
The attributes of the current folder.

## -remarks

## -examples
The following example shows how to check the attributes of a folder.

```csharp
using Windows.Storage;
using System.Diagnostics; // For writing results to the Output window.

// Get the app's installation folder.
StorageFolder appFolder =
    Windows.ApplicationModel.Package.Current.InstalledLocation;

// Get the folder's attributes.
FileAttributes folderAttributes = appFolder.Attributes;

// Check the folder's attributes.
// Write the results to the Visual Studio Output window.
if ((folderAttributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
    Debug.WriteLine("The item is read-only.");
if ((folderAttributes & FileAttributes.Directory) == FileAttributes.Directory)
    Debug.WriteLine("The item is a folder.");
if ((folderAttributes & FileAttributes.Archive) == FileAttributes.Archive)
    Debug.WriteLine("The item is archived.");
if ((folderAttributes & FileAttributes.Temporary) == FileAttributes.Temporary)
    Debug.WriteLine("The item is temporary.");
```



## -see-also
