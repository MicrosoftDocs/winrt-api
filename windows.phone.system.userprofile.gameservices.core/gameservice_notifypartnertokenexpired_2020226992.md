---
-api-id: M:Windows.Phone.System.UserProfile.GameServices.Core.GameService.NotifyPartnerTokenExpired(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public void NotifyPartnerTokenExpired(Windows.Foundation.Uri audienceUri)
-->

# Windows.Phone.System.UserProfile.GameServices.Core.GameService.NotifyPartnerTokenExpired

## -description
Invalidate the cached partner token for the specified Uri.

## -parameters
### -param audienceUri
The specified Uri.

## -remarks
If the partner token returned by [GetPartnerTokenAsync](gameservice_getpartnertokenasync.md) has expired this notifies the game service API to remove any cached data so that the next call will return a new partner token.

All members of the Windows.Phone.System.UserProfile.GameServices.Core namespace can only be used by the XBox Live SDK. These APIs cannot be called except by applications that have the ID_CAP_GAMERSERVICES capability.

## -examples

## -see-also
