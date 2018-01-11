---
-api-id: M:Windows.ApplicationModel.AppInstance.FindOrRegisterInstanceForKey(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public AppInstance AppInstance.FindOrRegisterInstanceForKey(String key)
-->

# Windows.ApplicationModel.AppInstance.FindOrRegisterInstanceForKey

## -description
Registers an app instance with the platform, or finds an existing instance if another instance has already registered this key.

## -parameters
### -param key
A non-empty string as a key for the instance.

## -returns
An app instance that represents the first app that registered the key. 
The caller can determine whether that instance is the current instance.

## -remarks
After an app has registered with the platform, it is returned when other instances query for app instances.

An app instance can register multiple times with different keys.
The system cache maintains one row per instance, therefore, the key is overwritten.

## -see-also

## -examples
This example returns the instance registered for the specified key.
If there was no existing app instance for that key, the method registers the current instance, and returns that instance.

```csharp
theInstance = AppInstance.FindOrRegisterInstanceForKey(key);
```

