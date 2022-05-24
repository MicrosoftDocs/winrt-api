---
-api-id: M:Windows.Management.Deployment.SharedPackageContainerManager.CreateContainer(System.String,Windows.Management.Deployment.CreateSharedPackageContainerOptions)
-api-type: winrt method
---

# Windows.Management.Deployment.SharedPackageContainerManager.CreateContainer(System.String,Windows.Management.Deployment.CreateSharedPackageContainerOptions)

<!--
public Windows.Management.Deployment.CreateSharedPackageContainerResult CreateContainer (string name, Windows.Management.Deployment.CreateSharedPackageContainerOptions options);
-->


## -description

## -parameters

Creates [SharedPackageContainer](sharedpackagecontainer.md) object that comprises the package families specified in the provided [CreateSharedPackageContainerOptions](createsharedpackagecontaineroptions.md) object.  

### -param name

A string containing the name of the created package. 

### -param options

A **CreateSharedPackageContainerOptions** specifying the options for the create operation.

## -returns

A [CreateSharedPackageContainerResult](deletesharedpackagecontainerresult.md) that provides status information about the create operation and access to the created **SharedPackageContainer** object.

## -remarks

Packages in the specified families will launch inside the created container.  This method can be called multiple times with the same container name to update the definition.

## -see-also

## -examples


