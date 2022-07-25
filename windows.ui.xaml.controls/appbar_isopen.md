---
-api-id: P:Windows.UI.Xaml.Controls.AppBar.IsOpen
-api-type: winrt property
---

<!-- Property syntax
public bool IsOpen { get;  set; }
-->

# Windows.UI.Xaml.Controls.AppBar.IsOpen

## -description
Gets or sets a value that indicates whether the [AppBar](appbar.md) is open.



## -xaml-syntax
```xaml
<AppBar IsOpen="bool"/>
```


## -property-value
**true** if the app bar is open; otherwise, **false**.

## -remarks
How the app bar is displayed when it's open depends on the [ClosedDisplayMode](appbar_closeddisplaymode.md) property setting. For more info, see [App bar and command bar](/windows/uwp/controls-and-patterns/app-bars).

You can open and close the app bar programmatically by setting the IsOpen property. You can use the [Opening](appbar_opening.md), [Opened](appbar_opened.md), [Closing](appbar_closing.md), and [Closed](appbar_closed.md) events to respond to the app bar being opened or closed.

### Notes for previous versions

> **Windows 8**
> Binding to the IsOpen property doesn't have the expected results because the [PropertyChanged](../windows.ui.xaml.data/inotifypropertychanged.md) notification doesn't occur when the property is set.

## -examples


[!code-xaml[IsOpenXAML](../windows.ui.xaml.controls/code/AppBarSample/CS/SnippetsPage.xaml#SnippetIsOpenXAML)]

## -see-also
[Quickstart: Adding app bars](/previous-versions/windows/apps/hh781232(v=win.10))
