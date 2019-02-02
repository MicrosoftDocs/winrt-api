---
-api-id: E:Windows.ApplicationModel.Search.SearchPane.VisibilityChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler VisibilityChanged<Windows.ApplicationModel.Search.SearchPane,  Windows.ApplicationModel.Search.SearchPaneVisibilityChangedEventArgs>
-->

# Windows.ApplicationModel.Search.SearchPane.VisibilityChanged

## -description
Fires when the user opens or closes the search pane.

## -remarks
> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for UWP app using C++, C#, or Visual Basic, [WinJS.UI.SearchBox](https://msdn.microsoft.com/library/58f5cea3-a19b-48a8-abcc-17f38d8fa886) for Windows app using JavaScript) and the [SearchPane](searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

Register to be notified when this event fires by adding an event listener to the [searchPane](searchpane.md) and assigning a handler function for the event. You can access information about the event with the [searchPaneVisibilityChangedEventArgs](searchpanevisibilitychangedeventargs.md) object that is passed to your event handler.

## -examples

## -see-also
[SearchPane class](searchpane.md), [SearchPane.Show methods](searchpane_show_1323631364.md), [SearchPane.Visible property](searchpane_visible.md), [SearchPaneVisibilityChangedEventArgs class](searchpanevisibilitychangedeventargs.md)