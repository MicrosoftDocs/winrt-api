---
-api-id: M:Windows.Foundation.WwwFormUrlDecoder.GetFirstValueByName(System.String)
-api-type: winrt method
---

<!-- Method syntax
public string GetFirstValueByName(System.String name)
-->

# Windows.Foundation.WwwFormUrlDecoder.GetFirstValueByName

## -description
Gets the first name-value pair that has the specified name, as obtained from the constructing Uniform Resource Identifier (URI) query string.

## -parameters
### -param name
The name of the value to get.

## -returns
The first value in list order that corresponds with *name*.

## -remarks
This method throws an exception (an error for JavaScript) if the value specified as name doesn't exist in the [WwwFormUrlDecoder](wwwformurldecoder.md) collection. For .NET code, this is typed as **System.ArgumentException**. You'll probably want to call [GetFirstValueByName](wwwformurldecoder_getfirstvaluebyname_186006860.md) within a **try-catch** block so you have a chance to handle the exception.

What to do with duplicate names in a query string from a GET request is not specified by any Internet standard. A common practice is to process the first value and ignore the subsequent duplicates. The [GetFirstValueByName](wwwformurldecoder_getfirstvaluebyname_186006860.md) method provides that behavior. It also provides the de-facto "index by string" behavior, which is typically what you want when you're processing a query string. Your app is expecting certain names to be present on the query string, and wants to retrieve the associated value.

## -examples

## -see-also
