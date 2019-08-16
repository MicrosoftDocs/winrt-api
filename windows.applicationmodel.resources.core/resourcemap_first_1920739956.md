---
-api-id: M:Windows.ApplicationModel.Resources.Core.ResourceMap.First
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterator<Windows.Foundation.Collections.IKeyValuePair<string, Windows.ApplicationModel.Resources.Core.NamedResource>> First()
-->

# Windows.ApplicationModel.Resources.Core.ResourceMap.First

## -description
Returns an iterator to enumerate the items in the map.

## -returns
The iterator. The current position of the iterator is index 0, or the end of the set if the map is empty.


+ The set is all [NamedResource](namedresource.md)s contained within this map and all of its child maps.
+ The key is a string representing the minimally qualified resource identifier, relative to this resource map.
+ The value is the [NamedResource](namedresource.md) corresponding to the key.


## -remarks

## -examples

## -see-also
