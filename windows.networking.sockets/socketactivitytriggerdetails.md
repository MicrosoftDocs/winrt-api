---
-api-id: T:Windows.Networking.Sockets.SocketActivityTriggerDetails
-api-type: winrt class
---

<!-- Class syntax.
public class SocketActivityTriggerDetails : Windows.Networking.Sockets.ISocketActivityTriggerDetails
-->

# Windows.Networking.Sockets.SocketActivityTriggerDetails

## -description
A object instantiated by the background broker infrastructure and used by an app to retrieve details when a [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md) occurs.

## -remarks
The [SocketActivityTriggerDetails](socketactivitytriggerdetails.md) object is used by an app to retrieve the [SocketActivityInformation](socketactivityinformation.md) object for the socket that caused a [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md) to occur, and to get the reason that the trigger occurred.

A [SocketActivityTriggerDetails](socketactivitytriggerdetails.md) instance is created when the background task for a socket signals a [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md). (See the [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md) class page for details on how to create a background task and transfer ownership of a socket to a socket broker for background listening.)

## -examples

## -see-also
[SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md), [SocketActivityInformation](socketactivityinformation.md), [SocketActivityTriggerReason](socketactivitytriggerreason.md)