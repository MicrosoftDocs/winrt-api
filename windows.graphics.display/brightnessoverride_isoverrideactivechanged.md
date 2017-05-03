---
-api-id: E:Windows.Graphics.Display.BrightnessOverride.IsOverrideActiveChanged
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler IsOverrideActiveChanged<BrightnessOverride,  object>
-->

# Windows.Graphics.Display.BrightnessOverride.IsOverrideActiveChanged

## -description
Occurs when the screen brightness level either starts to match or stops to match the override brightness level. This event is raised when the [IsOverrideActive](brightnessoverride_isoverrideactive.md) property changes state.

## -remarks

## -see-also

## -examples

This example shows how to use the [IsOverrideActiveChanged](brightnessoverride_isoverrideactivechanged.md) event and the __OnIsOverrideActiveChanged__ event handler to notify the user whether or not the brightness override object is in fact controlling the screen brightness.

```csharp
bo.IsOverrideActiveChanged += OnIsOverrideActiveChanged;
...
private void OnIsOverrideActiveChanged(BrightnessOverride sender, object e)
{
    rootPage.NotifyUser("Brightness override is " + (sender.IsOverrideActive ? "active" : "not active"),   NotifyType.StatusMessage);
}
```
