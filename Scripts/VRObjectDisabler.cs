using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRObjectDisabler : MonoBehaviour
{
    public XRController controller;

    private XRInteractorLineVisual lineVisual;
    private LineRenderer lineRenderer;

    private void Start()
    {
        lineVisual = controller.GetComponent<XRInteractorLineVisual>();
      
    }

    private void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(lineRenderer.transform.position, lineRenderer.transform.forward, out hit))
        {
            // 检测到碰撞，将碰撞到的物体设为不活跃状态
            hit.collider.gameObject.SetActive(false);
        }
    }
}
