---
-api-id: T:Windows.System.Threading.Core.SignalHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void SignalHandler(Windows.System.Threading.Core.SignalNotifier signalNotifier, System.Boolean timedOut)
-->
# Windows.System.Threading.Core.SignalHandler

## -description
Represents a method that is called when a signal notifier's attached event or semaphore is signaled, or when the optional timeout value has elapsed (whichever comes first).

## -parameters
### -param signalNotifier
Represents the signal notifier that called the delegate.

### -param timedOut
Indicates whether *timeout* value elapsed before calling the delegate.


## -remarks

## -examples

## -see-also