---
-api-id: P:Windows.UI.Xaml.Input.KeyRoutedEventArgs.DeviceId
-api-type: winrt property
---

<!-- Property syntax
public string DeviceId { get; }
-->

# Windows.UI.Xaml.Input.KeyRoutedEventArgs.DeviceId

## -description
Gets a unique ID for the input device that generated this key event.

Use DeviceId to differentiate between all connected devices that can generate key events, such as multiple game controllers.

> DeviceId is not supported for all input devices.



## -property-value
A unique identifier for the input device associated with the key event, or an empty string for an unsupported device. The same device can be assigned a different ID each time it is connected.

## -remarks
Some devices, such as Xbox, permit multiple users to sign in for a single interactive session. This DeviceId property is useful for retrieving info for a specific user account associated with the input device.

> In Windows 10 and later, Universal Windows Platform (UWP) app do not have access to user information without explicit user consent (unlike Windows 8, where permission is granted by default).

Universal Windows Platform (UWP) app that access user information must declare the [userAccountInformation capability](/uwp/schemas/appxpackage/uapmanifestschema/element-uap-capability) ([Windows.System.UserDeviceAssociation.FindUserFromDeviceId](../windows.system/userdeviceassociation_finduserfromdeviceid_1383143459.md), [Windows.System.User.FindAllAsync](../windows.system/user_findallasync_1333355945.md) and [User.GetPropertiesAsync](../windows.system/user_getpropertiesasync_1952817514.md) can be used to get the data).

When this capability is declared, users installing the app are prompted to allow access to their information. If the user permits the app to access the information, the app appears listed in the **Privacy** page of the Windows 10 Settings app (**Settings &gt; Privacy &gt; Account info**). 

```csharp
private async void OnKeyDown(object sender, KeyRoutedEventArgs e)
{
  User user = 
    Windows.System.UserDeviceAssociation.FindUserFromDeviceId(e.DeviceId);
  string displayName = 
    (string)await user.GetPropertyAsync(KnownUserProperties.DisplayName);
  System.Diagnostics.Debug.WriteLine(displayName);
}

```



Sometimes, an [OnKeyDown](../windows.ui.xaml.controls/control_onkeydown_1048103922.md) event might not fire because the event was already handled by a control. In this case, call the [GetCurrentKeyEventDeviceId](../windows.ui.core/corewindow_getcurrentkeyeventdeviceid_498768106.md) method from the [KeyDown](../windows.ui.core/corewindow_keydown.md) handler of [CoreWindow](../windows.ui.core/corewindow.md), as shown here.

```csharp
public MainPage()
{
  this.InitializeComponent();
  Windows.UI.Core.CoreWindow.GetForCurrentThread().KeyDown += OnKeyDown;
}

private async void OnKeyDown(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
{
  string device = Windows.UI.Core.CoreWindow.GetForCurrentThread().GetCurrentKeyEventDeviceId();
  User user = Windows.System.UserDeviceAssociation.FindUserFromDeviceId(device);
  string displayName = (string)await user.GetPropertyAsync(KnownUserProperties.DisplayName);
  System.Diagnostics.Debug.WriteLine("OnKeydown:" + displayName);
}

```



## -examples

## -see-also
[User](../windows.system/user.md), [UserInformation](../windows.system.userprofile/userinformation.md), [Introduction to multi-user applications](/windows/uwp/xbox-apps/multi-user-applications)
