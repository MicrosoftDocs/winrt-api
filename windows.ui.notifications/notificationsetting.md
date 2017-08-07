---
-api-id: T:Windows.UI.Notifications.NotificationSetting
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.Notifications.NotificationSetting : int
-->

# NotificationSetting

## -description
Specifies the limitations on tile or toast notification display.

## -enum-fields
### -field Enabled:0
All notifications raised by this app can be displayed.

### -field DisabledForApplication:1
The user has disabled notifications for this app.

### -field DisabledForUser:2
The user or administrator has disabled all notifications for this user on this computer.

### -field DisabledByGroupPolicy:3
An administrator has disabled all notifications on this computer through group policy. The group policy setting overrides the user's setting.

### -field DisabledByManifest:4
This app has not declared itself toast capable in its package.appxmanifest file. This setting is found on the manifest's Application UI page, under the Notification section. For an app to send toast, the **Toast Capable** option must be set to "Yes".


## -remarks

## -examples

## -see-also
[TileUpdater.Setting](tileupdater_setting.md), [ToastNotifier.Setting](toastnotifier_setting.md), [App tiles and badges sample](http://go.microsoft.com/fwlink/p/?linkid=231469), [Toast notifications sample](http://go.microsoft.com/fwlink/p/?linkid=231503)