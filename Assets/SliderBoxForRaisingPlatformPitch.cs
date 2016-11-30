using UnityEngine;
using System.Collections;

public class SliderBoxForRaisingPlatformPitch : SliderBox
{
    [SerializeField]
    private Hv_RaisingPlatform_AudioLib m_wrapper;

    protected override void SetValueInHeavy(float value)
    {
        m_wrapper.SetFloatParameter(Hv_RaisingPlatform_AudioLib.Parameter.Pitch, value);
    }

}
