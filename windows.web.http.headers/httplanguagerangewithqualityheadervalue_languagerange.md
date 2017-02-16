---
-api-id: P:Windows.Web.Http.Headers.HttpLanguageRangeWithQualityHeaderValue.LanguageRange
-api-type: winrt property
---

<!-- Property syntax
public string LanguageRange { get; }
-->

# Windows.Web.Http.Headers.HttpLanguageRangeWithQualityHeaderValue.LanguageRange

## -description
Gets the value of the **language-range** information from the [HttpLanguageRangeWithQualityHeaderValue](httplanguagerangewithqualityheadervalue.md) used in the **Accept-Language** HTTP header.

## -property-value
The value of the **language-range** information.

## -remarks
The **Accept-Language** header can be used by clients to indicate the set of natural languages that are preferred in the response. A language range is defined in IETF [RFC 4647](http://tools.ietf.org/html/rfc4647). It is a language tag, or partial language tag, indicating a language, or range of languages. For example **en-us** would be American English, and **en-gb** would be British English. While **en** is a language range, meaning any variation of English.

## -examples

## -see-also
