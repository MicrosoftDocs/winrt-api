---
-api-id: P:Windows.Media.Core.MediaStreamSample.Discontinuous
-api-type: winrt property
---

<!-- Property syntax
public bool Discontinuous { get;  set; }
-->

# Windows.Media.Core.MediaStreamSample.Discontinuous

## -description
Gets or sets a value to indicate that the previous [MediaStreamSample](mediastreamsample.md) in the sequence is missing.

## -property-value
**true** if the previous [MediaStreamSample](mediastreamsample.md) in the sequence is missing; otherwise, **false**. The default value is **false**.

## -remarks
Applications should set this property to **true** when the previous [MediaStreamSample](mediastreamsample.md) in the sequence is missing. An example of a situation when this can occur is when samples are received over a lossy network connection. The default value is **false**.

## -examples

## -see-also
