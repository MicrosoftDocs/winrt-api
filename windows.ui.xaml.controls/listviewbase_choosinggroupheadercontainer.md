---
-api-id: E:Windows.UI.Xaml.Controls.ListViewBase.ChoosingGroupHeaderContainer
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ChoosingGroupHeaderContainer<Windows.UI.Xaml.Controls.ListViewBase,  Windows.UI.Xaml.Controls.ChoosingGroupHeaderContainerEventArgs>
-->

# Windows.UI.Xaml.Controls.ListViewBase.ChoosingGroupHeaderContainer

## -description
Occurs when an item container is to be chosen for a data group.



## -remarks
You typically handle this event to enable accessibility. The group headers do not have an accessible name set by default. This event provides access to the header instance and lets you to set the [AutomationProperties.Name](/uwp/api/windows.ui.xaml.automation.automationproperties.name) attached property to an appropriate value.

If the container provided in the args is null, you can create a new header and provide it through the args. 

## -examples

## -see-also
