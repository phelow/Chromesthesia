using UnityEngine;
using System.Collections;

public class SliderBox : MonoBehaviour {
    [SerializeField]
    protected GameObject m_leftTerminus;
    [SerializeField]
    protected GameObject m_rightTerminus;

    [SerializeField]
    protected float m_minValue;
    [SerializeField]
    protected float m_maxValue;

    [SerializeField]
    protected float m_lerpAmount;

    
    [SerializeField]
    protected float m_anchoredAmount = -1;

    [SerializeField]
    protected float m_anchorInterval = .01f;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        m_lerpAmount = Mathf.InverseLerp(m_leftTerminus.transform.position.x, m_rightTerminus.transform.position.x, this.transform.position.x);

        if(Mathf.Abs(m_lerpAmount-m_anchoredAmount) > m_anchorInterval)
        {
            m_anchoredAmount = m_lerpAmount;
            SetValueInHeavy(Mathf.Lerp(m_minValue, m_maxValue, m_anchoredAmount));
        }
	}

    protected virtual void SetValueInHeavy(float value)
    {
        Debug.LogWarning("SetValueInHeavy Not implemented");
    }


}
