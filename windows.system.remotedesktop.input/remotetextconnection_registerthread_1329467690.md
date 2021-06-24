---
-api-id: M:Windows.System.RemoteDesktop.Input.RemoteTextConnection.RegisterThread(System.UInt32)
-api-type: winrt method
---

# Windows.System.RemoteDesktop.Input.RemoteTextConnection.RegisterThread(System.UInt32)

<!--
public void RegisterThread (uint threadId);
-->


## -description

Registers a thread on which the Remote Desktop client application will present remote UI.

## -parameters

### -param threadId

The ID of a thread on which a remote application's content will be presented.

## -remarks

When a registered thread becomes foreground, built-in input methods provided by Windows will communicate with the [RemoteTextConnection](remotetextconnection.md) that the thread was registered on, instead of with the local window. All local UI hosted on threads that have not been registered for text input virtualization via this method will continue to work with built-in input methods provided by Windows.

If a Remote Desktop client application hosts local and remote UI on the same thread, it may be necessary for the application to disable text input virtualization via the [IsEnabled](remotetextconnection_isenabled.md) property while the local UI is in focus.

## -see-also

[UnregisterThread](remotetextconnection_unregisterthread_925280970.md)

## -examples
