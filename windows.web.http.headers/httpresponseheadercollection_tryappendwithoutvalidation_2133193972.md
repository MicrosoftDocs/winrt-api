---
-api-id: M:Windows.Web.Http.Headers.HttpResponseHeaderCollection.TryAppendWithoutValidation(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool TryAppendWithoutValidation(System.String name, System.String value)
-->

# Windows.Web.Http.Headers.HttpResponseHeaderCollection.TryAppendWithoutValidation

## -description
Try to append the specified item to the [HttpResponseHeaderCollection](httpresponseheadercollection.md) without validation.

## -parameters
### -param name
The name of the item to append.

### -param value
The value of the item to append.

## -returns
**true** if the item was appended; otherwise **false**.

## -remarks
The [TryAppendWithoutValidation](httpresponseheadercollection_tryappendwithoutvalidation_2133193972.md) method is available when you need to work with an HTTP header on an HTTP response that doesn't have a strongly-typed class for the HTTP header. If there is a strongly-typed implementation of the HTTP header, then the methods and properties on the strongly-typed class should be used instead of the [TryAppendWithoutValidation](httpresponseheadercollection_tryappendwithoutvalidation_2133193972.md) method.

## -examples

## -see-also
