---
-api-id: M:Windows.Storage.Streams.FileRandomAccessStream.OpenForUserAsync(Windows.System.User,System.String,Windows.Storage.FileAccessMode,Windows.Storage.StorageOpenOptions,Windows.Storage.Streams.FileOpenDisposition)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<IRandomAccessStream> FileRandomAccessStream.OpenForUserAsync(User user, String filePath, FileAccessMode accessMode, StorageOpenOptions sharingOptions, FileOpenDisposition openDisposition)
-->

# Windows.Storage.Streams.FileRandomAccessStream.OpenForUserAsync

## -description
Opens a stream for a user to a file given a file path and the user's information. If the file does not exist, it can be created using FileOpenDisposition.

## -parameters
### -param user
The user account for opening the stream.

### -param filePath
A path to the file to be opened.

### -param accessMode
The permissions level to open the stream with. 

### -param sharingOptions
A bitwise combination of the enumeration values that specify options for opening the stream.

### -param openDisposition
An action to take on the file. 

## -returns
A stream to the specified file.

## -remarks

## -see-also

## -examples

