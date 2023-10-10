---
-api-id: M:Windows.UI.Xaml.Hosting.WindowsXamlManager.Close
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void WindowsXamlManager.Close()
-->

# Windows.UI.Xaml.Hosting.WindowsXamlManager.Close

## -description
Closes and asynchronously releases any resources used by this [WindowsXamlManager](windowsxamlmanager.md).

## -remarks

The Close method operates asynchronously.
Before exiting the thread on which the WindowsXamlManager was initialized,
ensure that all asynchronous work has completed.
One way to do this is to call
[DispatcherQueueController.ShutdownQueueAsync](../windows.system/dispatcherqueuecontroller_shutdownqueueasync_542547627.md)
and await its completion.
In a desktop app, another way to do this is to run the top-level message pump until `PeekMessage` returns `FALSE`.

## -see-also

## -examples
