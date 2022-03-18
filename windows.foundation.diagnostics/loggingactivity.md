---
-api-id: T:Windows.Foundation.Diagnostics.LoggingActivity
-api-type: winrt class
---

<!-- Class syntax.
public class LoggingActivity : Windows.Foundation.Diagnostics.ILoggingActivity, Windows.Foundation.Diagnostics.ILoggingActivity2, Windows.Foundation.Diagnostics.ILoggingTarget, Windows.Foundation.IClosable
-->

# Windows.Foundation.Diagnostics.LoggingActivity

## -description

Creates Event Tracing for Windows (ETW) events that mark the start and end of a group of related events.

## -remarks

> **Windows 10**
> The **LoggingActivity** class has been extended in the following ways:+ Now implements [ILoggingTarget](iloggingtarget.md) which provides activity start and stop methods that provide control over the format and contents of the Start and Stop events.
+ Now implements methods to log events. Events are automatically tagged with the LoggingActivity's [GUID](/windows/win32/api/guiddef/ns-guiddef-guid).
+ Activities can be nested.
Every **LoggingActivity** object is attached to a [LoggingChannel](loggingchannel.md) object. All events created by the **LoggingActivity** object are written through the attached [LoggingChannel](loggingchannel.md) object.

## -examples

## -see-also

[IClosable](../windows.foundation/iclosable.md), [LoggingChannel](loggingchannel.md), [ILoggingTarget](iloggingtarget.md), [Logging sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Logging)
