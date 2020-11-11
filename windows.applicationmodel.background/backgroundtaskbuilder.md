---
-api-id: T:Windows.ApplicationModel.Background.BackgroundTaskBuilder
-api-type: winrt class
---

<!-- Class syntax.
public class BackgroundTaskBuilder : Windows.ApplicationModel.Background.IBackgroundTaskBuilder, Windows.ApplicationModel.Background.IBackgroundTaskBuilder2, Windows.ApplicationModel.Background.IBackgroundTaskBuilder3, Windows.ApplicationModel.Background.IBackgroundTaskBuilder4
-->

# Windows.ApplicationModel.Background.BackgroundTaskBuilder

## -description
Represents a background task to register with the system.

## -remarks

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

If your background task requires network connectivity, be aware of the following:

** Network related triggers**

- Use a [SocketActivityTrigger](socketactivitytrigger.md) to activate the background task when a packet is received and you need to perform a short-lived task. After performing the task, the background task should terminate to save power.
- Use a [ControlChannelTrigger](../windows.networking.sockets/controlchanneltrigger.md) to activate the background task when a packet is received and you need to perform a long-lived task.

** Network related conditions and flags**

- Add the **InternetAvailable** condition ([BackgroundTaskBuilder.AddCondition](backgroundtaskbuilder_addcondition_1258521593.md)) to your background task to delay triggering the background task until the network stack is running. This condition saves power because the background task won't execute until network access is available. This condition does not provide real-time activation.

Regardless of the trigger you use, set [IsNetworkRequested](backgroundtaskbuilder_isnetworkrequested.md) on your background task to ensure that the network stays up while the background task runs. This tells the background task infrastructure to keep the network up while the task is executing, even if the device has entered Connected Standby mode. If your background task does not use **IsNetworkRequested**, then your background task will not be able to access the network when in Connected Standby mode (for example, when a phone's screen is turned off.)

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | TaskGroup |
| 2004 | 19041 | SetTaskEntryPointClsid |

## -examples

## -see-also