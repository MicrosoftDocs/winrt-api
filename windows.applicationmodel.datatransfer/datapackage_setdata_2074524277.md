---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataPackage.SetData(System.String,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public void SetData(System.String formatId, System.Object value)
-->

# Windows.ApplicationModel.DataTransfer.DataPackage.SetData

## -description

Sets the data contained in the [DataPackage](datapackage.md) in a [RandomAccessStream](../windows.storage.streams/randomaccessstream.md) format.

## -parameters

### -param formatId

Specifies the format of the data. Set this value by using the [StandardDataFormats](standarddataformats.md) class.

### -param value

Specifies the content that the [DataPackage](datapackage.md) contains.

## -remarks

To add data with this method, your app must convert the data into an object. You must also specify a *formatId* that target apps can use to request the data. The target app can request this data only if it knows the *formatId*.

Use this method when you use a delegate function to share data. For more information, see [How to support pull operations](/previous-versions/windows/apps/hh770848(v=win.10)).

## -examples

The following example demonstrates how to use the **SetData** method to serialize a custom C# object into a **RandomAccessStream** and pass it to the **DataPackage**. It also shows how to deserialize the data back to the original object type by using [GetDataAsync](datapackageview_getdataasync_225712847.md).

```csharp
using System;
using System.IO;
using System.Runtime.Serialization;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage.Streams;

// Define a custom class to serialize
[DataContract]
public class PersonData
{
    [DataMember]
    public string Name { get; set; }
    
    [DataMember]
    public int Age { get; set; }
    
    [DataMember]
    public string Email { get; set; }
}

// Method to serialize object and set data in DataPackage
private async Task<DataPackage> CreateDataPackageWithSerializedObject()
{
    // Create sample data
    var person = new PersonData
    {
        Name = "John Doe",
        Age = 30,
        Email = "john.doe@example.com"
    };

    // Serialize the object to a RandomAccessStream
    var stream = await SerializeObjectToStreamAsync(person);
    
    // Create DataPackage and set the serialized data
    var dataPackage = new DataPackage();
    dataPackage.SetData("application/x-custom-person", stream);
    
    return dataPackage;
}

// Helper method to serialize an object to InMemoryRandomAccessStream
private async Task<InMemoryRandomAccessStream> SerializeObjectToStreamAsync<T>(T obj)
{
    // Create a DataContractSerializer for the object type
    var serializer = new DataContractSerializer(typeof(T));
    
    // Create a memory stream to hold the serialized data
    using (var memoryStream = new MemoryStream())
    {
        // Serialize the object to the memory stream
        serializer.WriteObject(memoryStream, obj);
        
        // Create an InMemoryRandomAccessStream and copy the data
        var randomAccessStream = new InMemoryRandomAccessStream();
        var outputStream = randomAccessStream.GetOutputStreamAt(0);
        var dataWriter = new DataWriter(outputStream);
        
        // Write the serialized bytes to the random access stream
        dataWriter.WriteBytes(memoryStream.ToArray());
        await dataWriter.StoreAsync();
        await dataWriter.FlushAsync();
        
        // Reset position to beginning for reading
        randomAccessStream.Seek(0);
        
        dataWriter.Dispose();
        outputStream.Dispose();
        
        return randomAccessStream;
    }
}

// Method to deserialize data from DataPackageView back to original object
private async Task<T> DeserializeObjectFromDataAsync<T>(DataPackageView dataPackageView, string formatId)
{
    try
    {
        // Get the stream data from the DataPackageView
        var streamData = await dataPackageView.GetDataAsync(formatId);
        var randomAccessStream = streamData as IRandomAccessStream;
        
        if (randomAccessStream == null)
            throw new InvalidOperationException("Data is not in the expected stream format");
        
        // Create a DataContractSerializer for the target type
        var serializer = new DataContractSerializer(typeof(T));
        
        // Convert RandomAccessStream to a regular .NET Stream for deserialization
        var inputStream = randomAccessStream.GetInputStreamAt(0);
        var dataReader = new DataReader(inputStream);
        
        // Read all bytes from the stream
        var bytesLoaded = await dataReader.LoadAsync((uint)randomAccessStream.Size);
        var bytes = new byte[bytesLoaded];
        dataReader.ReadBytes(bytes);
        
        // Deserialize from memory stream
        using (var memoryStream = new MemoryStream(bytes))
        {
            var deserializedObject = (T)serializer.ReadObject(memoryStream);
            return deserializedObject;
        }
    }
    catch (Exception ex)
    {
        throw new InvalidOperationException($"Failed to deserialize object: {ex.Message}", ex);
    }
}

// Example usage demonstrating the complete round-trip
private async Task ExampleUsageAsync()
{
    // Create DataPackage with serialized object
    var dataPackage = await CreateDataPackageWithSerializedObject();
    
    // Simulate getting the data back (e.g., from clipboard or sharing operation)
    var dataPackageView = dataPackage.GetView();
    
    // Deserialize the object back to its original type
    var retrievedPerson = await DeserializeObjectFromDataAsync<PersonData>(
        dataPackageView, "application/x-custom-person");
    
    // Use the deserialized object
    Console.WriteLine($"Name: {retrievedPerson.Name}, Age: {retrievedPerson.Age}, Email: {retrievedPerson.Email}");
}
```

This example shows how to:

1. **Serialization**: Use **DataContractSerializer** to serialize a custom object and convert it to an **InMemoryRandomAccessStream** suitable for **SetData**.
1. **Setting Data**: Call **SetData** with a custom format identifier and the serialized stream.
1. **Deserialization**: Retrieve the data by using **GetDataAsync** and deserialize it back to the original object type.
1. **Error Handling**: Implement basic error handling for serialization and deserialization operations.

> [!NOTE]
> This example uses **DataContractSerializer**, which is safer and more modern than the deprecated **BinaryFormatter**. To ensure proper serialization support, add the `[DataContract]` and `[DataMember]` attributes to your custom classes.

## -see-also

[GetDataAsync](datapackageview_getdataasync_225712847.md)
