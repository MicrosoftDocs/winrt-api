---
-api-id: T:Windows.Security.Credentials.UI.UserConsentVerifier
-api-type: winrt class
---

<!-- Class syntax.
public class UserConsentVerifier 
-->

# Windows.Security.Credentials.UI.UserConsentVerifier

## -description

Checks for availability of a verification device (such as a Microsoft Passport PIN, Windows Hello biometric, or fingerprint reader), and performs a verification.

## -examples

### Desktop apps using C#

For a desktop app, instead of calling the [UserConsentVerifier.RequestVerificationAsync](/uwp/api/windows.security.credentials.ui.userconsentverifier.requestverificationasync) method, you'll need to:

* First [Retrieve a window handle (HWND)](/windows/apps/develop/ui-input/retrieve-hwnd). That topic contains code examples for Windows UI Library (WinUI) 3, Windows Presentation Foundation (WPF), and Windows Forms (WinForms). Plug that code into the code listing below.
* Then call the **RequestVerificationForWindowAsync** method of the **Windows.Security.Credentials.UI.UserConsentVerifierInterop** C# interop class. For more info about the C# interop classes, see [Call interop APIs from a .NET app](/windows/apps/desktop/modernize/winrt-com-interop-csharp). Also see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects).

```csharp
private async System.Threading.Tasks.Task<string> RequestConsent(string userMessage)
{
    string returnMessage;

    // Retrieve the window handle of the current WinUI 3 window.
    var hwnd = WinRT.Interop.WindowNative.GetWindowHandle(this);

    // Use the interop interface to request the logged on user's consent via device authentication
    var consentResult = await Windows.Security.Credentials.UI.UserConsentVerifierInterop.RequestVerificationForWindowAsync(hwnd, userMessage);

    switch (consentResult)
    {
        case Windows.Security.Credentials.UI.UserConsentVerificationResult.Verified:
            returnMessage = "User verified.";
            break;
        case Windows.Security.Credentials.UI.UserConsentVerificationResult.DeviceBusy:
            returnMessage = "Authentication device is busy.";
            break;
        case Windows.Security.Credentials.UI.UserConsentVerificationResult.DeviceNotPresent:
            returnMessage = "No authentication device found.";
            break;
        case Windows.Security.Credentials.UI.UserConsentVerificationResult.DisabledByPolicy:
            returnMessage = "Authentication device verification is disabled by policy.";
            break;
        case Windows.Security.Credentials.UI.UserConsentVerificationResult.NotConfiguredForUser:
            returnMessage = "Please go to Account Settings to set up PIN or other advanced authentication.";
            break;
        case Windows.Security.Credentials.UI.UserConsentVerificationResult.RetriesExhausted:
            returnMessage = "There have been too many failed attempts. Device authentication canceled.";
            break;
        case Windows.Security.Credentials.UI.UserConsentVerificationResult.Canceled:
            returnMessage = "Device authentication canceled.";
            break;
        default:
            returnMessage = "Authentication device is currently unavailable.";
            break;
    }

    return returnMessage;
}
```

### Universal Windows Platform (UWP) apps using C#

This code example is for a Universal Windows Platform (UWP) app. It shows a request for fingerprint verification followed by returning a message that describes the result. The code calls the [UserConsentVerifier.RequestVerificationAsync](/uwp/api/windows.security.credentials.ui.userconsentverifier.requestverificationasync) method, which is appropriate for UWP apps.

[!code-csharp[2](../windows.security.credentials.ui/code/BiometricAuth/cs/MainPage.xaml.cs#Snippet2)]

### Desktop apps using C++/WinRT

For a desktop app, instead of calling the [UserConsentVerifier.RequestVerificationAsync](/uwp/api/windows.security.credentials.ui.userconsentverifier.requestverificationasync) method, you'll need to:

* First obtain the handle to the window that will request the verification. See [Retrieve a window handle (HWND)](/windows/apps/develop/ui-input/retrieve-hwnd) for details on how to do this for the Windows UI Library (WinUI) 3.
* Obtain the activation factory for the **Windows.Security.Credentials.UI.UserConsentVerifier** object.
* Call the **RequestVerificationForWindowAsync** method of the **IUserConsentVerifierInterop** interop interface.

```cppwinrt
winrt::Windows::Foundation::IAsyncOperation<winrt::hstring> MainWindow::RequestConsent(winrt::hstring userMessage)
{
    auto lifetime = get_strong();

    winrt::hstring returnMessage;

    // Retrieve the window handle of the current WinUI 3 window.
    HWND hwnd;
    winrt::check_hresult(m_inner->as<::IWindowNative>()->get_WindowHandle(&hwnd));

    // Use the interop interface to request the logged on user's consent via device authentication
    auto interop = winrt::get_activation_factory<winrt::Windows::Security::Credentials::UI::UserConsentVerifier, ::IUserConsentVerifierInterop>();
    auto consentResult =
        co_await winrt::capture<winrt::Windows::Foundation::IAsyncOperation<winrt::Windows::Security::Credentials::UI::UserConsentVerificationResult>>(
            interop, &::IUserConsentVerifierInterop::RequestVerificationForWindowAsync, hwnd, reinterpret_cast<HSTRING>(winrt::get_abi(userMessage))));

    switch (consentResult)
    {
        case winrt::Windows::Security::Credentials::UI::UserConsentVerificationResult::Verified:
            returnMessage = L"User verified.";
            break;
        case winrt::Windows::Security::Credentials::UI::UserConsentVerificationResult::DeviceBusy:
            returnMessage = L"Authentication device is busy.";
            break;
        case winrt::Windows::Security::Credentials::UI::UserConsentVerificationResult::DeviceNotPresent:
            returnMessage = L"No authentication device found.";
            break;
        case winrt::Windows::Security::Credentials::UI::UserConsentVerificationResult::DisabledByPolicy:
            returnMessage = L"Authentication device verification is disabled by policy.";
            break;
        case winrt::Windows::Security::Credentials::UI::UserConsentVerificationResult::NotConfiguredForUser:
            returnMessage = L"Please go to Account Settings to set up PIN or other advanced authentication.";
            break;
        case winrt::Windows::Security::Credentials::UI::UserConsentVerificationResult::RetriesExhausted:
            returnMessage = L"There have been too many failed attempts. Device authentication canceled.";
            break;
        case winrt::Windows::Security::Credentials::UI::UserConsentVerificationResult::Canceled:
            returnMessage = L"Device authentication canceled.";
            break;
        default:
            returnMessage = L"Authentication device is currently unavailable.";
            break;
    }

    co_return returnMessage;
}
```
## -remarks

You can use **UserConsentVerifier** to enhance the security of your app by including a request for verification whenever the user is required to consent to a particular action. For example, you can require fingerprint authentication before authorizing an in-app purchase or access to restricted resources. You can use **UserConsentVerifier** to determine whether fingerprint authentication is supported for the current computer by using the [CheckAvailabilityAsync](userconsentverifier_checkavailabilityasync_167910294.md) method, and then request user consent from a fingerprint scan by using the [RequestVerificationAsync](userconsentverifier_requestverificationasync_1054783001.md) method.

## -see-also

[Retrieve a window handle (HWND)](/windows/apps/develop/ui-input/retrieve-hwnd), [Call interop APIs from a .NET app](/windows/apps/desktop/modernize/winrt-com-interop-csharp), [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects), [Fingerprint biometrics](/windows/uwp/security/fingerprint-biometrics), [UserConsentVerifier sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/UserConsentVerifier), [Windows.Security.Credentials.UI](windows_security_credentials_ui.md), [Authentication and user identity](/windows/uwp/security/authentication-and-user-identity), [UserConsentVerifier sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620615)
