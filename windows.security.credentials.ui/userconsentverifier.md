---
-api-id: T:Windows.Security.Credentials.UI.UserConsentVerifier
-api-type: winrt class
---

<!-- Class syntax.
public class UserConsentVerifier 
-->

# Windows.Security.Credentials.UI.UserConsentVerifier

## -description

Checks for availability of a verification device (such as a Microsoft Passport PIN, Windows Hello biometric, or fingerprint reader) and performs a verification.

## -remarks

You can use the UserConsentVerifier class to enhance the security of your app by including a request for verification whenever the user is required to consent to a particular action. For example, you can require a fingerprint authentication before authorizing an in-app purchase or access to restricted resources. You can use the UserConsentVerifier class to determine if fingerprint authentication is supported for the current computer using the [CheckAvailabilityAsync](userconsentverifier_checkavailabilityasync_167910294.md) method, and then request user consent from a fingerprint scan using the [RequestVerificationAsync](userconsentverifier_requestverificationasync_1054783001.md) method.

## -examples

The following example shows a method that requests fingerprint verification, and returns a message that describes the result. Note that for C# applications on .NET 5 or later, you should use the [WinRT COM interop interface](/windows/apps/desktop/modernize/winrt-com-interop-csharp).

### [C# (.NET 5 or later)](#tab/csharpnet5)

The example in this tab is for WinUI 3 apps. To retrieve the window handle, it uses `WindowNative` and `this` (which is a pointer to a WinUI 3 [Window](/windows/winui/api/microsoft.ui.xaml.window?view=winui-3.0) object) from the main window code-behind.

For WPF, the appropriate method for retrieving the window handle is [WindowInteropHelper.Handle](/dotnet/api/system.windows.interop.windowinterophelper.handle).

For Windows Forms, the appropriate method is [NativeWindow.Handle](/dotnet/api/system.windows.forms.nativewindow.handle).

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
                var hwnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
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

---

### [C# (UWP)](#tab/UWP)

[!code-csharp[2](../windows.security.credentials.ui/code/BiometricAuth/cs/MainPage.xaml.cs#Snippet2)]

## -see-also

[Fingerprint biometrics](/windows/uwp/security/fingerprint-biometrics), [UserConsentVerifier sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/UserConsentVerifier), [Windows.Security.Credentials.UI](windows_security_credentials_ui.md), [Authentication and user identity](/windows/uwp/security/authentication-and-user-identity), [UserConsentVerifier sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620615)
