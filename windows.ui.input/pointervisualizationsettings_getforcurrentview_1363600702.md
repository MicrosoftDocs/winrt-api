---
-api-id: M:Windows.UI.Input.PointerVisualizationSettings.GetForCurrentView
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Input.PointerVisualizationSettings GetForCurrentView()
-->

# Windows.UI.Input.PointerVisualizationSettings.GetForCurrentView

## -description
Gets a [PointerVisualizationSettings](pointervisualizationsettings.md) object associated with the current app.

> [!IMPORTANT]
> Pointer visualizations are supported by the Desktop device family only.

## -returns
The [PointerVisualizationSettings](pointervisualizationsettings.md) object associated with the current app.

## -remarks
Each app has a [PointerVisualizationSettings](pointervisualizationsettings.md) object associated with it. When setting the visual feedback preferences, you use the GetForCurrentView method to get the [PointerVisualizationSettings](pointervisualizationsettings.md) object that is associated with the active app. After you have the appropriate [PointerVisualizationSettings](pointervisualizationsettings.md) object, you can set the visual feedback preferences.

## -examples

## -see-also
