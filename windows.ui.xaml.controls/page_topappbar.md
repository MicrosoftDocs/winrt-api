---
-api-id: P:Windows.UI.Xaml.Controls.Page.TopAppBar
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.AppBar TopAppBar { get;  set; }
-->

# Windows.UI.Xaml.Controls.Page.TopAppBar

## -description
Gets a reference to an [AppBar](appbar.md) displayed at the top of the page, if any.



## -xaml-syntax
```xaml
<Page ...>
  <Page.TopAppBar>
    <AppBar .../>
  </Page.TopAppBar>
</Page>
```


## -property-value
A reference to an [AppBar](appbar.md) displayed at the top of the page, or **null**.

## -remarks
In XAML, make sure you specify the `Page.TopAppBar` property element in the same area as other property elements that may already be defined, like `Page.BottomAppBar` or `Page.Resources`. The XAML language enforces that you can't mix the property elements between the XAML content that is setting [Content](usercontrol_content.md), such as the typical root [Grid](grid.md) element. For more info on XAML syntax, see [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

## -examples
For example code that adds an [AppBar](appbar.md) to a page, see [Quickstart: adding app bars](/previous-versions/windows/apps/hh781230(v=win.10)) or [How to share an app bar across pages](/previous-versions/windows/apps/jj150604(v=win.10)).

## -see-also
[AppBar](appbar.md), [Quickstart: adding app bars](/previous-versions/windows/apps/hh781230(v=win.10))
