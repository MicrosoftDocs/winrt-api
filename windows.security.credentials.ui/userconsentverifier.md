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

    if (String.IsNullOrEmpty(userMessage))
    {
        userMessage = "Please provide fingerprint verification.";
    }

    try
    {
        // Retrieve the window handle by passing a reference to the WinUI 3 window object 
        var hwnd = ...
        // Request the logged on user's consent via fingerprint swipe using the interop interface
        var consentResult = await Windows.Security.Credentials.UI.UserConsentVerifierInterop.RequestVerificationForWindowAsync(hwnd, userMessage);

        switch (consentResult)
        {
            case Windows.Security.Credentials.UI.UserConsentVerificationResult.Verified:
                returnMessage = "Fingerprint verified.";
                break;
            case Windows.Security.Credentials.UI.UserConsentVerificationResult.DeviceBusy:
                returnMessage = "Biometric device is busy.";
                break;
            case Windows.Security.Credentials.UI.UserConsentVerificationResult.DeviceNotPresent:
                returnMessage = "No biometric device found.";
                break;
            case Windows.Security.Credentials.UI.UserConsentVerificationResult.DisabledByPolicy:
                returnMessage = "Biometric verification is disabled by policy.";
                break;
            case Windows.Security.Credentials.UI.UserConsentVerificationResult.NotConfiguredForUser:
                returnMessage = "The user has no fingerprints registered. Please add a fingerprint to the " +
                                "fingerprint database and try again.";
                break;
            case Windows.Security.Credentials.UI.UserConsentVerificationResult.RetriesExhausted:
                returnMessage = "There have been too many failed attempts. Fingerprint authentication canceled.";
                break;
            case Windows.Security.Credentials.UI.UserConsentVerificationResult.Canceled:
                returnMessage = "Fingerprint authentication canceled.";
                break;
            default:
                returnMessage = "Fingerprint authentication is currently unavailable.";
                break;
        }
    }
    catch (Exception ex)
    {
        returnMessage = "Fingerprint authentication failed: " + ex.ToString();
    }

    return returnMessage;
}
```

### Universal Windows Platform (UWP) apps using C#

This code example is for a Universal Windows Platform (UWP) app. It shows a request for fingerprint verification followed by returning a message that describes the result. The code calls the [UserConsentVerifier.RequestVerificationAsync](/uwp/api/windows.security.credentials.ui.userconsentverifier.requestverificationasync) method, which is appropriate for UWP apps.

[!code-csharp[2](../windows.security.credentials.ui/code/BiometricAuth/cs/MainPage.xaml.cs#Snippet2)]

## -remarks

You can use **UserConsentVerifier** to enhance the security of your app by including a request for verification whenever the user is required to consent to a particular action. For example, you can require fingerprint authentication before authorizing an in-app purchase or access to restricted resources. You can use **UserConsentVerifier** to determine whether fingerprint authentication is supported for the current computer by using the [CheckAvailabilityAsync](userconsentverifier_checkavailabilityasync_167910294.md) method, and then request user consent from a fingerprint scan by using the [RequestVerificationAsync](userconsentverifier_requestverificationasync_1054783001.md) method.

## -see-also

[Retrieve a window handle (HWND)](/windows/apps/develop/ui-input/retrieve-hwnd), [Call interop APIs from a .NET app](/windows/apps/desktop/modernize/winrt-com-interop-csharp), [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects), [Fingerprint biometrics](/windows/uwp/security/fingerprint-biometrics), [UserConsentVerifier sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/UserConsentVerifier), [Windows.Security.Credentials.UI](windows_security_credentials_ui.md), [Authentication and user identity](/windows/uwp/security/authentication-and-user-identity), [UserConsentVerifier sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620615)
