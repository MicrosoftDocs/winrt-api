---
-api-id: M:Windows.Storage.IStorageFile2.OpenTransactedWriteAsync(Windows.Storage.StorageOpenOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageStreamTransaction> OpenTransactedWriteAsync(Windows.Storage.StorageOpenOptions options)
-->

# Windows.Storage.IStorageFile2.OpenTransactedWriteAsync

## -description
Opens a random-access stream to the file that can be used for transacted-write operations with the specified options.

## -parameters
### -param options
A bitwise combination of the enumeration values that specify options for opening the stream.

## -returns
When this method completes, it returns a [StorageStreamTransaction](storagestreamtransaction.md) containing the random-access stream and methods that can be used to complete transactions. 

## -remarks
This method results in a stream that writes to a temporary file, then atomically commits the writes to the actual file by renaming the temporary file onto the actual file. Because of how the stream writing works, a transacted writer cannot coexist with another writer, meaning StorageOpenOptions.AllowReadersAndWriters is not valid for this method and will return E_INVALIDARG if used.

## -examples

## -see-also

