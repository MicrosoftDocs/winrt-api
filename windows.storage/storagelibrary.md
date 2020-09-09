---
-api-id: T:Windows.Storage.StorageLibrary
-api-type: winrt class
---

<!-- Class syntax.
public class StorageLibrary : Windows.Storage.IStorageLibrary, Windows.Storage.IStorageLibrary2, Windows.Storage.IStorageLibrary3
-->

# Windows.Storage.StorageLibrary

## -description

Lets you add and remove folders from a library like Music or Videos and lets you get a list of folders included in the library.

## -remarks

You can only access libraries that you have declared capabilities for in your app manifest. To learn more about capabilities see, [App capability declarations](/windows/uwp/packaging/app-capability-declarations).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | GetLibraryForUserAsync |
| 1607 | 14393 | ChangeTracker |
| 1709 | 16299 | AreFolderSuggestionsAvailableAsync |

## -examples

## -see-also

[Files and folders in the Music, Pictures, and Videos libraries](/windows/uwp/files/quickstart-managing-folders-in-the-music-pictures-and-videos-libraries),[Library management sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/LibraryManagement)
