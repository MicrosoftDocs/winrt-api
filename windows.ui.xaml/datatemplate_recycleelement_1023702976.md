---
-api-id: M:Windows.UI.Xaml.DataTemplate.RecycleElement(Windows.UI.Xaml.ElementFactoryRecycleArgs)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void DataTemplate.RecycleElement(ElementFactoryRecycleArgs args)
-->

# Windows.UI.Xaml.DataTemplate.RecycleElement

## -description

Recycles a [UIElement](../windows.ui.xaml/uielement.md) that was previously retrieved using [GetElement](datatemplate_getelement_92222689.md).


## -parameters

### -param args

An instance of [ElementFactoryRecycleArgs](elementfactoryrecycleargs.md).

## -remarks

The RecycleElement method is used to set aside an element for later re-use, but does not automatically reset the current state of the element. For example, if a [Control](../windows.ui.xaml.controls/control.md)'s [Background](../windows.ui.xaml.controls/control_background.md) is programmatically set the value persists when added to the live tree again.

Recycled elements returned from [GetElement](datatemplate_getelement_92222689.md) can be added to the live tree in the same way as newly created elements.

[GetElement](datatemplate_getelement_92222689.md) tries to retrieve an existing instance from those that were recycled. If none are found then it will create a new instance using [LoadContent](datatemplate_loadcontent_471913183.md).  

Recycling an element may not immediately cause it to be removed from the live element tree. In that situation the [Unloaded](frameworkelement_unloaded.md)/[Loaded](frameworkelement_loaded.md) events are not raised unless it is added to a different parent element in the live tree.

Specifying the [Parent](elementfactoryrecycleargs_parent.md) is not required when calling RecycleElement. However, its use is recommended to enable a performance optimization. When [GetElement](datatemplate_getelement_92222689.md) is called with a [Parent](elementfactorygetargs_parent.md) value it will look for elements that where recycled for that same [Parent](elementfactorygetargs_parent.md). If they're still attached to the parent element then they can be re-used without incurring the additional overhead of re-parenting the element.

> [!NOTE]
> RecycleElement does not automatically exclude the recycled element from participating in the tab order. Nor does it hide the element's automation peer from appearing in the automation tree. The platform's built-in virtualizing controls manage this for the elements under their control.  
>
> If you're creating a custom virtualizing control from scratch or calling RecycleElement in one-off scenarios then be aware it is your responsibility to exclude recycled elements from the tab order and the tree of automation peers.
>
> You can override [GetChildrenInTabFocusOrder](uielement_getchildrenintabfocusorder_1610735643.md) and provide the subset of realized elements the framework should use for Tab focus. Similarly, the automation peer for the control should override its [GetChildrenCore](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.getchildrencore) and exclude recycled elements.

## -see-also

[IElementFactory](ielementfactory.md), [DataTemplate.GetElement](/uwp/api/windows.ui.xaml.datatemplate.getelement), [DataTemplateSelector.GetElement](/uwp/api/windows.ui.xaml.controls.datatemplateselector.getelement), [DataTemplateSelector.RecycleElement](/uwp/api/windows.ui.xaml.controls.datatemplateselector.recycleelement), [ElementFactoryGetArgs](elementfactorygetargs.md), [ElementFactoryRecycleArgs](elementfactoryrecycleargs.md), [UIElement.GetChildrenInTabFocusOrder](/uwp/api/windows.ui.xaml.uielement.getchildrenintabfocusorder), [AutomationPeer.GetChildrenCore](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.getchildrencore)

## -examples
