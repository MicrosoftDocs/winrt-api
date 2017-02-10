---
-api-id: T:Windows.Web.Http.Headers.HttpLanguageRangeWithQualityHeaderValue
-api-type: winrt class
---

<!-- Class syntax.
public class HttpLanguageRangeWithQualityHeaderValue : Windows.Foundation.IStringable, Windows.Web.Http.Headers.IHttpLanguageRangeWithQualityHeaderValue
-->

# Windows.Web.Http.Headers.HttpLanguageRangeWithQualityHeaderValue

## -description
Represents accept language information used in the **Accept-Language** HTTP header on an HTTP request.

## -remarks
The [HttpLanguageRangeWithQualityHeaderValue](httplanguagerangewithqualityheadervalue.md) class represents accept language information used in the **Accept-Language** HTTP header on an HTTP request.

The **Accept-Language** header can be used by clients to indicate the set of natural languages that are preferred in the response. A language range is defined in IETF [RFC 4647](http://tools.ietf.org/html/rfc4647). It is a language tag, or partial language tag, indicating a language, or range of languages. For example **en-us** would be American English, and **en-gb** would be British English. While **en** is a language range, meaning any variation of English.

Each language-range can be given an associated quality value representing an estimate of the user's preference for the languages specified by that range. The quality must be in the range 0.0 to 1.0.

Some recipients treat the order in which language tags are listed as an indication of descending priority, particularly for tags that are assigned equal quality values (no value is the same as q=1). However, this behavior cannot be relied upon. For consistency and to maximize interoperability, many user agents assign each language tag a unique quality value while also listing them in order of decreasing quality.

The [AcceptLanguage](httprequestheadercollection_acceptlanguage.md) property on the [HttpRequestHeaderCollection](httprequestheadercollection.md) returns an [HttpLanguageRangeWithQualityHeaderValueCollection](httplanguagerangewithqualityheadervaluecollection.md) that contains [HttpLanguageRangeWithQualityHeaderValue](httplanguagerangewithqualityheadervalue.md) objects.

## -examples

## -see-also
[AcceptLanguage](httprequestheadercollection_acceptlanguage.md), [HttpLanguageRangeWithQualityHeaderValueCollection](httplanguagerangewithqualityheadervaluecollection.md), [HttpRequestHeaderCollection](httprequestheadercollection.md), [IStringable](../windows.foundation/istringable.md)