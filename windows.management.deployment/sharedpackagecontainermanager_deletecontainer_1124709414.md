---
-api-id: M:Windows.Management.Deployment.SharedPackageContainerManager.DeleteContainer(System.String,Windows.Management.Deployment.DeleteSharedPackageContainerOptions)
-api-type: winrt method
---

# Windows.Management.Deployment.SharedPackageContainerManager.DeleteContainer(System.String,Windows.Management.Deployment.DeleteSharedPackageContainerOptions)

<!--
public Windows.Management.Deployment.DeleteSharedPackageContainerResult DeleteContainer (string id, Windows.Management.Deployment.DeleteSharedPackageContainerOptions options);
-->


## -description

Deletes the specified package container.

## -parameters

### -param id

The ID of the package to delete.

### -param options

A [DeleteSharedPackageContainerOptions](deletesharedpackagecontaineroptions.md) object specifying options for the delete operation.

## -returns

A [DeleteSharedPackageContainerResult](deletesharedpackagecontainerresult.md) object providing status information about the delete operation.

## -remarks

Deletion destroys the container and all of its data in the current manager scope.  For a user-scoped manager, it only removes for the current user. For a machine-scoped manager, it deprovisions the container so future users won’t acquire it. 

## -see-also

## -examples


