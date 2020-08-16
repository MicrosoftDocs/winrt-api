---
-api-id: P:Windows.Services.TargetedContent.TargetedContentCollection.Path
-api-type: winrt property
---

<!-- Property syntax.
public string Path { get; }
-->

# Windows.Services.TargetedContent.TargetedContentCollection.Path

## -description

Gets the path to an item in the content collection.

## -property-value

## -remarks

## -see-also

## -examples

This example shows how to get a specific object from a known path. Specifically, item 0 under collection 1 ("\collection1\item1") as described by the data contract.

We assume that `container` is a pre-existing subscription content container.

Finally, we launch the URI associated with the item.

```csharp
private async void LaunchObjectUriFromPath(TargetedContentContainer container)
{
    TargetedContentObject contentObject = container.SelectSingleObject("//collection[1]/item[0]");

    await contentObject.Item.Properties["onClick"].Uri.LauchUriAsync();
    }
}
```

## -capabilities

secondaryAuthenticationFactor
