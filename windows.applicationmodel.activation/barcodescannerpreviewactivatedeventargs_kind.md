---
-api-id: P:Windows.ApplicationModel.Activation.BarcodeScannerPreviewActivatedEventArgs.Kind
-api-type: winrt property
---

<!-- Property syntax.
public ActivationKind Kind { get; }
-->

# Windows.ApplicationModel.Activation.BarcodeScannerPreviewActivatedEventArgs.Kind

## -description
Gets the activation type.

## -property-value
Activation kind.

## -remarks

## -see-also
[ActivationKind.BarcodeScannerProvider](activationkind.md)

## -examples
This example checks whether the activation is a **BarcodeScannerProvider** value. 

```csharp
protected override async void OnActivated(IActivatedEventArgs args)
{
    base.OnActivated(args);

    if (args.Kind == ActivationKind.BarcodeScannerProvider)
    {
        // Implement activation for provider.
    }
}
```
