---
-api-id: P:Windows.ApplicationModel.DataTransfer.ClipboardContentOptions.HistoryFormats
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public IVector<string> HistoryFormats { get; }
-->

# Windows.ApplicationModel.DataTransfer.ClipboardContentOptions.HistoryFormats

## -description
Gets the list of data formats supported in the clipboard history for the content being added to the clipboard.

## -property-value
The list of data formats supported in the clipboard history for the content being added to the clipboard. We recommend that you add data formats to this list by using the static properties of the [StandardDataFormats](standarddataformats.md) class.

## -remarks

If this property is an empty list, then all data formats are eligible for clipboard history.

This property is ignored if the clipboard data does not get added to clipboard history.

## -see-also

## -examples
