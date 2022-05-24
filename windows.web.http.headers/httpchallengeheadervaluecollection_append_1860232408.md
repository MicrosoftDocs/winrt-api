---
-api-id: M:Windows.Web.Http.Headers.HttpChallengeHeaderValueCollection.Append(Windows.Web.Http.Headers.HttpChallengeHeaderValue)
-api-type: winrt method
---

<!-- Method syntax
public void Append(Windows.Web.Http.Headers.HttpChallengeHeaderValue value)
-->

# Windows.Web.Http.Headers.HttpChallengeHeaderValueCollection.Append

## -description
Adds a new [HttpChallengeHeaderValue](httpchallengeheadervalue.md) item to the end of the collection.

## -parameters
### -param value
The [HttpChallengeHeaderValue](httpchallengeheadervalue.md) object to append.

## -remarks
After you've added an item, you can use the [IndexOf](httpchallengeheadervaluecollection_indexof_643099624.md) method to get it by index.

To add an item to a position in the collection that's not at the collection end, use the [InsertAt](httpchallengeheadervaluecollection_insertat_1228553710.md) method.

## -examples

## -see-also
[HttpChallengeHeaderValue](httpchallengeheadervalue.md)