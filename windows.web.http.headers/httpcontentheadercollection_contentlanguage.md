---
-api-id: P:Windows.Web.Http.Headers.HttpContentHeaderCollection.ContentLanguage
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.Headers.HttpLanguageHeaderValueCollection ContentLanguage { get; }
-->

# Windows.Web.Http.Headers.HttpContentHeaderCollection.ContentLanguage

## -description
Gets the [HttpLanguageHeaderValueCollection](httplanguageheadervaluecollection.md) of objects that represent the value of an HTTP **Content-Language** header on the HTTP content.

## -property-value
The collection of objects that represent the value of an HTTP **Content-Language** header on the HTTP content. An empty collection means that the header is absent

## -remarks


The following sample code shows a method to get or set the **Content-Language** header value on HTTP content using the [ContentLanguage](httpcontentheadercollection_contentlanguage.md) property on the [HttpContentHeaderCollection](httpcontentheadercollection.md) object.

```csharp
    // Content-Language header
    // HttpLanguageHeaderValueCollection (of Windows.Globalization.Language)
    void DemoContentLanguage(IHttpContent content) {
        var h = content.Headers;

        h.ContentLanguage.TryParseAdd("en-us");
        h.ContentLanguage.TryParseAdd("ru-ru, ru-us");
        h.ContentLanguage.Add(new Windows.Globalization.Language("ko-ko"));

        var header = h.ContentLanguage;
        uiLog.Text += "\nCONTENT LANGUAGE HEADER\n";
        foreach (var item in header) {
            uiLog.Text += string.Format("DisplayName: {0} ToString: {1}\n", item.DisplayName, item.ToString());
        }
        uiLog.Text += string.Format("ContentLanguage: ToString: {0}\n\n", header.ToString());
    }

```



## -examples

## -see-also
[HttpLanguageHeaderValueCollection](httplanguageheadervaluecollection.md)