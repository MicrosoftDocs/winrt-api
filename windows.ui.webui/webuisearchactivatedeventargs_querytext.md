---
-api-id: P:Windows.UI.WebUI.WebUISearchActivatedEventArgs.QueryText
-api-type: winrt property
---

<!-- Property syntax
public string QueryText { get; }
-->

# Windows.UI.WebUI.WebUISearchActivatedEventArgs.QueryText

## -description
Gets the text that the user wants the app to search for. The user entered this text into the search box of the search pane.

## -property-value
The text to search for.

## -remarks

## -examples
The [Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892) demonstrates how to use the queryText property in the app's activated event handler to determine whether the app should display a view of search results or the app's default, home view (if queryText is empty).



[!code-csharp[Snippetsearchkind_js](../windows.applicationmodel.search/code/SearchContract/js/js/default.js#Snippetsearchkind_js)]

In the example, `e` is a [webUISearchActivatedEventArgs](webuisearchactivatedeventargs.md) object.

## -see-also
