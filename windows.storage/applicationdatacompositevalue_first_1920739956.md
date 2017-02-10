---
-api-id: M:Windows.Storage.ApplicationDataCompositeValue.First
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterator<Windows.Foundation.Collections.IKeyValuePair<string, object>> First()
-->

# Windows.Storage.ApplicationDataCompositeValue.First

## -description
Retrieves an iterator to enumerate the settings in the composite value.

## -returns
The iterator.

## -remarks
This iterator remains valid even if the composite value's contents are mutated. If the composite value is mutated, you must get a new iterator to see the updated contents of the composite value.

## -examples

## -see-also
