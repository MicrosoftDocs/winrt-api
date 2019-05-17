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
For example, if a file or folder is stored on Microsoft OneDrive, StorageProvider will contain a display name, id, and thumbnail for Microsoft OneDrive.

Typically, you access StorageProvider objects as the result of calls to asynchronous methods and functions.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | IsPropertySupportedForPartialFileAsync |

## -examples

## -see-also
