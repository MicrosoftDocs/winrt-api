---
-api-id: P:Windows.ApplicationModel.Calls.PhoneCallInfo.StartTime
-api-type: winrt property
---

# Windows.ApplicationModel.Calls.PhoneCallInfo.StartTime

<!--
public System.DateTimeOffset StartTime { get; }
-->

## -description

Gets the start time of the call.

For an incoming call, this is the time that the call enters the [**Talking**](phonecallstatus.md) state. For an outgoing call, this is the time that the call enters the **Dialing** or **Talking** state, since that depends on underlying carrier and network settings.

## -property-value

A **DateTime** value containing the start time of the call.

## -remarks

## -see-also

## -examples

## -capabilities
phoneCall
