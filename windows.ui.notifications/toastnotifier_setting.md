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
[Toast notifications sample](http://go.microsoft.com/fwlink/p/?linkid=231503), [Sending toast notifications from desktop apps sample](http://go.microsoft.com/fwlink/p/?linkid=231503), [Toast XML schema](XREF:TODO:toast.Schema_Root), [Toast notification overview](http://msdn.microsoft.com/library/14a07fce-d631-4bad-ab99-305b703713e6), [Quickstart: Sending a toast notification](http://msdn.microsoft.com/library/098df37c-4d40-4499-b809-ccb651da1cba), [Quickstart: Sending a toast push notification](http://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [Quickstart: Sending a toast notification from the desktop](http://msdn.microsoft.com/library/1d20ed75-e24a-4e60-91ab-cfcbe902a68e), [Guidelines and checklist for toast notifications](http://msdn.microsoft.com/library/002951e3-3d2d-454a-a0b7-daa5c1e7178a), [How to handle activation from a toast notification](http://msdn.microsoft.com/library/74ba3513-0a52-46a0-8769-ed58abe7c05a), [How to opt in for toast notifications](http://msdn.microsoft.com/library/809cdd36-6de1-4de0-88b2-62b46cafdb28), [How to schedule a toast notification](http://msdn.microsoft.com/library/18a09413-1679-4606-8175-346f4fe6a4f8), [How to enable desktop toast notifications through an AppUserModelID](http://msdn.microsoft.com/library/bb32cd0a-99e6-47dc-a913-39a7b3027314), [The toast template catalog](http://msdn.microsoft.com/library/1a437614-4259-426b-8e3f-ca57368b2e7a), [Toast audio options](http://msdn.microsoft.com/library/12185879-1f9b-4bdc-99e7-a6f2f62806cb)