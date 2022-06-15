---
-api-id: T:Windows.UI.Xaml.Controls.IncrementalLoadingTrigger
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.IncrementalLoadingTrigger : int
-->

# IncrementalLoadingTrigger

## -description
Defines constants that specify list view incremental loading behavior ([IncrementalLoadingTrigger](listviewbase_incrementalloadingtrigger.md) property).

Equivalent **WinUI 2 API for UWP**: [IncrementalLoadingTrigger](/windows/winui/api/microsoft.ui.xaml.controls.incrementalloadingtrigger) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<objectproperty="enumMemberName" />
```


## -enum-fields
### -field None:0
Incremental loading does not occur.

### -field Edge:1
Uses an "edge" offset for incremental loading visual behavior, and enables the list view to notify the scroll host of incremental load per interaction with other settings ([IncrementalLoadingThreshold](listviewbase_incrementalloadingthreshold.md), [DataFetchSize](listviewbase_datafetchsize.md)).


## -remarks

## -examples

## -see-also
