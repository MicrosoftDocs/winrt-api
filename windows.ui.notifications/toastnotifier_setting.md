---
-api-id: P:Windows.UI.Notifications.ToastNotifier.Setting
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Notifications.NotificationSetting Setting { get; }
-->

# Windows.UI.Notifications.ToastNotifier.Setting

## -description
Gets a value that tells you whether there is an app, user, or system block that prevents the display of a toast notification.

## -property-value
**Enabled** if the toast can be shown; otherwise, one or more reasons that the toast will be blocked.

## -remarks
When toast notifications have been disabled at more than one level, this property value reflects the setting with the largest scope. Precedence is as follows, from largest scope to smallest: 
1. DisabledByManifest
1. DisabledByGroupPolicy
1. DisabledForUser
1. DisabledForApplication
If toast notifications have been disabled both by the user and by group policy, this property returns DisabledByGroupPolicy.

## -examples

## -see-also