---
-api-id: P:Windows.Networking.NetworkOperators.HotspotAuthenticationEventDetails.EventToken
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string EventToken { get; }
-->

# Windows.Networking.NetworkOperators.HotspotAuthenticationEventDetails.EventToken

## -description
Gets a GUID that uniquely identifies the authentication attempt for which this event was raised.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators. For more information, see [Mobile Broadband: ](http://msdn.microsoft.com/library/windows/hardware/hh852368.aspx) and [Windows 8 Integration for Wireless Hotspot Operators](http://msdn.microsoft.com/library/windows/hardware/hh770516.aspx).

## -property-value
A GUID that uniquely identifies the connection attempt.

## -remarks
The handler retrieving this token must call [TryGetAuthenticationContext](hotspotauthenticationcontext_trygetauthenticationcontext.md) to retrieve the full context of this event.

## -examples

## -see-also
