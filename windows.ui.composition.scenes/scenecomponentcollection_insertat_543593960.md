---
-api-id: M:Windows.UI.Composition.Scenes.SceneComponentCollection.InsertAt(System.UInt32,Windows.UI.Composition.Scenes.SceneComponent)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public void SceneComponentCollection.InsertAt(UInt32 index, SceneComponent value)
-->

# Windows.UI.Composition.Scenes.SceneComponentCollection.InsertAt

## -description

Inserts the specified item at the specified index.



## -parameters
### -param index

The zero-based index at which to insert the item.

### -param value

The object to insert into the collection.

## -remarks

InsertAt expands the collection and moves all subsequent index items by one.

In contrast, SetAt replaces the item at the index, and the collection count remains the same.

## -see-also

[SceneComponent](scenecomponent.md), [SceneNode.Components](scenenode_components.md)

## -examples

