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

Equivalent WinUI event: [Microsoft.UI.Xaml.Controls.ListViewBase.ChoosingGroupHeaderContainer](/windows/winui/api/microsoft.ui.xaml.controls.listviewbase.choosinggroupheadercontainer).

## -remarks
You typically handle this event to enable accessibility. The group headers do not have an accessible name set by default. This event provides access to the header instance and lets you to set the [AutomationProperties.Name](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) attached property to an appropriate value.

## -examples

## -see-also
