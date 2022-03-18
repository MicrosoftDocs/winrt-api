---
-api-id: T:Windows.Storage.StorageStreamTransaction
-api-type: winrt class
---

<!-- Class syntax.
public class StorageStreamTransaction : Windows.Foundation.IClosable, Windows.Storage.IStorageStreamTransaction
-->

# Windows.Storage.StorageStreamTransaction

## -description
Represents a write transaction for a random-access stream.

## -remarks


## -examples
The [File Access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess) shows you how to use a StorageStreamTransaction object to perform a transacted write operation on a file.

```csharp
try
{
    if (file != null)
    {
        using (StorageStreamTransaction transaction = await file.OpenTransactedWriteAsync())
        {
            using (DataWriter dataWriter = new DataWriter(transaction.Stream))
            {
                dataWriter.WriteString("Swift as a shadow");
                transaction.Stream.Size = await dataWriter.StoreAsync(); // reset stream size to override the file
                await transaction.CommitAsync();
            }
        }
    }
}
// Use catch blocks to handle errors
catch (FileNotFoundException)
{
    // For example, handle a file not found error
}
```

In the example, `file` is a local variable that contains a [StorageFile](storagefile.md) that represents the file to write.

## -see-also
[File Access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess), [IClosable](../windows.foundation/iclosable.md)