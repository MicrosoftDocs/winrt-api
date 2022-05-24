---
-api-id: M:Windows.Web.Http.Headers.HttpChallengeHeaderValueCollection.GetMany(System.UInt32,Windows.Web.Http.Headers.HttpChallengeHeaderValue[])
-api-type: winrt method
---

<!-- Method syntax
public uint GetMany(System.UInt32 startIndex, Windows.Web.Http.Headers.HttpChallengeHeaderValue[] items)
-->

# Windows.Web.Http.Headers.HttpChallengeHeaderValueCollection.GetMany

## -description
Retrieves the [HttpChallengeHeaderValue](httpchallengeheadervalue.md) items that start at the specified index in the collection.

## -parameters
### -param startIndex
The zero-based index of the start of the [HttpChallengeHeaderValue](httpchallengeheadervalue.md) items in the [HttpChallengeHeaderValueCollection](httpchallengeheadervaluecollection.md).

### -param items
An array of [HttpChallengeHeaderValue](httpchallengeheadervalue.md) items that start at *startIndex* in the [HttpChallengeHeaderValueCollection](httpchallengeheadervaluecollection.md).

## -returns
The number of [HttpChallengeHeaderValue](httpchallengeheadervalue.md) items retrieved.

## -remarks
The elements are copied to the array in the same order in which the enumerator iterates through the collection. It's typical to specify *startIndex* as 0 if all you're doing is making a simple copy of the collection items, where you've created a destination array with a length that matches the [Size](httpchallengeheadervaluecollection_size.md) of the collection you're copying.

This method will throw an exception if the number of elements in the source collection is greater than the length of the destination array specified in *items*.

If you are programming using Visual C++ component extensions (C++/CX) or JavaScript, you can make an [IVectorView](../windows.foundation.collections/ivectorview_1.md) copy by calling the [GetView](httpchallengeheadervaluecollection_getview_37498667.md) method.

## -examples

## -see-also
[HttpChallengeHeaderValue](httpchallengeheadervalue.md)
