---
-api-id: M:Windows.Web.Http.HttpFormUrlEncodedContent.#ctor(Windows.Foundation.Collections.IIterable{Windows.Foundation.Collections.IKeyValuePair{System.String,System.String}})
-api-type: winrt method
---

<!-- Method syntax
public HttpFormUrlEncodedContent(Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, System.String>> content)
-->

# Windows.Web.Http.HttpFormUrlEncodedContent.HttpFormUrlEncodedContent

## -description
Initializes a new instance of the [HttpFormUrlEncodedContent](httpformurlencodedcontent.md) class with the specified content.

## -parameters
### -param content
The content used to initialize the [HttpFormUrlEncodedContent](httpformurlencodedcontent.md).

## -remarks
Below are the exceptions that this function throws.

### E_INVALIDARG

The *content* parameter is **null** (**Nothing** in Visual Basic).

## -examples

```cppwinrt
auto contentKeyValuePairs{
winrt::single_threaded_map<winrt::hstring, winrt::hstring>(std::map<winrt::hstring, winrt::hstring>{
    { L"firstname", L"Jane" }, { L"lastname", L"Austen" }
})
};
Windows::Web::Http::HttpFormUrlEncodedContent content1{ contentKeyValuePairs };

Windows::Web::Http::HttpFormUrlEncodedContent content2{
    std::map<winrt::hstring, winrt::hstring>{
        { L"firstname", L"Jane" }, { L"lastname", L"Austen" }}
};
```

## -see-also
