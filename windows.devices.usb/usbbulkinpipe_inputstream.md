---
-api-id: P:Windows.Devices.Usb.UsbBulkInPipe.InputStream
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.IInputStream InputStream { get; }
-->

# Windows.Devices.Usb.UsbBulkInPipe.InputStream

## -description
Input stream that stores the data that the bulk IN pipe received from the endpoint.

## -property-value
Input stream that contains data read from the endpoint.

## -remarks
To access data read from a bulk IN pipe, get the input stream from the pipe, and then use the [DataReader](../windows.storage.streams/datareader.md) to read data.

```
  auto stream = DeviceList::Current->Fx2Device->Configuration->UsbInterfaces->GetAt(0)->BulkInPipes->GetAt(0)->InputStream;  
  
    Windows::Storage::Streams::DataReader^ reader = ref new Windows::Storage::Streams::DataReader(stream);  
  
    Concurrency::create_task(reader->LoadAsync(TRANSFER_SIZE))  
        .then ([this, reader] (uint32 result) 
    {  
  
           //Your code.  
  
  
    });

```



## -examples

## -see-also
