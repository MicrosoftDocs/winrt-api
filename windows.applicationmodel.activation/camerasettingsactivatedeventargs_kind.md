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
If [Kind](camerasettingsactivatedeventargs_kind.md) is **CameraSettings**, the app should open using a flyout. If [Kind](camerasettingsactivatedeventargs_kind.md) is **Launched**, it should open full-screen.



> [!NOTE]
> Do not declare device capabilities for webcam or location. Those capabilities will cause a prompt for permissions to appear, which will obstruct the UI in your UWP app.

## -examples

## -see-also
[Microsoft Store device app for camera sample](https://go.microsoft.com/fwlink/p/?LinkID=249442), [Developing  device apps for cameras](https://go.microsoft.com/fwlink/p/?LinkId=226802)
