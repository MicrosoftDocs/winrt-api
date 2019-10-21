---
-api-id: P:Windows.ApplicationModel.Search.SearchPane.ShowOnKeyboardInput
-api-type: winrt property
---

<!-- Property syntax
public bool ShowOnKeyboardInput { get;  set; }
-->

# Windows.ApplicationModel.Search.SearchPane.ShowOnKeyboardInput

## -description
Gets or sets whether the user can open the search pane by typing.

## -property-value
True if the user can type to search. Otherwise, false.

## -remarks
> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for UWP app using C++, C#, or Visual Basic, [WinJS.UI.SearchBox](https://docs.microsoft.com/previous-versions/windows/apps/dn301949(v=win.10)) for Windows app using JavaScript) and the [SearchPane](searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

To learn more about when you should let users type to search, see [Guidelines and checklist for search](https://docs.microsoft.com/windows/uwp/controls-and-patterns/search).

## -examples

## -see-also
