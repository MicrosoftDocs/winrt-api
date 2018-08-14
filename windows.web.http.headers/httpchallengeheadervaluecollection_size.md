---
-api-id: P:Windows.Web.Http.Headers.HttpChallengeHeaderValueCollection.Size
-api-type: winrt property
---

<!-- Property syntax
public uint Size { get; }
-->

# Windows.Web.Http.Headers.HttpChallengeHeaderValueCollection.Size

## -description
Gets the number of [HttpChallengeHeaderValue](httpchallengeheadervalue.md) objects in the collection.

## -property-value
The number of [HttpChallengeHeaderValue](httpchallengeheadervalue.md) objects in the [HttpChallengeHeaderValueCollection](httpchallengeheadervaluecollection.md).

## -remarks
The [Size](httpchallengeheadervaluecollection_size.md) value returns the true number of items. API that use the index, such as [IndexOf](httpchallengeheadervaluecollection_indexof_643099624.md), use a zero-based index, so you would subtract one from [Size](httpchallengeheadervaluecollection_size.md) in order to specify that you want the last item in the collection.

If you are programming using C# or Microsoft Visual Basic, the equivalent method is [Count](httpchallengeheadervaluecollection_count.md).

## -examples

## -see-also
