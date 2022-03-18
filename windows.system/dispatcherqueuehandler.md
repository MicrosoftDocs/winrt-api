---
-api-id: T:Windows.System.DispatcherQueueHandler
-api-type: winrt delegate
---

<!-- Delegate syntax.
public delegate void DispatcherQueueHandler()
-->

# Windows.System.DispatcherQueueHandler


## -description

A callback that will be executed on the **DispatcherQueue** thread.

Equivalent WinUI delegate: [Microsoft.System.DispatcherQueueHandler](/windows/winui/api/microsoft.system.dispatcherqueuehandler).

## -remarks

## -see-also

## -examples

```csharp
Windows.System.DispatcherQueueHandler handler = () =>
                                {
                                    // code for DispatcherQueue to run
                                };
```

