---
-api-id: P:Windows.UI.Xaml.VisualStateManager.CustomVisualStateManager
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.VisualStateManager.CustomVisualStateManager

<!--
see GetCustomVisualStateManager, and SetCustomVisualStateManager
-->

## -description

Gets or sets the custom VisualStateManager object that handles transitions between the states of a control.

## -remarks

This attached property is only needed for cases where you want to use a custom implementation class to handle your app's visual state changes, rather than the default `VisualStateManager` class implemented by the Windows Runtime. If you don't intend to use a custom implementation, you don't need to set this property.

- Type: [VisualStateManager](visualstatemanager.md)
- Identifier field: [CustomVisualStateManagerProperty](visualstatemanager_customvisualstatemanagerproperty.md)
- Accessor methods: [GetCustomVisualStateManager](visualstatemanager_getcustomvisualstatemanager_290426621.md), [SetCustomVisualStateManager](visualstatemanager_setcustomvisualstatemanager_164109747.md)

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples


