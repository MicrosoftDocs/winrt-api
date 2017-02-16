---
-api-id: M:Windows.System.Threading.Core.SignalNotifier.AttachToSemaphore(System.String,Windows.System.Threading.Core.SignalHandler,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Windows.System.Threading.Core.SignalNotifier AttachToSemaphore(System.String name, Windows.System.Threading.Core.SignalHandler handler, Windows.Foundation.TimeSpan timeout)
-->

# Windows.System.Threading.Core.SignalNotifier.AttachToSemaphore

## -description
Attaches a [SignalHandler](signalhandler.md) delegate to a named semaphore and specifies a timeout value. The delegated method will run when the named semaphore is signaled, or if the time span elapses before the semaphore reaches a signaled state.

## -parameters
### -param name
Names the semaphore that signals the method to run.

### -param handler
Indicates the delegate that will run in response to the named semaphore entering the signaled state.

### -param timeout
Indicates the amount of time to continue waiting for the named semaphore before running the delegate.

## -returns
The resulting [SignalNotifier](signalnotifier.md) object.

## -remarks

## -examples

## -see-also
[AttachToSemaphore(String, SignalHandler)](signalnotifier_attachtosemaphore_456511984.md)