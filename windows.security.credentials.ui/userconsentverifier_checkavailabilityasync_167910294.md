---
-api-id: M:Windows.Security.Credentials.UI.UserConsentVerifier.CheckAvailabilityAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Credentials.UI.UserConsentVerifierAvailability> CheckAvailabilityAsync()
-->

# Windows.Security.Credentials.UI.UserConsentVerifier.CheckAvailabilityAsync

## -description
Checks to see whether an authentication device, such as a Microsoft Passport PIN, Windows Hello, or fingerprint reader, is available.

## -returns
A [UserConsentVerifierAvailability](userconsentverifieravailability.md) value that describes the result of the availability check operation.

## -remarks
The following example shows a method that checks to see if an authentication device is supported for the current user and returns a message that describes the result.

```csharp
public async Task<string> CheckDeviceAvailability()
{
    string returnMessage;

    // Check the availability of device authentication.
    var ucvAvailability = await Windows.Security.Credentials.UI.UserConsentVerifier.CheckAvailabilityAsync();

    switch (ucvAvailability)
    {
        case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.Available:
            returnMessage = "Authentication device is available.";
            break;
        case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.DeviceBusy:
            returnMessage = "Authentication device is busy.";
            break;
        case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.DeviceNotPresent:
            returnMessage = "No authentication device found.";
            break;
        case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.DisabledByPolicy:
            returnMessage = "Authentication device verification is disabled by policy.";
            break;
        case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.NotConfiguredForUser:
            returnMessage = "Please go to Account Settings to set up a PIN or other advanced authentication.";
            break;
        default:
            returnMessage = "Authentication device is currently unavailable.";
            break;
    }

    return returnMessage;
}
```

```cppwinrt
winrt::Windows::Foundation::IAsyncOperation<winrt::hstring> CheckDeviceAvailability()
{
    winrt::hstring returnMessage;

    // Check the availability of device authentication.
    auto ucvAvailability = co_await Windows::Security::Credentials::UI::UserConsentVerifier::CheckAvailabilityAsync();

    switch (ucvAvailability)
    {
        case winrt::Windows::Security::Credentials::UI::UserConsentVerifierAvailability::Available:
            returnMessage = L"Authentication device is available.";
            break;
        case winrt::Windows::Security::Credentials::UI::UserConsentVerifierAvailability::DeviceBusy:
            returnMessage = L"Authentication device is busy.";
            break;
        case winrt::Windows::Security::Credentials::UI::UserConsentVerifierAvailability::DeviceNotPresent:
            returnMessage = L"No authentication device found.";
            break;
        case winrt::Windows::Security::Credentials::UI::UserConsentVerifierAvailability::DisabledByPolicy:
            returnMessage = L"Authentication device verification is disabled by policy.";
            break;
        case winrt::Windows::Security::Credentials::UI::UserConsentVerifierAvailability::NotConfiguredForUser:
            returnMessage = L"Please go to Account Settings to set up a PIN or other advanced authentication.";
            break;
        default:
            returnMessage = L"Authentication device is currently unavailable.";
            break;
    }

    co_return returnMessage;
}
```
## -examples

## -see-also
[Fingerprint biometrics](/windows/uwp/security/fingerprint-biometrics), [UserConsentVerifier sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/UserConsentVerifier), [Windows.Security.Credentials.UI](windows_security_credentials_ui.md), [Authentication and user identity](/windows/uwp/security/authentication-and-user-identity)
