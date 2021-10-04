---
-api-id: P:Windows.Management.Deployment.UpdateSharedPackageContainerOptions.ForceAppShutdown
-api-type: winrt property
---

# Windows.Management.Deployment.UpdateSharedPackageContainerOptions.ForceAppShutdown

<!--
public bool ForceAppShutdown { get; set; }
-->


## -description

Gets or sets a value specifying whether apps with packages in the created shared container should be shut down as part of the container update operation.

## -property-value

True if apps should be shut down; otherwise, false.

## -remarks

The update operation is synchronous even though the app shutdown process is asynchronous. There is no progress to communicated to the caller when closing these applications.

## -see-also

## -examples





