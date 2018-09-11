---
-api-id: T:Windows.UI.Xaml.Controls.ToolTipService
-api-type: winrt class
---

<!-- Class syntax.
public class ToolTipService : Windows.UI.Xaml.Controls.IToolTipService
-->

# Windows.UI.Xaml.Controls.ToolTipService

## -description
Represents a service that provides static methods to display a [ToolTip](tooltip.md).

## -remarks
### ToolTipService XAML attached properties

[ToolTipService](tooltipservice.md) is the host service class for several Extensible Application Markup Language (XAML) attached properties. The purpose of these attached properties is to enable target elements to qualify how they should be positioned relative to placement target elements.

[ToolTipService](tooltipservice.md) provides the following attached properties for Extensible Application Markup Language (XAML) usage: 
+ [ToolTipService.Placement](tooltipservice_placement.md)
+ [ToolTipService.PlacementTarget](tooltipservice_placementtarget.md)
+ [ToolTipService.Tooltip](tooltipservice_tooltip.md)


In order to support Extensible Application Markup Language (XAML) processor access to the attached properties, and also to expose equivalent get and set operations to code, each Extensible Application Markup Language (XAML) attached property has a pair of **Get** and **Set** accessor methods. For example, the [GetPlacement](tooltipservice_getplacement_347586387.md) and [SetPlacement](tooltipservice_setplacement_1223592561.md) methods support and provide the equivalent code-only support for [ToolTipService.Placement](tooltipservice_placement.md). Alternatively, you can use the dependency property system to get or set the value of the attached property. Call [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md), passing the arguments of the dependency property identifier to set, and a reference to the target object on which to get or set the value.

A [ToolTip](tooltip.md) must be assigned to another UI element that is its owner. In Extensible Application Markup Language (XAML), use the [ToolTipService.Tooltip](tooltipservice_tooltip.md) attached property to assign the [ToolTip](tooltip.md) to an owner. In code, use the [ToolTipService.SetToolTip](tooltipservice_settooltip_1924909593.md) method to assign the [ToolTip](tooltip.md) to an owner.

### Placement

By default, a [ToolTip](tooltip.md) is displayed centered above the pointer. The placement is not constrained by the app window, so the [ToolTip](tooltip.md) might be displayed partially or completely outside of the app window bounds.

If a [ToolTip](tooltip.md) obscures the content it is referring to, you can adjust it's placement. Use the [ToolTipService.Placement](tooltipservice_placement.md) attached property to place the [ToolTip](tooltip.md) above, below, left, or right of the pointer.

### Notes for previous versions

> **Windows 8.x**
>   [ToolTip](tooltip.md) is intended only for use in Windows. The [ToolTip](tooltip.md) type is available in Windows Phone projects for compatibility with universal project templates, but the [ToolTip](tooltip.md) is not shown in the Windows Phone  UI.

   [ToolTip](tooltip.md) is displayed only within the bounds of the app window. It's placement might be adjusted to stay within those bounds.

## -examples
The following code example demonstrates the placement modes for a [ToolTip](tooltip.md).



[!code-xml[1](../windows.ui.xaml.data/code/ToolTipServicePlacementEx/csharp/MainPage.xaml#Snippet1)]

## -see-also
[ToolTip](tooltip.md), [How to add a tooltip](http://msdn.microsoft.com/library/447c49d9-dc35-485c-b0ef-14c47414e6ec), [XAML essential controls sample](http://go.microsoft.com/fwlink/p/?linkid=226951)