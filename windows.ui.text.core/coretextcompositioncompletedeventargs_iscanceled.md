---
-api-id: P:Windows.UI.Text.Core.CoreTextCompositionCompletedEventArgs.IsCanceled
-api-type: winrt property
---

<!-- Property syntax
public bool IsCanceled { get; }
-->

# Windows.UI.Text.Core.CoreTextCompositionCompletedEventArgs.IsCanceled

## -description
Gets a value that indicates whether the operation is canceled.

## -property-value
**true** if the operation is canceled; otherwise, **false**.

## -remarks
If the app defers the operation, it is possible for it to be canceled before the app responds to it. For this reason, you should read this property, only once, immediately before responding to a deferred operation. 

> [!NOTE]
> The "getter" for the **IsCanceled** property notifies Windows that the app is beginning the deferred operation. You should consider reading this property as a required step before you perform the deferred operation. Use the pattern shown in the example when reading **IsCanceled**.

## -examples
```csharp
// Notify Windows that the deferred operation is beginning 
if (!args.IsCanceled)
{
    // Perform deferred operation
    // …
 
    // Notify Windows that the deferred operation is complete
    deferral.Complete();
}

```



## -see-also
