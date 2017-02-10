---
-api-id: M:Windows.System.Threading.Core.SignalNotifier.AttachToEvent(System.String,Windows.System.Threading.Core.SignalHandler,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Windows.System.Threading.Core.SignalNotifier AttachToEvent(System.String name, Windows.System.Threading.Core.SignalHandler handler, Windows.Foundation.TimeSpan timeout)
-->

# Windows.System.Threading.Core.SignalNotifier.AttachToEvent

## -description
Attaches a [SignalHandler](signalhandler.md) delegate to an event. The delegated method will run if the event occurs or the time span elapses, whichever comes first.

## -parameters
### -param name
Indicates the event that causes the method to run.

### -param handler
Indicates the method that will run in response to the event, or when the time span elapses, whichever comes first.

### -param timeout
Indicates the amount of time to continue waiting for the event before running the *handler* method.

## -returns
The resulting [SignalNotifier](signalnotifier.md) object.

## -remarks

## -examples

## -see-also
[AttachToEvent(String, SignalHandler)](signalnotifier_attachtoevent_1791480953.md)