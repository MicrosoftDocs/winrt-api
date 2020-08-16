---
-api-id: T:Windows.Devices.SmartCards.SmartCardAppletIdGroupActivationPolicy
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.SmartCards.SmartCardAppletIdGroupActivationPolicy : int
-->

# SmartCardAppletIdGroupActivationPolicy

## -description
Defines the valid values that can be passed to the [RequestActivationPolicyChangeAsync](smartcardappletidgroupregistration_requestactivationpolicychangeasync_926513637.md) method.

## -enum-fields
### -field Disabled:0
The activation policy is set to disabled.

### -field ForegroundOverride:1
The activation policy is set to foreground override.

### -field Enabled:2
The activation policy is set to enabled.


## -remarks
If an app is running in the foreground with the screen on, that app can override any other app which may have been **Enabled**.

For payment scenarios, you choose your default payment card so it will be **Enabled**. You can tap and pay even if the app for that card is not running. Depending on your settings, you can even tap and pay with your phone screen off.

You could also have a separate app for another card which is disabled since it's not your default payment mechanism. If you're at a store that only takes the second card, you can open the app for the second card and it can request to set the policy to **ForegroundOverride**. This allows it to temporarily be the default for as long as the app is in the foreground and the screen is on or until the app asks to be **Disabled**.

The system prompts the user if an app asks to be **Enabled**, but the system won't prompt if an app asks for **ForegroundOverride** since it's just temporary and the app should be informing the user.

## -examples

## -see-also
[Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
