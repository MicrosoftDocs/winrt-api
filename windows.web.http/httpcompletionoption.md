---
-api-id: T:Windows.Web.Http.HttpCompletionOption
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Web.Http.HttpCompletionOption : int
-->

# HttpCompletionOption

## -description
Indicates whether asynchronous [HttpClient](httpclient.md) operations are considered completed when all of the response is read, or when just the headers are read.

## -enum-fields
### -field ResponseContentRead:0
The operation should complete after reading the entire response including the content.

This is the default value.

### -field ResponseHeadersRead:1
The operation should complete as soon as a response is available and headers are read. The content is not read yet.


## -remarks

## -examples

## -see-also