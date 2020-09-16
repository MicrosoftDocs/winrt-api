---
-api-id: T:Windows.Foundation.Collections.CollectionChange
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Foundation.Collections.CollectionChange : int
-->

# CollectionChange

## -description
Describes the action that causes a change to a collection.

## -enum-fields
### -field Reset:0
The collection is changed.

### -field ItemInserted:1
An item is added to the collection.

### -field ItemRemoved:2
An item is removed from the collection.

### -field ItemChanged:3
An item is changed in the collection.


## -remarks
There is only one notification per type of change to a collection. For example, if an item is inserted, then only a notification for an insertion is sent to a listener that is subscribed to receive change notifications. Use the [Index](ivectorchangedeventargs_index.md) property of the [IVectorChangedEventArgs](ivectorchangedeventargs.md) interface or the [Key](imapchangedeventargs_1_key.md) property of the [IMapChangedEventArgs<K>](imapchangedeventargs_1.md) interface to determine the location of the change.

## -examples

## -see-also
[IMapChangedEventArgs&lt;K&gt;.CollectionChange property](imapchangedeventargs_1_collectionchange.md), [IVectorChangedEventArgs.CollectionChange property](ivectorchangedeventargs_collectionchange.md), [IObservableMap.MapChanged event](iobservablemap_2_mapchanged.md), [IObservableVector.VectorChanged event](iobservablevector_1_vectorchanged.md)