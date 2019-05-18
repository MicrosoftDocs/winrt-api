---
-api-id: T:Windows.Web.Http.HttpBufferContent
-api-type: winrt class
---

<!-- Class syntax.
public class HttpBufferContent : Windows.Foundation.IClosable, Windows.Foundation.IStringable, Windows.Web.Http.IHttpContent
-->

# Windows.Web.Http.HttpBufferContent

## -description
Provides HTTP content that uses a buffer.

## -remarks
When sending (POST method) an HttpBufferContent class, the [HttpProgress.BytesSent](httpprogress.md) value jumps from 0% bytes sent to 100% bytes sent in one progress event, because the whole buffer is moved to lower network APIs all at once. For more detailed progress, use [HttpStreamContent](httpstreamcontent.md) instead of HttpBufferContent, because streams are read and sent in smaller chunks, resulting in more progress events. E.g. 0 bytes sent, 65536 bytes sent, 131072 bytes sent, etc.

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md), [IHttpContent](ihttpcontent.md), [IStringable](../windows.foundation/istringable.md)
