---
-api-id: P:Windows.UI.Composition.Visual.CenterPoint
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Numerics.Vector3 CenterPoint { get;  set; }
-->

# Windows.UI.Composition.Visual.CenterPoint

## -description
The point about which rotation or scaling occurs. Animatable



## -property-value
The point about which rotation or scaling occurs.

## -remarks

CenterPoint is relative to the offset specified in the [AnchorPoint](visual_anchorpoint.md) property.

This property can be animated. Call [CompositionObject.StartAnimation](compositionobject_startanimation_709050842.md) to associate it with a [CompositionAnimation](/windows/uwp/composition/composition-animation).


<!--
      <rem>Visual supports two forms of rotation, by axis-angle, and by orientation.  

      <p>Axis-angle rotation uses the <xref targtype="property_winrt" rid="w_ui_comp.visual_rotationangle">RotationAngle</xref>, 
      <xref targtype="property_winrt" rid="w_ui_comp.visual_rotationaxis">RotationAxis</xref>, and <xref targtype="property_winrt" rid="w_ui_comp.visual_centerpoint">CenterPoint</xref> properties 
      to specify the rotation in degrees, which axis to rotate around, and the center point of the visual to rotate around.</p>
        
      <p>Rotation by orientation uses the <xref targtype="property_winrt" rid="w_ui_comp.visual_orientation">Orientation</xref> property to specify a quaternion describing 
      an orientation and rotation in 3D space.</p></rem>-->

## -examples

## -see-also
