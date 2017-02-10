---
-api-id: P:Windows.Web.Http.Filters.HttpBaseProtocolFilter.AutomaticDecompression
-api-type: winrt property
---

<!-- Property syntax
public bool AutomaticDecompression { get;  set; }
-->

# Windows.Web.Http.Filters.HttpBaseProtocolFilter.AutomaticDecompression

## -description
Gets or sets a value that indicates whether the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) can automatically decompress the HTTP content response.

## -property-value
A value that indicates whether [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) can automatically decompress the HTTP content response.

This value is **true** if the if [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) can automatically decompress the HTTP content response; otherwise **false**. The default value is **true**.

## -remarks
When this property is set to **true**, the **Accept-Encoding** header is added to the headers and set to allow gzip and compress.

## -examples

## -see-also
