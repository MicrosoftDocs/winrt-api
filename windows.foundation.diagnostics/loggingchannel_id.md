---
-api-id: P:Windows.Foundation.Diagnostics.LoggingChannel.Id
-api-type: winrt property
---

<!-- Property syntax
public System.Guid Id { get; }
-->

# Windows.Foundation.Diagnostics.LoggingChannel.Id

## -description
Returns the provider identifier for this channel.

## -property-value
The provider identifier for this channel.

## -remarks

The value of the **Id** depends on how the **LoggingChannel** is constructed as described in the following table:

| Constructor used | The value of Id |
|---|---|
| [LoggingChannel(String)](loggingchannel_loggingchannel_290278668.md) | The channel will be operating in Windows 8.1 compatibility mode and will return **4bd2826e-54a1-4ba9-bf63-92b73ea1ac4a** which is the [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) for the Microsoft-Windows-Diagnostics-LoggingChannel manifest. |
| [LoggingChannel(String, LoggingChannelOptions)](loggingchannel_loggingchannel_1496214966.md) | The GUID will be determined by hashing the *name* parameter passed to the **LoggingChannel** constructor. |
| [LoggingChannel(String, LoggingChannelOptions, Guid)](loggingchannel_loggingchannel_2599058.md) | The value is the same as the *Id* parameter passed to the [LoggingChannel](loggingchannel.md) constructor. |

## -examples

## -see-also
