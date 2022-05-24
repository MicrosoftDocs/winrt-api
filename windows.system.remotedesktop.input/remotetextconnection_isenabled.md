---
-api-id: P:Windows.System.RemoteDesktop.Input.RemoteTextConnection.IsEnabled
-api-type: winrt property
---

# Windows.System.RemoteDesktop.Input.RemoteTextConnection.IsEnabled

<!--
public bool IsEnabled { get; set; }
-->


## -description

Specifies whether text input virtualization is enabled for the Remote Desktop connection serviced by this **RemoteTextConnection** instance.

## -property-value

True if text input virtualization is enabled for the connection serviced by this **RemoteTextConnection** instance; otherwise, false.

## -remarks

If the Remote Desktop client application displays remote and local UI on the same thread, it may be desirable to set this value to false when the local UI has keyboard focus. This would enable built-in input methods provided by Windows to be used to enter text in the local UI. When this property is set to true, the built-in input methods will only work with the remote UI displayed on the foreground thread.

## -see-also

## -examples


