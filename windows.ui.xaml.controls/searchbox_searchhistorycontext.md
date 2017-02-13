---
-api-id: P:Windows.UI.Xaml.Controls.SearchBox.SearchHistoryContext
-api-type: winrt property
---

<!-- Property syntax
public string SearchHistoryContext { get;  set; }
-->

# Windows.UI.Xaml.Controls.SearchBox.SearchHistoryContext

## -description
Gets or sets a string that identifies the context of the search and is used to store the user's search history with the app.

## -xaml-syntax
```xaml
<SearchBox SearchHistoryContext="string"/>
```


## -property-value
A string that identifies the context of the search. The default is an empty string ("").

## -remarks
The search history context string is used as a secondary key for storing search history. The primary key is the [AppId](../windows.applicationmodel.store/currentapp_appid.md). You can use the search history context string to store different search histories for different pages or search entry points in the app. If you don't set this property, Windows assumes that all searches in your app occur in the same context.

## -examples

## -see-also
