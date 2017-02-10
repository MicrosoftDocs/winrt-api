---
-api-id: T:Windows.Devices.Usb.UsbInterruptInEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class UsbInterruptInEventArgs : Windows.Devices.Usb.IUsbInterruptInEventArgs
-->

# Windows.Devices.Usb.UsbInterruptInEventArgs

## -description
Represents the object that is passed as a parameter to the event handler for the [DataReceived](usbinterruptinpipe_datareceived.md) event.

## -remarks
[UsbInterruptInEventArgs](usbinterruptineventargs.md) is used to access data from an interrupt IN pipe. When data arrives in an interrupt IN pipe, it raises the [DataReceived](usbinterruptinpipe_datareceived.md) event. You must register an event handler for the event. That event handler's parameter is a [UsbInterruptInEventArgs](usbinterruptineventargs.md) object. After the event handler is invoked, you can access the data by using the [InterruptData](usbinterruptineventargs_interruptdata.md) property. 



```
function onDataReceived(eventArgs) 
{ 
    /* Your code */ 
    var interruptData = eventArgs.interruptData;
}

```



## -examples

## -see-also
