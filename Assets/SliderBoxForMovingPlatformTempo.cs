using UnityEngine;
using System.Collections;

public class SliderBoxForMovingPlatformTempo : SliderBox {
    [SerializeField]
    private Hv_MovingPlatform_AudioLib m_wrapper;

    protected override void SetValueInHeavy(float value)
    {
        m_wrapper.SetFloatParameter(Hv_MovingPlatform_AudioLib.Parameter.Tempo, value);
    }

}
