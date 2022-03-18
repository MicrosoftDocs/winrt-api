---
-api-id: E:Windows.UI.Xaml.Controls.SearchBox.QuerySubmitted
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler QuerySubmitted<Windows.UI.Xaml.Controls.SearchBox,  Windows.UI.Xaml.Controls.SearchBoxQuerySubmittedEventArgs>
-->

# Windows.UI.Xaml.Controls.SearchBox.QuerySubmitted

## -description
Occurs when the user submits a search query.

## -xaml-syntax
```xaml
<SearchBox QuerySubmitted="eventhandler"/>
```


## -remarks
Handle this event so that you can get the [QueryText](searchbox_querytext.md) value from [SearchBoxQuerySubmittedEventArgs](searchboxquerysubmittedeventargs.md), and pass it on as navigation data when you load a search results page to display to the user.

For a complete example of how to handle QuerySubmitted as part of a complete example that also does search suggestions, see [SearchBox control sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/SearchBox%20control%20sample).

The handler signature for QuerySubmitted uses [TypedEventHandler](/previous-versions/hh438424(v=vs.85)) and enforces that the *sender* parameter be a [SearchBox](searchbox.md) instance, not just **Object**.

## -examples
Here's a basic XAML definition for a [SearchBox](searchbox.md), and an implementation of the QuerySubmitted handler. It calls [Frame.Navigate](frame_navigate_1426351961.md) to load a search query result page (not shown) that's named `SearchResultsPage1`. The **this**/**Me** reference in the handlers is the containing page instance, as is typical for on-page input event handling code. You can see similar code as part of [Quickstart: Adding search to an app](/previous-versions/windows/apps/hh868180(v=win.10)) and [Enabling users to search for information in your ](/previous-versions/windows/apps/hh868180(v=win.10)).

```xaml
<SearchBox x:Name="mySearchBox" 
    FocusOnKeyboardInput="True"
    QuerySubmitted="mySearchBox_QuerySubmitted"
    Height="35"  />
```

```csharp
private void mySearchBox_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
{
    this.Frame.Navigate(typeof(SearchResultsPage1), args.QueryText);
}

```

```vb
Private Sub mySearchBox_QuerySubmitted(sender As SearchBox, args As SearchBoxQuerySubmittedEventArgs)
    Me.Frame.Navigate(GetType(SearchResultsPage1), args.QueryText)
End Sub
```



## -see-also
[SearchBoxQuerySubmittedEventArgs](searchboxquerysubmittedeventargs.md), [Enabling users to search for information in your ](/previous-versions/windows/apps/hh868180(v=win.10)), [Quickstart: Adding search to an app](/previous-versions/windows/apps/hh868180(v=win.10)), [SearchBox control sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/SearchBox%20control%20sample)
