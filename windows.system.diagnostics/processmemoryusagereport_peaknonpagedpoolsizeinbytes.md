---
-api-id: P:Windows.System.Diagnostics.ProcessMemoryUsageReport.PeakNonPagedPoolSizeInBytes
-api-type: winrt property
---

<!-- Property syntax
public ulong PeakNonPagedPoolSizeInBytes { get; }
-->

# Windows.System.Diagnostics.ProcessMemoryUsageReport.PeakNonPagedPoolSizeInBytes

## -description
Gets the maximum amount of non-paged memory used by the process, in bytes.

## -property-value
The maximum amount of non-paged memory used by the process, in bytes.

## -remarks
The value returned by this property value represents the maximum size of non-paged memory used by the process since it started. The operating system uses the virtual memory paging file in conjunction with physical memory to manage the virtual address space for each process. When pageable memory is not in use, it can be transferred to the virtual memory paging file on disk.

## -examples

## -see-also
