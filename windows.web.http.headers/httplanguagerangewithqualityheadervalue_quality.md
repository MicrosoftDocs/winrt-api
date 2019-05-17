---
-api-id: P:Windows.Web.Http.Headers.HttpLanguageRangeWithQualityHeaderValue.Quality
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<double> Quality { get; }
-->

# Windows.Web.Http.Headers.HttpLanguageRangeWithQualityHeaderValue.Quality

## -description
Gets the value of the **qvalue** or quality factor from the [HttpLanguageRangeWithQualityHeaderValue](httplanguagerangewithqualityheadervalue.md) used in the **Accept-Language** HTTP header.

## -property-value
The value of the **qvalue** or quality factor.

## -remarks
Each language-range can be given an associated quality value representing an estimate of the user's preference for the languages specified by that range. The quality must be in the range 0.0 to 1.0. No value for the Quality property is the same as q=1.

## -examples

## -see-also
