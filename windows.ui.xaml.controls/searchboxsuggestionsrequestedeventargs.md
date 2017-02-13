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

> [!NOTE]
> Although [SearchBox](searchbox_searchbox.md) is implemented in the Universal device family, it is not fully functional on mobile devices. Use [AutoSuggestBox](autosuggestbox.md) for your universal search experience. See [SearchBox deprecated in favor of AutoSuggestBox](http://msdn.microsoft.com/library/78b86762-7359-474f-b1e3-c2d7cf9aa907).

## -remarks
If you want to respond to the [SuggestionsRequested](searchbox_suggestionsrequested.md) event asynchronously, you must obtain a [SearchSuggestionsRequestDeferral](../windows.applicationmodel.search/searchsuggestionsrequestdeferral.md) object before you edit the suggestion list. Here's an example from [Quickstart: Adding search to an app](http://msdn.microsoft.com/library/9fa49c2a-5237-4432-aa93-0829bdc9dfe0) that shows how:



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



## -examples

## -see-also
[SearchBox.SuggestionsRequested](searchbox_suggestionsrequested.md)