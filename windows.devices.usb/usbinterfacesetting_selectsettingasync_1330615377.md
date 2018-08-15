---
-api-id: M:Windows.Devices.Usb.UsbInterfaceSetting.SelectSettingAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SelectSettingAsync()
-->

# Windows.Devices.Usb.UsbInterfaceSetting.SelectSettingAsync

## -description
Selects the alternate setting as the current setting in the USB interface.

## -returns
An [IAsyncAction](../windows.foundation/iasyncaction.md) object that is used to control the asynchronous operation.

## -remarks
[SelectSettingAsync](usbinterfacesetting_selectsettingasync_1330615377.md) disables the endpoints of the previous alternate setting and removes the pipes associated with them from the [UsbInterface](usbinterface.md) object. The method enables the endpoints of this setting, and adds the associated pipes to the [UsbInterface](usbinterface.md) object.

## -examples

## -see-also
