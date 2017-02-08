---
-api-id: P:Windows.System.Diagnostics.ProcessMemoryUsageReport.PeakPagedPoolSizeInBytes
-api-type: winrt property
---

<!-- Property syntax
public ulong PeakPagedPoolSizeInBytes { get; }
-->

# Windows.System.Diagnostics.ProcessMemoryUsageReport.PeakPagedPoolSizeInBytes

## -description
Gets the maximum amount of paged memory used by the process, in bytes.

## -property-value
The maximum amount of paged memory used by the process, in bytes.

## -remarks
The value returned by this property value represents the maximum size of memory in the virtual memory paging file used by the process since it started. The operating system uses the virtual memory paging file in conjunction with physical memory to manage the virtual address space for each process. When pageable memory is not in use, it can be transferred to the virtual memory paging file on disk.

## -examples

## -see-also
