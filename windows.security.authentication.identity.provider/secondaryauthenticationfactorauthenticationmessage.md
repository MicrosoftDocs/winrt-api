---
-api-id: T:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthenticationMessage
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthenticationMessage : int
-->

# SecondaryAuthenticationFactorAuthenticationMessage

## -description
Represents standard error messages.

> [!NOTE]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft to use the **secondaryAuthenticationFactor** capability, calls to this API will fail. To apply for approval, contact [cdfonboard@microsoft.com](mailto:cdfonboard@microsoft.com). For more information on capabilities, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations). For an overview of the Companion Device Framework, see the [Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock) overview.

## -enum-fields
### -field Invalid:0
Invalid message.

### -field SwipeUpWelcome:1
Swipe up or press space bar to sign in with **device name**.

### -field TapWelcome:2
Tap **device name** to the NFC reader to sign in.

### -field DeviceNeedsAttention:3
See **device name** for sign-in instructions.

### -field LookingForDevice:4
Looking for **device name**...

### -field LookingForDevicePluggedin:5
Plug **device name** into a USB port to sign in.

### -field BluetoothIsDisabled:6
Turn on Bluetooth to use **device name** to sign in.

### -field NfcIsDisabled:7
Turn on NFC to use **device name** to sign in.

### -field WiFiIsDisabled:8
Connect to a Wi-Fi network to use **device name** to sign in.

### -field ExtraTapIsRequired:9
Tap **device name** again.

### -field DisabledByPolicy:10
Your enterprise prevents sign in with **device name**. Use another sign-in option.

### -field TapOnDeviceRequired:11
Tap **device name** to sign in.

### -field HoldFinger:12
Rest your finger on **device name** to sign in.

### -field ScanFinger:13
Swipe your finger on **device name** to sign in.

### -field UnauthorizedUser:14
Couldn’t sign in with **device name**. Use another sign-in option.

### -field ReregisterRequired:15
Something went wrong. Use another sign-in option, and then set up **device name** again.

### -field TryAgain:16
Try again.

### -field SayPassphrase:17
Say your Spoken Passphrase into **device name**.

### -field ReadyToSignIn:18
Ready to sign in with **device name**.

### -field UseAnotherSignInOption:19
Use another sign-in option first, then you can use **device name** to sign in.

### -field ConnectionRequired:20
Could not connect to companion device. Try again.

### -field TimeLimitExceeded:21
The authentication process exceeded the time limit. Try again.

### -field CanceledByUser:22
The authentication process was cancelled. Try again.

### -field CenterHand:23
Instruct the user to center their hand over the companion device.

### -field MoveHandCloser:24
Instruct the user to move their hand closer to the companion device.

### -field MoveHandFarther:25
Instruct the user to move their hand farther from the companion device.

### -field PlaceHandAbove:26
Instruct the user to move their hand above the companion device.

### -field RecognitionFailed:27
The companion device failed to recognize the user.

### -field DeviceUnavailable:28
The companion device is unavailable. Use another sign-in option.



## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | CanceledByUser |
| 1803 | 17134 | CenterHand |
| 1803 | 17134 | ConnectionRequired |
| 1803 | 17134 | DeviceUnavailable |
| 1803 | 17134 | MoveHandCloser |
| 1803 | 17134 | MoveHandFarther |
| 1803 | 17134 | PlaceHandAbove |
| 1803 | 17134 | RecognitionFailed |
| 1803 | 17134 | TimeLimitExceeded |

## -examples

## -see-also
[Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock)