---
-api-id: T:Windows.Devices.PointOfService.ClaimedCashDrawer
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class ClaimedCashDrawer : Windows.Devices.PointOfService.IClaimedCashDrawer, Windows.Foundation.IClosable
-->

# Windows.Devices.PointOfService.ClaimedCashDrawer

## -description
Provides access to exclusive and privileged methods, properties, and events on a point-of-service cash drawer device.

## -remarks
The user gets an instance of ClaimedCashDrawer from the [CashDrawer.ClaimDrawerAsync](cashdrawer_claimdrawerasync_887994265.md) method. Claim is cooperatively managed, so multiple concurrent apps can negotiate which app owns claim.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | Closed |

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md)
