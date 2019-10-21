---
-api-id: P:Windows.Media.Core.MediaStreamSource.CanSeek
-api-type: winrt property
---

<!-- Property syntax
public bool CanSeek { get;  set; }
-->

# Windows.Media.Core.MediaStreamSource.CanSeek

## -description
Gets or sets whether or not the application supports changing its position in the media time-line.

## -property-value
**true** if the application supports changing its position in the media time-line; otherwise, **false**. The default value is **false**.

## -remarks
Setting the CanSeek property to **true** implies that the application is able to handle a [Starting](mediastreamsource_starting.md) event that specifies a start offset other than the current position.

The default value is **false**.

Applications are allowed to change the value of this property at any time.

## -examples

## -see-also
