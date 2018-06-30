---
-api-id: M:Windows.UI.Xaml.DataTemplate.RecycleElement(Windows.UI.Xaml.ElementFactoryRecycleArgs)
-api-type: winrt method
---

<!-- Method syntax.
public void DataTemplate.RecycleElement(ElementFactoryRecycleArgs args)
-->

# Windows.UI.Xaml.DataTemplate.RecycleElement

## -description
Recycles an [UIElement](../windows.ui.xaml/uielement) that was previously retrieved using [GetElement](datatemplate_getelement_92222689).

## -parameters
### -param args
An instance of [ElementFactoryRecycleArgs](elementfactoryrecycleargs).

## -remarks
The RecycleElement method is used to set aside an element for later re-use, but does not automatically reset the current state of the element.  For example, if a [Control](../windows.ui.xaml.controls/control)'s [Background](../windows.ui.xaml.controls/control_background) is programmatically set the value persists when added to the live tree again.

Recycled elements returned from [GetElement](datatemplate_getelement_92222689) can be added to the live tree in the same way as newly created elements.

[GetElement](datatemplate_getelement_92222689) tries to retrieve an existing instance from those that were recycled.  If none are found then it will create a new instance using [LoadContent](datatemplate_loadcontent_471913183).  

Recycling an element may not immediately cause it to be removed from the live element tree.  In that situation the [Unloaded](frameworkelement_unloaded) / [Loaded](frameworkelement_loaded) events are not raised unless it is added to a different parent element in the live tree.

Specifying the [Parent](elementfactoryrecycleargs_parent) is not required when calling RecycleElement.  However, its use is recommended to enable a performance optimization.  When [GetElement](datatemplate_getelement_92222689) is called with a [Parent](elementfactorygetargs_parent) value it will look for elements that where recycled for that same [Parent](elementfactorygetargs_parent).  If they're still attached to the parent element then they can be re-used without incurring the additional overhead of re-parenting the element.

> [!NOTE]
> RecycleElement does not automatically exclude the recycled element from participating in the tab order.  Nor does it hide the element's automation peer from appearing in the automation tree.  The platform's built-in virtualizing controls manage this for the elements under their control.  
>
> If you're creating a custom virtualizing control from scratch or calling RecycleElement in one-off scenarios then be aware it is your responsibility to exclude recycled elements from the tab order and the tree of automation peers.
>
> You can override [GetChildrenInTabFocusOrder](uielement_getchildrenintabfocusorder_1610735643) and provide the subset of realized elements the framework should use for Tab focus.  Similarly, the automation peer for the control should override its [GetChildrenCore](../windows.ui.xaml.automation.peers/automationpeer_getchildrencore_766641859) and exclude recycled elements.


## -see-also
* [IElementFactory](ielementfactory)
* DataTemplate
  * [GetElement](datatemplate_getelement_92222689)
  * [RecycleElement](datatemplate_recycleelement_1023702976)
* DataTemplateSelector
  * [GetElement](../windows.ui.xaml.controls/datatemplateselector_getelement_92222689)
  * [RecycleElement](../windows.ui.xaml.controls/datatemplateselector_recycleelement_1023702976)
* [ElementFactoryGetArgs](elementfactorygetargs)
* [ElementFactoryRecycleArgs](elementfactoryrecycleargs)
* UIElement
  * [GetChildrenInTabFocusOrder](uielement_getchildrenintabfocusorder_1610735643)
* AutomationPeer
  * [GetChildrenCore](../windows.ui.xaml.automation.peers/automationpeer_getchildrencore_766641859)

## -examples

