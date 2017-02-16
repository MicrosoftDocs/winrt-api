---
-api-id: M:Windows.System.Threading.Core.SignalNotifier.AttachToEvent(System.String,Windows.System.Threading.Core.SignalHandler)
-api-type: winrt method
---

<!-- Method syntax
public Windows.System.Threading.Core.SignalNotifier AttachToEvent(System.String name, Windows.System.Threading.Core.SignalHandler handler)
-->

# Windows.System.Threading.Core.SignalNotifier.AttachToEvent

## -description
Attaches a [SignalHandler](signalhandler.md) delegate to an event. The delegated method will run the next time the event occurs.

## -parameters
### -param name
Indicates the event that causes the method to run.

### -param handler
Indicates the method that will run in response to the event.

## -returns
The resulting [SignalNotifier](signalnotifier.md) object.

## -remarks

## -examples

## -see-also
[AttachToEvent(String, SignalHandler, TimeSpan)](signalnotifier_attachtoevent_1081163191.md)