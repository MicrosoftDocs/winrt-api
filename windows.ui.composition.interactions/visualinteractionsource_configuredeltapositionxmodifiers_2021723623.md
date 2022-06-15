---
-api-id: M:Windows.UI.Composition.Interactions.VisualInteractionSource.ConfigureDeltaPositionXModifiers(Windows.Foundation.Collections.IIterable{Windows.UI.Composition.Interactions.CompositionConditionalValue})
-api-type: winrt method
---

<!-- Method syntax.
public void VisualInteractionSource.ConfigureDeltaPositionXModifiers(IIterable<CompositionConditionalValue> conditionalValues)
-->

# Windows.UI.Composition.Interactions.VisualInteractionSource.ConfigureDeltaPositionXModifiers

## -description
Takes an ordered list of CompositionConditionalValue. In a frame, the first CompositionConditionalValue to have its “.Condition” evaluate to true replaces the DeltaPositionX value the VisualInteractionSource provides with its “.Value”. If none evaluate to true, the DeltaPositionX is not replaced that frame.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Composition.Interactions.VisualInteractionSource.ConfigureDeltaPositionXModifiers](/windows/winui/api/microsoft.ui.composition.interactions.visualinteractionsource.configuredeltapositionxmodifiers) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param conditionalValues

## -remarks

## -see-also

## -examples

