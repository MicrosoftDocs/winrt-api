---
-api-id: M:Windows.Devices.PointOfService.ClaimedMagneticStripeReader.DeAuthenticateDeviceAsync(System.Byte[])
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction DeAuthenticateDeviceAsync(System.Byte[] responseToken)
-->

# Windows.Devices.PointOfService.ClaimedMagneticStripeReader.DeAuthenticateDeviceAsync

## -description
Puts the device into an unauthenticated state.

## -parameters
### -param responseToken
A buffer containing the response token generated from the challenge token retrieved from a previous call to the [RetrieveDeviceAuthenticationDataAsync](claimedmagneticstripereader_retrievedeviceauthenticationdataasync_1404266163.md) method.

## -returns


## -remarks
When successful, the [IsDeviceAuthenticated](claimedmagneticstripereader_isdeviceauthenticated.md) property changes to false.

## -examples

## -see-also
