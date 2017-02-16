---
-api-id: P:Windows.Media.Core.MediaStreamSample.DecodeTimestamp
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan DecodeTimestamp { get;  set; }
-->

# Windows.Media.Core.MediaStreamSample.DecodeTimestamp

## -description
Gets and sets the decode timestamp for this [MediaStreamSample](mediastreamsample.md).

## -property-value
The decode timestamp.

## -remarks
The default value of [DecodeTimestamp](mediastreamsample_decodetimestamp.md) is the same value as the [Timestamp](mediastreamsample_timestamp.md) property on the [MediaStreamSample](mediastreamsample.md) object. Certain media formats may require the [DecodeTimestamp](mediastreamsample_decodetimestamp.md) property to be assigned a value that is different from the presentation timestamp given by the [Timestamp](mediastreamsample_timestamp.md) property, but for most formats the two properties will be the same.

## -examples

## -see-also
