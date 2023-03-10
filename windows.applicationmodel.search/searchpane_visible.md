---
-api-id: P:Windows.ApplicationModel.Search.SearchPane.Visible
-api-type: winrt property
---

<!-- Property syntax
public bool Visible { get; }
-->

# Windows.ApplicationModel.Search.SearchPane.Visible

## -description

Indicates whether the search pane is open.

## -property-value

`true` if the search pane is being displayed; otherwise, `false`.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) and the SearchPane. Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

## -examples

## -see-also

[SearchPane class](searchpane.md), [SearchPane.Show methods](searchpane_show_1323631364.md), [SearchPane.VisibilityChanged event](searchpane_visibilitychanged.md), [SearchPaneVisibilityChangedEventArgs class](searchpanevisibilitychangedeventargs.md)