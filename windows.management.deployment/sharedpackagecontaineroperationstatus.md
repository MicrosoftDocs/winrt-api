---
-api-id: T:Windows.Management.Deployment.SharedPackageContainerOperationStatus
-api-type: winrt enum
---

# Windows.Management.Deployment.SharedPackageContainerOperationStatus

<!--
public enum SharedPackageContainerOperationStatus
-->


## -description

Specifies the status result of a shared package container operation initiated with [SharedPackageContainerManager](sharedpackagecontainermanager.md).

## -enum-fields

### -field Success: 0

The operation was successful.

### -field BlockedByPolicy: 1

The operation was blocked by policy.

### -field AlreadyExists: 2

The shared package container already exists.

### -field PackageFamilyExistsInAnotherContainer: 3

The operation attempted to add a package family that already exists in another container.

### -field NotFound: 4

The specified shared package container was not found.

### -field UnknownFailure: 5

Unknown failure.

## -remarks

## -see-also

## -examples


