---
-api-id: P:Windows.ApplicationModel.Activation.CameraSettingsActivatedEventArgs.Kind
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Activation.ActivationKind Kind { get; }
-->

# Windows.ApplicationModel.Activation.CameraSettingsActivatedEventArgs.Kind

## -description
Gets the activation type.

## -property-value
One of the enumeration values.

## -remarks
If Kind is **CameraSettings**, the app should open using a flyout. If Kind is **Launched**, it should open full-screen.



> [!NOTE]
> Do not declare device capabilities for webcam or location. Those capabilities will cause a prompt for permissions to appear, which will obstruct the UI in your UWP app.

## -examples

## -see-also
[Microsoft Store device app for camera sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/CameraStarterKit), [Developing  device apps for cameras](/windows-hardware/drivers/devapps/uwp-device-apps-for-webcams)