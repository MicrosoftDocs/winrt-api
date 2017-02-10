---
-api-id: P:Windows.System.Diagnostics.ProcessMemoryUsageReport.PagedPoolSizeInBytes
-api-type: winrt property
---

<!-- Property syntax
public ulong PagedPoolSizeInBytes { get; }
-->

# Windows.System.Diagnostics.ProcessMemoryUsageReport.PagedPoolSizeInBytes

## -description
Gets the amount of paged memory available to the process, in bytes.

## -property-value
The amount of memory, in bytes, allocated by the associated process that can be written to the virtual memory paging file.

## -remarks
The value returned by this property represents the current size of memory in the virtual memory paging file used by the process. The operating system uses the virtual memory paging file in conjunction with physical memory to manage the virtual address space for each process. When pageable memory is not in use, it can be transferred to the virtual memory paging file on disk.

## -examples

## -see-also
