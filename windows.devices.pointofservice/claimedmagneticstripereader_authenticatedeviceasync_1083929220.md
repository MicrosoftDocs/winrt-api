---
-api-id: M:Windows.Devices.PointOfService.ClaimedMagneticStripeReader.AuthenticateDeviceAsync(System.Byte[])
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction AuthenticateDeviceAsync(System.Byte[] responseToken)
-->

# Windows.Devices.PointOfService.ClaimedMagneticStripeReader.AuthenticateDeviceAsync

## -description
Puts the device into an authenticated state.

## -parameters
### -param responseToken
A buffer containing the response token generated from the challenge token retrieved from a previous call to the [RetrieveDeviceAuthenticationDataAsync](claimedmagneticstripereader_retrievedeviceauthenticationdataasync_1404266163.md) method.

## -returns


## -remarks
The method is only valid for devices that support authentication.

To authenticate a device, the application calls the [RetrieveDeviceAuthenticationDataAsync](claimedmagneticstripereader_retrievedeviceauthenticationdataasync_1404266163.md) method to retrieve a challenge token. The application typically passes this token to another entity that has special knowledge of a shared secret and is able to create a proper response token. This response token is then passed into the AuthenticateDeviceAsync method that uses it to validate the authentication request.

## -examples

## -see-also
