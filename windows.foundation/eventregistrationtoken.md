---
-api-id: T:Windows.Foundation.EventRegistrationToken
-api-type: winrt struct
---

<!-- Structure syntax.
public struct EventRegistrationToken
-->

# EventRegistrationToken

## -description
Represents a reference to a delegate that receives change notifications.



> **.NET**
> When programming with .NET, this type is hidden. Advanced-scenario developers should use [System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken](https://docs.microsoft.com/dotnet/api/system.runtime.interopservices.windowsruntime.eventregistrationtoken?redirectedfrom=MSDN).

## -struct-fields

### -field Value
The reference to the delegate.
A valid reference will not have a value of zero.

## -remarks
When programming with .NET, this type is hidden and developers that need an event registration token for advanced event scenarios should use the [System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken](https://docs.microsoft.com/dotnet/api/system.runtime.interopservices.windowsruntime.eventregistrationtoken?redirectedfrom=MSDN) type. For most app code, you won't need [EventRegistrationToken](https://docs.microsoft.com/dotnet/api/system.runtime.interopservices.windowsruntime.eventregistrationtoken?redirectedfrom=MSDN) (or event registration tokens) at all, because the add/remove syntax for C# and Visual Basic languages enables the compiler to generate the registration tokens from a simpler syntax.

In the event subscription model, a delegate registers to receive change notifications from a specified object such as a collection. The EventRegistrationToken is used to remove the delegate as a subscriber of change notifications when notifications are no longer needed.

## -examples

## -see-also
[System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken](https://docs.microsoft.com/dotnet/api/system.runtime.interopservices.windowsruntime.eventregistrationtoken?redirectedfrom=MSDN), [Events (C++/CX)](https://docs.microsoft.com/cpp/cppcx/events-c-cx), [Delegates (C++/CX)](https://docs.microsoft.com/cpp/cppcx/delegates-c-cx)
