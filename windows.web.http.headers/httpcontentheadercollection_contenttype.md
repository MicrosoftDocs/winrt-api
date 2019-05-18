---
-api-id: P:Windows.Web.Http.Headers.HttpContentHeaderCollection.ContentType
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.Headers.HttpMediaTypeHeaderValue ContentType { get;  set; }
-->

# Windows.Web.Http.Headers.HttpContentHeaderCollection.ContentType

## -description
Gets or sets the [HttpMediaTypeHeaderValue](httpmediatypeheadervalue.md) object that represent the value of an HTTP **Content-Type** header on the HTTP content.

## -property-value
The object that represent the value of an HTTP **Content-Type** header on the HTTP content. A **null** value means that the header is absent.

## -remarks
The ContentType property represents the **Content-Type** header value on HTTP content. The **Content-Type** header is the MIME type of the content.



The following sample code shows a method to get or set the **Content-Type** header value on HTTP content using the ContentType property on the [HttpContentHeaderCollection](httpcontentheadercollection.md) object.

```csharp
    // Content-Type header
    // HttpMediaTypeHeaderValue (MediaType, Charset are strings, Parameters is an IList<HttpNameValueHeaderValue>)
    //
    void DemoContentType(IHttpContent content) {
        var h = content.Headers;
        h.ContentType = new HttpMediaTypeHeaderValue("myMediaType");

        var header = h.ContentType;
        uiLog.Text += "\nCONTENT TYPE HEADER\n";

        // Parameters is an IList<HttpNameValueHeaderValue> of Name/Value strings
        var parameterString = "";
        foreach (var parameter in header.Parameters) {
                parameterString += string.Format("[{0}={1}] ", parameter.Name, parameter.Value);
        }
        if (parameterString == "") {
                parameterString = "(no parameters)";
        }

        uiLog.Text += string.Format("Content-Type: MediaType: {0} CharSet: {1} Parameters: {2} ToString: {3}\n", header.MediaType, header.CharSet, parameterString, header.ToString());
    }

```



## -examples

## -see-also
[HttpMediaTypeHeaderValue](httpmediatypeheadervalue.md)
