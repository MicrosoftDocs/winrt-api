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

This method operates asynchronously.

Ensure that all asynchronous work has completed before exiting the thread on which the WindowsXamlManager was initialized. Some ways to do this include:

- Calling [DispatcherQueueController.ShutdownQueueAsync](../windows.system/dispatcherqueuecontroller_shutdownqueueasync_542547627.md) and awaiting its completion.
- Running the top-level message pump until `PeekMessage` returns `FALSE`.

## -see-also

## -examples
