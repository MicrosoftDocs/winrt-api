---
-api-id: P:Windows.Devices.Usb.UsbBulkOutPipe.OutputStream
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.IOutputStream OutputStream { get; }
-->

# Windows.Devices.Usb.UsbBulkOutPipe.OutputStream

## -description
Gets an output stream to which the app can write data to send to the endpoint.

## -property-value
The output steam that contains the transfer data.

## -remarks
To write data, first get the output stream from the pipe by using [OutputStream](usbinterruptoutpipe_outputstream.md) property and then use the [DataWriter](../windows.storage.streams/datawriter.md) object to write the actual buffer.

```
    Windows::Storage::Streams::Buffer^ buffer = ref new Windows::Storage::Streams::Buffer(TRANSFER_SIZE);  
  
    buffer->Length = TRANSFER_SIZE;  
  
    auto stream = DeviceList::Current->Fx2Device->Configuration->UsbInterfaces->GetAt(0)->BulkOutPipes->GetAt(0)->OutputStream;  
  
    Windows::Storage::Streams::DataWriter^ writer = ref new Windows::Storage::Streams::DataWriter(stream);  
  
    writer->WriteBuffer(buffer);  
  
 
    });  

```



## -examples

## -see-also
