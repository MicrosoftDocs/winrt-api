---
-api-id: P:Windows.ApplicationModel.DataTransfer.ClipboardContentOptions.RoamingFormats
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public IVector<string> RoamingFormats { get; }
-->

# Windows.ApplicationModel.DataTransfer.ClipboardContentOptions.RoamingFormats

## -description
Gets the list of data formats that can be synced to other devices for the content being added to the clipboard.

## -property-value
The list of data formats that can be synced to other devices for the content being added to the clipboard. We recommend that you add data formats to this list by using the static properties of the [StandardDataFormats](standarddataformats.md) class.

## -remarks

If this property is an empty list, then all data formats are eligible for syncing.

This property is ignored if the clipboard data is not synced to other devices.

## -see-also

## -examples
