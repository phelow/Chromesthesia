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
    

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        SetValueInHeavy(Mathf.Lerp(m_minValue, m_maxValue, Mathf.InverseLerp(m_leftTerminus.transform.position.x, m_rightTerminus.transform.position.x, this.transform.position.x)));
	}

    protected virtual void SetValueInHeavy(float value)
    {
        Debug.LogWarning("SetValueInHeavy Not implemented");
    }


}
