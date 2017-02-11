---
-api-id: M:Windows.Web.Http.Headers.HttpChallengeHeaderValueCollection.InsertAt(System.UInt32,Windows.Web.Http.Headers.HttpChallengeHeaderValue)
-api-type: winrt method
---

<!-- Method syntax
public void InsertAt(System.UInt32 index, Windows.Web.Http.Headers.HttpChallengeHeaderValue value)
-->

# Windows.Web.Http.Headers.HttpChallengeHeaderValueCollection.InsertAt

## -description
Inserts an [HttpChallengeHeaderValue](httpchallengeheadervalue.md) into the collection at the specified index.

## -parameters
### -param index
The zero-based index at which *value* should be inserted.

### -param value
The object to insert into the collection.

## -remarks
To add an item to the end position in the collection, you can use the [Append](httpchallengeheadervaluecollection_append.md) method. Calling [InsertAt](httpchallengeheadervaluecollection_insertat.md) with an *index* value that is the same as the [Size](httpchallengeheadervaluecollection_size.md) value is equivalent to calling [Append](httpchallengeheadervaluecollection_append.md).

If you are programming using C# or Microsoft Visual Basic, the equivalent method is [Insert](httpchallengeheadervaluecollection_insert.md).



## -examples

## -see-also
