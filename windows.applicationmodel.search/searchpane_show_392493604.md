---
-api-id: M:Windows.ApplicationModel.Search.SearchPane.Show
-api-type: winrt method
---

<!-- Method syntax
public void Show()
-->

# Windows.ApplicationModel.Search.SearchPane.Show

## -description
Shows the search pane.

## -remarks
> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for UWP app using C++, C#, or Visual Basic, [WinJS.UI.SearchBox](https://msdn.microsoft.com/library/58f5cea3-a19b-48a8-abcc-17f38d8fa886) for Windows app using JavaScript) and the [SearchPane](searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

If the search pane is already being shown, this function gives focus to the search pane.

## -examples

## -see-also
[SearchPane class](searchpane.md), [SearchPane.Show(String) method](searchpane_show_1323631364.md), [SearchPane.VisibilityChanged event](searchpane_visibilitychanged.md), [SearchPane.Visible property](searchpane_visible.md)