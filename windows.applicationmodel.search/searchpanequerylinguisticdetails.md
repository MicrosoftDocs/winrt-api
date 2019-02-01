---
-api-id: T:Windows.ApplicationModel.Search.SearchPaneQueryLinguisticDetails
-api-type: winrt class
---

<!-- Class syntax.
public class SearchPaneQueryLinguisticDetails : Windows.ApplicationModel.Search.ISearchPaneQueryLinguisticDetails
-->

# Windows.ApplicationModel.Search.SearchPaneQueryLinguisticDetails

## -description
Provides information about query text that the user enters through an Input Method Editor (IME).

## -remarks
An app retrieves this object through the [searchPaneQueryChangedEventArgs.linguisticDetails](searchpanequerychangedeventargs_linguisticdetails.md) property while handling a [querychanged](searchpane_querychanged.md) event or through the [searchPaneSuggestionsRequestedEventArgs.linguisticDetails](searchpanesuggestionsrequestedeventargs_linguisticdetails.md) property while handling a [suggestionsrequested](searchpane_suggestionsrequested.md) event.

## -examples
The [Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892) demonstrates how to respond to a [suggestionsrequested](searchpane_suggestionsrequested.md) event, including how to access the event's linguistic details.



[!code-csharp[all_suggestionsrequested_handler_linguisticdetails](../windows.applicationmodel.search/code/SearchContract/CS/Scenario3.xaml.cs#Snippetall_suggestionsrequested_handler_linguisticdetails)]

[!code-js[all_suggestionsrequested_handler_linguisticdetails](../windows.applicationmodel.search/code/SearchContract/js/js/scenario3.js#Snippetall_suggestionsrequested_handler_linguisticdetails)]

## -see-also
[Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892), [SearchPane.QueryChanged event](searchpane_querychanged.md), [SearchPaneQueryChangedEventArgs class](searchpanequerychangedeventargs.md), [SearchPaneQueryChangedEventArgs.LinguisticDetails property](searchpanequerychangedeventargs_linguisticdetails.md), [SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md), [SearchPaneSuggestionsRequestedEventArgs.LinguisticDetails property](searchpanesuggestionsrequestedeventargs_linguisticdetails.md)
edeventargs_linguisticdetails.md)
