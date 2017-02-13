---
-api-id: P:Windows.Storage.FileProperties.BasicProperties.DateModified
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime DateModified { get; }
-->

# Windows.Storage.FileProperties.BasicProperties.DateModified

## -description
Gets the timestamp of the last time the file was modified.

## -property-value
The timestamp.

## -remarks
If the date property isn't set, this value defaults to 0 which can be translated into misleading dates in different programming languages. In JavaScript, for example, 0 translates to December 16, 1600. You should always check that this property is a real value and not 0.

## -examples

## -see-also
