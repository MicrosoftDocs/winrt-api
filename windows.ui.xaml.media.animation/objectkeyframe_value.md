---
-api-id: P:Windows.UI.Xaml.Media.Animation.ObjectKeyFrame.Value
-api-type: winrt property
---

<!-- Property syntax
public object Value { get;  set; }
-->

# Windows.UI.Xaml.Media.Animation.ObjectKeyFrame.Value

## -description
Gets or sets the key frame's target value.



## -xaml-syntax
```xaml
<DiscreteObjectKeyFrame>
  <DiscreteObjectKeyFrame.Value>
    singleObject
  </DiscreteObjectKeyFrame.Value>
</DiscreteObjectKeyFrame>
- or -
<DiscreteObjectKeyFrame Value="stringForObject"/>
```


## -xaml-values
<dl><dt>singleObject</dt><dd>singleObjectA single object element for the object that provides the value. This object must support object element syntax for default construction.</dd>
<dt>stringForObject</dt><dd>stringForObjectA string that is interpreted by a particular object's attributed type converter, which can generate an instance of the object. You can use this form for enumeration values, by specifying the name of the desired constant from the enumeration.</dd>
</dl>
## -property-value
The key frame's target value, which is the value of this key frame at its specified [KeyTime](objectkeyframe_keytime.md). The default is null.

## -remarks

## -examples

## -see-also
