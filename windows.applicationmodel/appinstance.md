---
-api-id: T:Windows.ApplicationModel.AppInstance
-api-type: winrt class
---

<!-- Class syntax.
public class AppInstance 
-->

# Windows.ApplicationModel.AppInstance

## -description
Represents an instance of an app. 

## -remarks
The system maintains a cache of app instances.
Apps can use this cache for redirection of an app when it attempts to activate. 

When an app process is created in the `Main` method of the app, it can choose to continue to activate the current instance, or to redirect the activation to an existing instance.

The shell can provide a preferred instance for redirection.
The app is encouraged to redirect to that instance. 
The choice of whether to redirect remains with the app.

The [AppInstance](AppInstance.md) class is intended to be used in the `Main` method of the app.
If this class is used later, the property values may be `null`, and the methods may fail.

Before any instances can be returned, they must be registered with [FindOrRegisterInstanceForKey](appinstance_findorregisterinstanceforkey_1124409949.md).

This class can only be used from an app that has opted in to multi-instancing.
Specify the _SupportsMultipleInstances_ attribute on the **Application** element in the manifest for the app. 
For more information about app manifests, see [Package manifest schema reference for Windows 10](https://docs.microsoft.com/uwp/schemas/appxpackage/uapmanifestschema/schema-root).

## -see-also

## -examples

