---
-api-id: P:Windows.UI.ViewManagement.UISettings.TextScaleFactor
-api-type: winrt property
---

<!-- Property syntax
public double TextScaleFactor { get; }
-->

# Windows.UI.ViewManagement.UISettings.TextScaleFactor

## -description

Gets the value of the system text size setting.

## -property-value

The value ranges from 1 to 2.25.

>[!NOTE]
> Not all text is scaled by the same factor. Generally speaking, the larger text is, the less it’s affected by scaling.

## -remark

This property is useful when attempting to scale non-text visuals proportionately with text.

## -examples

## -see-also

[Control.IsTextScaleFactorEanbled](../windows.ui.xaml.controls/control_istextscalefactorenabled.md), [Text scaling](/windows/uwp/design/input/text-scaling), [Accessible text requirements](/windows/uwp/design/accessibility/accessible-text-requirements)