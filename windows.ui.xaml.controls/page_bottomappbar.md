---
-api-id: P:Windows.UI.Xaml.Controls.Page.BottomAppBar
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.AppBar BottomAppBar { get;  set; }
-->

# Windows.UI.Xaml.Controls.Page.BottomAppBar

## -description
Gets a reference to an [AppBar](appbar.md) displayed at the bottom of the page, if any.



## -xaml-syntax
```xaml
<Page ...>
  <Page.BottomAppBar>
    <AppBar .../>
  </Page.BottomAppBar>
</Page>
```


## -property-value
A reference to an [AppBar](appbar.md) displayed at the bottom of the page, or **null**.

## -remarks
In XAML, make sure you specify the `Page.BottomAppBar` property element in the same area as other property elements that may already be defined, like `Page.TopAppBar` or `Page.Resources`. The XAML language enforces that you can't mix the property elements between the XAML content that is setting [Content](usercontrol_content.md), such as the typical root [Grid](grid.md) element. For more info on XAML syntax, see [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

## -examples
For example code that adds an [AppBar](appbar.md) to a page, see [Quickstart: adding app bars](/previous-versions/windows/apps/hh781230(v=win.10)) or [How to share an app bar across pages](/previous-versions/windows/apps/jj150604(v=win.10)).

## -see-also
[AppBar](appbar.md), [Quickstart: adding app bars](/previous-versions/windows/apps/hh781230(v=win.10))
