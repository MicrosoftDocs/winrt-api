---
-api-id: P:Windows.UI.Xaml.Controls.ItemsWrapGrid.AreStickyGroupHeadersEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool AreStickyGroupHeadersEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.ItemsWrapGrid.AreStickyGroupHeadersEnabled

## -description
Gets or sets a value that specifies whether a group header moves with the group when the group is panned vertically.



## -property-value
**true** if the group header moves with the group when the group is panned vertically; otherwise, **false**. The default is **true**.

## -remarks
Group headers can be sticky only when the group is panned vertically and the [GroupHeaderPlacement](itemswrapgrid_groupheaderplacement.md) is **Top**. If the panel's [Orientation](itemswrapgrid_orientation.md) is **Horizontal** or [GroupHeaderPlacement](itemswrapgrid_groupheaderplacement.md) is not **Top**, this property is ignored.

## -examples
```xaml
<GridView>
    <GridView.ItemsPanel> 
        <ItemsPanelTemplate>
            <ItemsWrapGrid AreStickyGroupHeadersEnabled="False" Orientation="Horizontal"/>  
        </ItemsPanelTemplate> 
    </GridView.ItemsPanel> 
</GridView> 

```



## -see-also
