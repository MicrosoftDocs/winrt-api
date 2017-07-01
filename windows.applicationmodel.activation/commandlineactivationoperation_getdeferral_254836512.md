---
-api-id: M:Windows.ApplicationModel.Activation.CommandLineActivationOperation.GetDeferral
-api-type: winrt method
---

<!-- Method syntax.
public Deferral CommandLineActivationOperation.GetDeferral()
-->

# Windows.ApplicationModel.Activation.CommandLineActivationOperation.GetDeferral

## -description
Gets a deferral object for this operation.

## -returns
A **Deferral** object that your code uses to signal when it has finished processing the activation.

## -remarks

## -see-also

## -examples
```csharp
// The deferral is only needed if your processing requires async operations
using (Deferral deferral = operation.GetDeferral())
{
	var parsedCommands =
				ParseUntrustedArgsAsync(activationPath, cmdLineString);
    ...
}

```
