---
-api-id: P:Windows.Web.Http.Headers.HttpContentHeaderCollection.ContentDisposition
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.Headers.HttpContentDispositionHeaderValue ContentDisposition { get;  set; }
-->

# Windows.Web.Http.Headers.HttpContentHeaderCollection.ContentDisposition

## -description
Gets or sets the [HttpContentDispositionHeaderValue](httpcontentdispositionheadervalue.md) object that represents the value of an HTTP **Content-Disposition** header on the HTTP content.

## -property-value
The object that represent the value of HTTP **Content-Disposition** header on the HTTP content. A **null** value means that the header is absent.

## -remarks


The following sample code shows a method to get or set the **Content-Disposition** header value on HTTP content using the [ContentDisposition](httpcontentheadercollection_contentdisposition.md) property on the [HttpContentHeaderCollection](httpcontentheadercollection.md) object.

```csharp
    // Content-Disposition header
    // HttpContentDispositionHeaderValue
    void DemoContentDisposition(IHttpContent content) {
        var h = content.Headers;

        HttpContentDispositionHeaderValue value;
        bool ok = HttpContentDispositionHeaderValue.TryParse("attachment; filename=\"myfile.txt\"; myparam=myvalue", out value);
        h.ContentDisposition = value;

        h.ContentDisposition = HttpContentDispositionHeaderValue.Parse("attachment; filename=\"myfile.txt\"; myparam=myvalue");
        var header = h.ContentDisposition;

        uiLog.Text += "\nCONTENT DISPOSITION HEADER\n";
        // Content-Disposition: attachment; filename="fname.ext"

        // ContentDisposition is a HttpContentDispositionHeaderValue and contains:
        // DispositionType, FileName, FileNameStar, Name: all strings
        // Size: nullable long
        // Parameters: IList<HttpNameValueHeaderValue> 
        var parameterString = "";
        foreach (var parameter in header.Parameters) {
            parameterString += string.Format("[{0}={1}] ", parameter.Name, parameter.Value);
        }
        if (parameterString == "") {
            parameterString = "(no parameters)";
        }

        uiLog.Text += string.Format("ContentDisposition: DispositionType: {0} FileName: {1} FileNameStar: {2} Name: {3} Parameters: {4} Size: {5} ToString: {6}\n\n", 
        header.DispositionType, header.FileName, header.FileNameStar, header.Name, parameterString, header.Size, header.ToString());
    }

```



## -examples

## -see-also
[HttpContentDispositionHeaderValue](httpcontentdispositionheadervalue.md)