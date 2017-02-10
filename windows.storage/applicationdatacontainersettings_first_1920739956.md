---
-api-id: M:Windows.Storage.ApplicationDataContainerSettings.First
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterator<Windows.Foundation.Collections.IKeyValuePair<string, object>> First()
-->

# Windows.Storage.ApplicationDataContainerSettings.First

## -description
Retrieves an iterator to enumerate the settings in the settings container.

## -returns
The iterator.

## -remarks
This iterator remains valid even if the container's contents are mutated. If the container is mutated, you must get a new iterator to see the updated contents of the settings container.

## -examples

## -see-also
