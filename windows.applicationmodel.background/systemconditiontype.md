---
-api-id: T:Windows.ApplicationModel.Background.SystemConditionType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Background.SystemConditionType : int
-->

# SystemConditionType

## -description
Specifies a system condition that must be in effect for a background task to run. If a background task with a system condition is triggered, the task will not run until the condition is met.

## -enum-fields
### -field Invalid:0
Not a valid condition type.

### -field UserPresent:1
Specifies that the background task can only run when the user is present. If a background task with the **UserPresent** condition is triggered, and the user is away, the task will not run until the user is present.

### -field UserNotPresent:2
Specifies that background task can only run when the user is not present. If a background task with the **UserNotPresent** condition is triggered, and the user is present, the task will not run until the user becomes inactive.

### -field InternetAvailable:3
Specifies that the background task can only run when the Internet is available. If a background task with the **InternetAvailable** condition is triggered, and the Internet is not available, the task will not run until the Internet is available again. This condition saves power because the background task won't execute until the network is available. This condition does not provide real-time activation.

> [!Important]
> Set [IsNetworkRequested](backgroundtaskbuilder_isnetworkrequested.md) on your background task to ensure that the network stays up while the background task runs. This tells the background task infrastructure to keep the network up while the task is executing, even if the device has entered Connected Standby mode, so that you can call into the core networking APIs ([HttpClient](../windows.web.http/httpclient.md), [StreamSocket](../windows.networking.sockets/streamsocket.md), [DatagramSocket](../windows.networking.sockets/datagramsocket.md), etc.) If your background task does not set **IsNetworkRequested**, then your background task will not be able to access the network when in Connected Standby mode (for example, when a phone's screen is turned off.)

### -field InternetNotAvailable:4
Specifies that the background task can only run when the Internet is not available. If a background task with the **InternetNotAvailable** condition is triggered, and the Internet is available, the task will not run until the Internet is unavailable.

### -field SessionConnected:5
Specifies that the background task can only run when the user's session is connected. If a background task with the **SessionConnected** condition is triggered, and the user session is not logged in, the task will run when the user logs in.

### -field SessionDisconnected:6
Specifies that the background task can only run when the user's session is disconnected. If a background task with the **SessionDisconnected** condition is triggered, and the user is logged in, the task will run when the user disconnects the remote desktop session or does fast user switching> [!NOTE]
> **SessionDisconnected** is primarily used in the context of remote desktop and fast user switching. It is not meant to be used as a notification that the user has logged off of the machine.

### -field FreeNetworkAvailable:7
Specifies that the background task can only run when a free (non-metered) network connection is available.

### -field BackgroundWorkCostNotHigh:8
Specifies that the background task can only run when the cost to do background work is low.


## -remarks

## -examples

## -see-also
[BackgroundTaskBuilder](backgroundtaskbuilder.md), [SystemCondition.ConditionType](systemcondition_conditiontype.md)
