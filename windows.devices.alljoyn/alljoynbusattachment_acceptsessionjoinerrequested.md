---
-api-id: E:Windows.Devices.AllJoyn.AllJoynBusAttachment.AcceptSessionJoinerRequested
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax.
public event TypedEventHandler AcceptSessionJoinerRequested<AllJoynBusAttachment, AllJoynAcceptSessionJoinerEventArgs>
-->

# Windows.Devices.AllJoyn.AllJoynBusAttachment.AcceptSessionJoinerRequested

## -description
Occurs when a remote AllJoyn endpoint requests to join the bus attachement's session.

## -remarks

**Sender:** The [AllJoynBusAttachment](alljoynbusattachment.md) that raised the event.

**Args:** The [AllJoynAcceptSessionJoinerEventArgs](alljoynacceptsessionjoinereventargs.md) object that represents the requesting endpoint.

If the app *does not* handle this event, the request is accepted by default.

If the app *does* handle this event, it is rejected by default. The app MUST invoke args.Accept() before exiting the handle to accept the session join request.

## -see-also

## -examples

## -capabilities
allJoyn