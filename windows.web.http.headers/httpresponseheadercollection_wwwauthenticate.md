---
-api-id: P:Windows.Web.Http.Headers.HttpResponseHeaderCollection.WwwAuthenticate
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.Headers.HttpChallengeHeaderValueCollection WwwAuthenticate { get; }
-->

# Windows.Web.Http.Headers.HttpResponseHeaderCollection.WwwAuthenticate

## -description
Gets the [HttpChallengeHeaderValueCollection](httpchallengeheadervaluecollection.md) of [HttpChallengeHeaderValue](httpchallengeheadervalue.md) objects that represent the value of a **WWW-Authenticate** HTTP header on an HTTP response.

## -property-value
The collection of [HttpChallengeHeaderValue](httpchallengeheadervalue.md) objects that represent the value of a **WWW-Authenticate** HTTP header on an HTTP response. An empty collection means that the header is absent.

## -remarks


The following sample code shows a method to get and set the **WWW-Authenticate** header on an [HttpResponseMessage](../windows.web.http/httpresponsemessage.md) object using the WwwAuthenticate property on the [HttpResponseHeaderCollection](httpresponseheadercollection.md) object.

```csharp
// WWW-Authenticate: Basic
// HttpChallengeHeaderValueCollection
// HttpChallengeHeaderValue has Scheme and Token (both string) and Parameters (IList<HtpNameValueHeaderValue>)
// IList<HtpNameValueHeaderValue>
// HtpNameValueHeaderValue
    void DemoWwwAuthenticate(HttpResponseMessage response) {
        var h = response.Headers;
        h.WwwAuthenticate.TryParseAdd("Basic");
        h.WwwAuthenticate.Add(new HttpChallengeHeaderValue("scheme", "token"));

        var header = h.WwwAuthenticate;
        uiLog.Text += "\nWWW AUTHENTICATE HEADER\n";
        foreach (var item in header) {
            // Parameters is an IList<HttpNameValueHeaderValue> of Name/Value strings
            var parameterString = "";
            foreach (var parameter in item.Parameters) {
                    parameterString += string.Format("[{0}={1}] ", parameter.Name, parameter.Value);
            }
            if (parameterString == "") {
                parameterString = "(no parameters)";
            }
            uiLog.Text += string.Format("Scheme: {0} Token: {1} Parameters: {2} ToString(): {3}\n", item.Scheme, item.Token, parameterString, item.ToString());
        }
        uiLog.Text += String.Format("WwwAuthenticate: {0}\n", header.ToString());
    }

```



## -examples

## -see-also
[HttpChallengeHeaderValue](httpchallengeheadervalue.md), [HttpChallengeHeaderValueCollection](httpchallengeheadervaluecollection.md), [HttpResponseMessage](../windows.web.http/httpresponsemessage.md), [HttpResponseMessage.Headers](../windows.web.http/httpresponsemessage_headers.md)
