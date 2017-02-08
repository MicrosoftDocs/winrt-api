---
-api-id: P:Windows.Devices.SerialCommunication.SerialDevice.OutputStream
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.IOutputStream OutputStream { get; }
-->

# Windows.Devices.SerialCommunication.SerialDevice.OutputStream

## -description
Gets an output stream to which the app can write data to transmit through the serial port.

## -property-value
The output steam that contains the transfer data.

## -remarks
To write data, first get the output stream from the [SerialDevice](serialdevice.md) object by using [OutputStream](serialdevice_outputstream.md) property and then use the [DataWriter](../windows.storage.streams/datawriter.md) object to write the actual buffer.

## -examples

## -see-also
