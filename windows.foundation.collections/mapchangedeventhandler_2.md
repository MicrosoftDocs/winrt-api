---
-api-id: T:Windows.Foundation.Collections.MapChangedEventHandler`2
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void MapChangedEventHandler<K, V>(Windows.Foundation.Collections.IObservableMap<K, V> sender, Windows.Foundation.Collections.IMapChangedEventArgs<K> event)
-->
# Windows.Foundation.Collections.MapChangedEventHandler<K, V>

## -description
Represents the method that handles the changed event of an observable map.

## -parameters
### -param sender
The observable map that changed.

### -param event
The description of the change that occurred in the map.


## -remarks
This delegate is used by the [PropertySet.MapChanged](propertyset_mapchanged.md) event and the [IObservableMap.MapChanged](iobservablemap_2_mapchanged.md) event.

## -examples

## -see-also
[IMapChangedEventArgs&lt;K&gt;](imapchangedeventargs_1.md), [IObservableMap&lt;K,V&gt;](iobservablemap_2.md)