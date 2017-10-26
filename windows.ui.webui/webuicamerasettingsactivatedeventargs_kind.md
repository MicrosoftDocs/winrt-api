---
-api-id: P:Windows.UI.WebUI.WebUICameraSettingsActivatedEventArgs.Kind
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Activation.ActivationKind Kind { get; }
-->

# Windows.UI.WebUI.WebUICameraSettingsActivatedEventArgs.Kind

## -description
Gets the activation type.

## -property-value
One of the enumeration values.

## -remarks
If [Kind](webuicamerasettingsactivatedeventargs_kind.md) is **CameraSettings**, the app should open using a flyout. If [Kind](webuicamerasettingsactivatedeventargs_kind.md) is **Launched**, it should open full-screen.

Do not declare device capabilities for webcam or location. Those capabilities will cause a prompt for permissions to appear, which will obstruct the UI in your UWP app.

## -examples

## -see-also
