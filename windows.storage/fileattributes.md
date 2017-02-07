---
-api-id: T:Windows.Storage.FileAttributes
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.FileAttributes : uint
-->

# FileAttributes

## -description
Describes the attributes of a file or folder.

## -enum-fields
### -field Normal:0
The item is normal. That is, the item doesn't have any of the other values in the enumeration.

### -field ReadOnly:1
The item is read-only.

### -field Directory:16
The item is a directory.

### -field Archive:32
The item is archived.

### -field Temporary:256
The item is a temporary file.

### -field LocallyIncomplete:512
The item is locally incomplete. Windows only.


## -remarks
The [FileAttributes](fileattributes.md) enumeration is used with the [StorageFile.Attributes](storagefile_attributes.md) and [StorageFolder.Attributes](storagefolder_attributes.md) properties.


<!--{annotation author="miriamw" time="2/23/2012 7:37:53 PM"}TOEdit: Should I say Win32 or Desktop? Or both?-->

<!--{annotation author="miriamw" time="2/23/2012 7:37:23 PM"}TODO: Add link to Win32 file type attributes-->
The enumeration values match the Win32 file type attributes. Therefore the enumeration values correspond to the Win32 values, which are flags in base 2.

## -examples
The following example shows how to check the attributes of a folder.

```csharp
using Windows.Storage;
using System.Diagnostics; // For writing results to the Output window.

// Get the app's installation folder.
StorageFolder appFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;

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