---
-api-id: M:Windows.ApplicationModel.AppInstance.GetInstances
-api-type: winrt method
---

<!-- Method syntax.
public IVector<AppInstance> AppInstance.GetInstances()
-->

# Windows.ApplicationModel.AppInstance.GetInstances

## -description
Gets the registered instances of the current app.

## -returns
A list of the registered instances of the current app.

## -remarks
To register an instance, see [FindOrRegisterInstanceForKey](appinstance_findorregisterinstanceforkey_1124409949.md).

## -see-also

## -examples
This example gets a list of all the registered instances of the current app. 

```csharp
    List<AppInstance> instances = AppInstance.GetInstances();
```

