---
-api-id: M:Windows.System.Threading.Core.SignalNotifier.AttachToSemaphore(System.String,Windows.System.Threading.Core.SignalHandler)
-api-type: winrt method
---

<!-- Method syntax
public Windows.System.Threading.Core.SignalNotifier AttachToSemaphore(System.String name, Windows.System.Threading.Core.SignalHandler handler)
-->

# Windows.System.Threading.Core.SignalNotifier.AttachToSemaphore

## -description
Attaches a [SignalHandler](signalhandler.md) delegate to a named semaphore. The delegated method will run when the named semaphore is signaled.

## -parameters
### -param name
Names the semaphore that signals the method to run.

### -param handler
Indicates the delegate that will run in response to the named semaphore entering the signaled state.

## -returns
The resulting [SignalNotifier](signalnotifier.md) object.

## -remarks

## -examples

## -see-also
[AttachToSemaphore(String, SignalHandler, TimeSpan)](signalnotifier_attachtosemaphore_830683200.md)