---
-api-id: T:Windows.UI.Xaml.Controls.SearchBoxSuggestionsRequestedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class SearchBoxSuggestionsRequestedEventArgs : Windows.UI.Xaml.Controls.ISearchBoxSuggestionsRequestedEventArgs
-->

# Windows.UI.Xaml.Controls.SearchBoxSuggestionsRequestedEventArgs

## -description

Provides event data for the [SearchBox.SuggestionsRequested](searchbox_suggestionsrequested.md) event.

## -remarks

> [!IMPORTANT]
> Although [SearchBox](searchbox_searchbox_1221375020.md) is implemented in the Universal device family, it is not fully functional on mobile devices. Use [AutoSuggestBox](autosuggestbox.md) for your universal search experience. See [SearchBox deprecated in favor of AutoSuggestBox](/windows/uwp/porting/w8x-to-uwp-porting-xaml-and-ui#searchbox-deprecated-in-favor-of-autosuggestbox).

## -examples

If you want to respond to the [SuggestionsRequested](searchbox_suggestionsrequested.md) event asynchronously, you must obtain a [SearchSuggestionsRequestDeferral](../windows.applicationmodel.search/searchsuggestionsrequestdeferral.md) object before you edit the suggestion list. Here's an example that shows how.

```csharp
        public async static void SearchBox_SuggestionsRequested(
            SearchBox sender, 
            SearchBoxSuggestionsRequestedEventArgs args)
        {

            // This object lets us edit the SearchSuggestionCollection asynchronously. 
            var deferral = args.Request.GetDeferral();

            try { 

                // Retrieve the system-supplied suggestions.
                var suggestions = args.Request.SearchSuggestionCollection;
           
                var groups = await SampleDataSource.GetGroupsAsync();
                foreach (var group in groups)
                {
                    var matchingItems = group.Items.Where(
                        item => item.Title.StartsWith(
                            args.QueryText, StringComparison.CurrentCultureIgnoreCase));

                    foreach (var item in matchingItems)
                    {
                        suggestions.AppendQuerySuggestion(item.Title);
                    }
                }
            
                foreach (string alternative in args.LinguisticDetails.QueryTextAlternatives)
                {
                    if (alternative.StartsWith(
                        args.QueryText, StringComparison.CurrentCultureIgnoreCase))
                    {
                        suggestions.AppendQuerySuggestion(alternative); 
                    }
                }
            }
            finally {
                deferral.Complete();
            }

        }
```

## -see-also
[SearchBox.SuggestionsRequested](searchbox_suggestionsrequested.md)