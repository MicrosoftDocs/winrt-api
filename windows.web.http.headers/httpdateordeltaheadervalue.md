---
-api-id: T:Windows.Web.Http.Headers.HttpDateOrDeltaHeaderValue
-api-type: winrt class
---

<!-- Class syntax.
public class HttpDateOrDeltaHeaderValue : Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpDateOrDeltaHeaderValue
-->

# Windows.Web.Http.Headers.HttpDateOrDeltaHeaderValue

## -description
Represents the value of the **Retry-After** HTTP header on an HTTP response.

## -remarks
The [HttpDateOrDeltaHeaderValue](httpdateordeltaheadervalue.md) class represents the **Retry-After** HTTP header on an HTTP response.

The [RetryAfter](httpresponseheadercollection_retryafter.md) property on the [HttpResponseHeaderCollection](httpresponseheadercollection.md) returns an [HttpDateOrDeltaHeaderValue](httpdateordeltaheadervalue.md) object.

## -examples
The following sample code shows a method to get and set the **Retry-After** HTTP header on an [HttpResponseMessage](../windows.web.http/httpresponsemessage.md) object using the properties and methods on the [HttpDateOrDeltaHeaderValue](httpdateordeltaheadervalue.md) class.

```csharp

using System;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

        public void DemonstrateHeaderResponseRetryAfter() {
            var response = new HttpResponseMessage();

            // Set the header with a strong type.
            HttpDateOrDeltaHeaderValue newvalue;
            bool parseOk = HttpDateOrDeltaHeaderValue.TryParse("", out newvalue);
            if (parseOk) {
                response.Headers.RetryAfter = newvalue;
            }

            // Get the strong type out
            System.Diagnostics.Debug.WriteLine("Date value in ticks: {0}", response.Headers.Date.Value.Ticks);

            // The ToString() is useful for diagnostics, too.
            System.Diagnostics.Debug.WriteLine("The Date ToString() results: {0}", response.Headers.Date.ToString());
        }        

```



## -see-also
[HttpResponseHeaderCollection](httpresponseheadercollection.md), [HttpResponseMessage](../windows.web.http/httpresponsemessage.md), [IStringable](../windows.foundation/istringable.md), [RetryAfter](httpresponseheadercollection_retryafter.md)