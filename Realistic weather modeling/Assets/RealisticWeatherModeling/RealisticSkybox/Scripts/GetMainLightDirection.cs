using UnityEngine;

[ExecuteInEditMode]
public class GetMainLightDirection : MonoBehaviour
{
    [SerializeField] private Material skyBoxMaterial;


    private void Update()
    {
        skyBoxMaterial.SetVector("_SunDirection", transform.forward);
    }

    private void FixedUpdate()
    {
        //Debug.Log(transform.forward);
    }
}
