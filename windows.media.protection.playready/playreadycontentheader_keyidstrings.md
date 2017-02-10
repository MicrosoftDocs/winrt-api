---
-api-id: P:Windows.Media.Protection.PlayReady.PlayReadyContentHeader.KeyIdStrings
-api-type: winrt property
---

<!-- Property syntax
public string[] KeyIdStrings { get; }
-->

# Windows.Media.Protection.PlayReady.PlayReadyContentHeader.KeyIdStrings

## -description
Gets the content key identifier string values if they are set.

## -property-value
The content key identifier string values.

## -remarks
This property returns the KeyId values as strings. In most cases these are a Base-64 encodings of the GUID KeyIds. In some situations they may be non-GUID conforming strings that for compatibility with WMDRM. The non-GUID case will never occur when more than one key identifier is present.

## -examples

## -see-also
