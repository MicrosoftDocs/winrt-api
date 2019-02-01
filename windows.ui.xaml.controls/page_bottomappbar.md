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
In XAML, make sure you specify the `Page.BottomAppBar` property element in the same area as other property elements that may already be defined, like `Page.TopAppBar` or `Page.Resources`. The XAML language enforces that you can't mix the property elements between the XAML content that is setting [Content](usercontrol_content.md), such as the typical root [Grid](grid.md) element. For more info on XAML syntax, see [XAML syntax guide](https://msdn.microsoft.com/library/a57fe7b4-9947-4aa0-bc99-5fe4686b611d).

## -examples
For example code that adds an [AppBar](appbar.md) to a page, see [Quickstart: adding app bars](https://msdn.microsoft.com/library/9915aea1-e738-4c4b-a838-85625055fa06) or [How to share an app bar across pages](https://msdn.microsoft.com/library/89d3e780-2c8d-4e4d-a0a9-ebf0be87a730). For a complete sample that uses many of the [Page](page.md) and [Frame](frame.md) features together, see [XAML Navigation sample](https://go.microsoft.com/fwlink/p/?LinkID=330214).

## -see-also
[AppBar](appbar.md), [Quickstart: adding app bars](https://msdn.microsoft.com/library/9915aea1-e738-4c4b-a838-85625055fa06)
