---
-api-id: P:Windows.Web.Http.Headers.HttpContentHeaderCollection.ContentMD5
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.IBuffer ContentMD5 { get;  set; }
-->

# Windows.Web.Http.Headers.HttpContentHeaderCollection.ContentMD5

## -description
Gets or sets the value of an HTTP **Content-MD5** header on the HTTP content.

## -property-value
The value of the HTTP **Content-MD5** header on the HTTP content. A **null** value means that the header is absent.

## -remarks


The following sample code shows a method to get or set the **Content-MD5** header value on HTTP content using the [ContentMD5](httpcontentheadercollection_contentmd5.md) property on the [HttpContentHeaderCollection](httpcontentheadercollection.md) object.

```csharp
    // Content-MD5 header
    // IBuffer
    void DemoContentMD5(IHttpContent content) {
        var h = content.Headers;

        var str = "This is my content string";
        var alg = Windows.Security.Cryptography.Core.HashAlgorithmProvider.OpenAlgorithm("MD5");
        var buff = Windows.Security.Cryptography.CryptographicBuffer.ConvertStringToBinary(str, Windows.Security.Cryptography.BinaryStringEncoding.Utf8);
        var hashed = alg.HashData(buff);
        var res = Windows.Security.Cryptography.CryptographicBuffer.EncodeToHexString(hashed);
        h.ContentMD5 = hashed;

        var header = h.ContentMD5;
        uiLog.Text += "\nCONTENT MD5 HEADER\n";

        uiLog.Text += string.Format("ContentMD5: ToString: {0}\n\n", header.ToString());
        uiLog.Text += string.Format("ContentMD5: base64: {0} hex: {1}\n\n", Convert.ToBase64String(h.ContentMD5.ToArray()), res);
    }

```



## -examples

## -see-also
