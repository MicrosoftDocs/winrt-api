---
-api-id: T:Windows.Storage.StorageProvider
-api-type: winrt class
---

<!-- Class syntax.
public class StorageProvider : Windows.Storage.IStorageProvider
-->

# Windows.Storage.StorageProvider

## -description

Contains info about the service that stores files and folders. Files and folders may be stored either by the local file system or by a remote service like Microsoft OneDrive.

## -remarks

For example, if a file or folder is stored on Microsoft OneDrive, **StorageProvider** will contain a display name, id, and thumbnail for Microsoft OneDrive.

Typically, you access **StorageProvider** objects as the result of calls to asynchronous methods and functions. They can also be accessed through properties of other file and folder objects such as the [IStorageItemPropertiesWithProvider.Provider](istorageitempropertieswithprovider_provider.md), [StorageFile.Provider](storagefile_provider.md), and [StorageFolder.Provider](storagefolder_provider.md) properties.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | IsPropertySupportedForPartialFileAsync |

## -examples

The following example demonstrates how to get the **StorageProvider** for a local file:

```csharp
using Windows.Storage;
using Windows.Storage.Provider;

// Get the file
StorageFile file = await StorageFile.GetFileFromPathAsync("C:\\example\\example.txt");

// Get the provider for the file
StorageProvider provider = file.Provider;
```

## -see-also

 [StorageFile.Provider](storagefile_provider.md), [StorageFolder.Provider](storagefolder_provider.md), [IStorageItemPropertiesWithProvider.Provider](istorageitempropertieswithprovider_provider.md)
