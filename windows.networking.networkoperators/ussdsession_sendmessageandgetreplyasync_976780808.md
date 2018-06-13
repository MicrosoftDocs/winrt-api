---
-api-id: M:Windows.Networking.NetworkOperators.UssdSession.SendMessageAndGetReplyAsync(Windows.Networking.NetworkOperators.UssdMessage)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.NetworkOperators.UssdReply> SendMessageAndGetReplyAsync(Windows.Networking.NetworkOperators.UssdMessage message)
-->

# Windows.Networking.NetworkOperators.UssdSession.SendMessageAndGetReplyAsync

## -description
Sends a message to a USSD session and returns a handler to retrieve the reply asynchronously.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.

> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/en-us/windows/uwp/packaging/app-capability-declarations). 

## -parameters
### -param message
The message to send to the USSD session.

## -returns
An asynchronous handler to retrieve the USSD response to the sent message.

## -remarks
The USSD message being sent can be either a request or a response. The operation is asynchronous and issues a single callback using the [IAsyncOperation(UssdReply)](../windows.foundation/iasyncoperation_1.md) interface upon completion. You can cancel the asynchronous operation using the [IAsyncOperation(UssdReply)](../windows.foundation/iasyncoperation_1.md) interface.

When an application using the C++ projection of [SendMessageAndGetReplyAsync](ussdsession_sendmessageandgetreplyasync.md) releases its last reference to the [UssdSession](ussdsession.md) object from within that callback, [SendMessageAndGetReplyAsync](ussdsession_sendmessageandgetreplyasync.md) may hang. Therefore, applications must ensure that the callback is not released from within [SendMessageAndGetReplyAsync](ussdsession_sendmessageandgetreplyasync.md). One way of doing this is to create another asynchronous operation (e.g. a timer) from within the callback whose completion callback is used to release the session object by passing it a reference to the session object.

```cppwinrt
#include <winrt/Windows.System.Threading.h>
using namespace winrt;
using namespace Windows::System::Threading;
...
auto timerDelegate = [ussdSession](ThreadPoolTimer const& timer) {};
Windows::Foundation::TimeSpan delay{ std::chrono::seconds(1) };
ThreadPoolTimer timer{ ThreadPoolTimer::CreateTimer(TimerElapsedHandler(timerDelegate), delay) };
```

```cpp
auto timerDelegate = [ussdSession](Windows::System::Threading::ThreadPoolTimer^ timer) {};
Windows::Foundation::TimeSpan delay;
delay.Duration = 1; // non-zero value
Windows::System::Threading::ThreadPoolTimer^ timer = 
Windows::System::Threading::ThreadPoolTimer::CreateTimer(ref new
Windows::System::Threading::TimerElapsedHandler(timerDelegate), delay);
```

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
