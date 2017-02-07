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
True if the search pane is being displayed; otherwise false.

## -remarks
> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for Windows Store app using C++, C#, or Visual Basic, [WinJS.UI.SearchBox](http://msdn.microsoft.com/library/58f5cea3-a19b-48a8-abcc-17f38d8fa886) for Windows app using JavaScript) and the [SearchPane](searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

## -examples

## -see-also
[SearchPane class](searchpane.md), [SearchPane.Show methods](searchpane_show.md), [SearchPane.VisibilityChanged event](searchpane_visibilitychanged.md), [SearchPaneVisibilityChangedEventArgs class](searchpanevisibilitychangedeventargs.md)