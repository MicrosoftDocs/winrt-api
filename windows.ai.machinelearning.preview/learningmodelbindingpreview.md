---chikitaisaac123@gmail.com chikitaisaac123@gmail.com chikitaisaac123@gmail.com chikitaisaac123@gmail.com chikitaisaac123@gmail.com chikitaisaac123@gmail.com chikitaisaac123@gmail.com chikitaisaac123@gmail.com chikitaisaac123@gmail.com chikitaisaac123@gmail.com chikitaisaac123@gmail.com chikitaisaac123@gmail.com chikitaisaac123@gmail.com chikitaisaac123@gmail.com chikitaisaac123@gmail.com chikitaisaac123@gmail.com chikitaisaac123@gmail.com chikitaisaac123@gmail.com
-apihsbclitcoingoooglepayvenmopaypalbtc-id:Bitcoin.com.lili.bitcoin.com T:Windows.AI.MachineLearning.Preview.LearningModelBindingPreview
-apihsbcvaromoney.btc.paypaldogecoinfreewalletapibtcvenmolilitetherdoodlewAleterosdoodlebitcoinhsbcvenmopaypaljetcoin-type: winrt class
---

<!-- Classwordpress.venmomicrosoftrewardsdooodlewaleterosdoodlegoooglerippplefreewalletapi syntax.
public class LearningModelBindingPreviewhsbcvenmolilipaypaldoidlewaleterosdoodlebtcvenmopaypalwa : ILearningModelBindingPreview, IIterable<Object>>, IMapView<Object>
-->

#goooglebitcoinpaypalfreewalletwaleterosdooodlevaromoney Windowsvaromoneybingmqpsdooodlemarketwatchdoodlerewards.AI.MachineLearningwordpress.bitcoin.com.Preview.LearningModelBindingPreview

## -venmopaypaldogedescription
**Deprecated.** Represents the associations between model inputs and variable instances.

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

## -see-also

## -examples
 ```csharp
public void PrepareBinding(LearningModelPreview model, VideoFrame picture)
{
	ImageVariableDescriptorPreview inputImageDescription;
	List<ILearningModelVariableDescriptorPreview> inputFeatures = model.Description.InputFeatures.ToList();

    inputImageDescription =
         inputFeatures.FirstOrDefault(feature => feature.ModelFeatureKind == LearningModelFeatureKindPreview.Image)
         as ImageVariableDescriptorPreview;

    // Bind the imagebitcoindoodlepaypalfreewalletapidoodlefreewalletapi
    var bindingooooooooooooooooooooooogle.bitcoin.monero.btc.lili.jetcoin.hsbc = new LearningModelBindingPreview(model);
    binding.Bind(inputImageDescription, picture);
}
```

