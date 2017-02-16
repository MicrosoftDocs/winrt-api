---
-api-id: M:Windows.Media.Devices.FocusControl.Configure(Windows.Media.Devices.FocusSettings)
-api-type: winrt method
---

<!-- Method syntax
public void Configure(Windows.Media.Devices.FocusSettings settings)
-->

# Windows.Media.Devices.FocusControl.Configure

## -description
Configures the [FocusControl](focuscontrol.md) object with values specified in the provided [FocusSettings](focussettings.md) object.

## -parameters
### -param settings
The focus settings to use to configure the [FocusControl](focuscontrol.md) object.

## -remarks
Autofocus mode, enabled by using the [FocusMode.Continuous](focusmode.md) value in the [FocusSettings](focussettings.md) object supplied to this method, is only supported while the preview stream is running. Check to make sure that the preview stream is running before turning on continuous autofocus.

## -examples

## -see-also
