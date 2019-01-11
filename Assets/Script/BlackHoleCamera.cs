using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleCamera : MonoBehaviour
{
    //[SerializeField] Material m_shader;
    //[SerializeField] Transform blackHoles;
    //[SerializeField] float ratio;
    //[SerializeField] float radius;

    //private Camera cam;

    //private Vector3 wtsp;
    //private Vector2 pos;



    //private void Awake()
    //{
    //    print("init cam");
    //    cam = GetComponent<Camera>();
    //    ratio = 1.0f / cam.aspect;
    //}

    //private void OnRenderImage(RenderTexture source, RenderTexture destination)
    //{
    //    print("here");
    //    if (m_shader && m_shader && blackHoles)
    //    {
    //        wtsp = cam.WorldToScreenPoint(blackHoles.position);
    //        if(wtsp.z > 0)
    //        {
    //            pos = new Vector2(wtsp.x / cam.pixelWidth, wtsp.y / cam.pixelHeight);
    //            // Install all the required parameters for the shader
    //            m_shader.SetVector("_Position", pos);
    //            m_shader.SetFloat("_Ratio", ratio);
    //            m_shader.SetFloat("_Rad", radius);
    //            m_shader.SetFloat("_Distance", Vector3.Distance(blackHoles.position, transform.position));
    //            // And is applied to the resulting image.
    //            Graphics.Blit(source, destination, m_shader);
    //            print("send attribut");
    //        }
    //        else
    //        {
    //            print("no visible");
    //        }
    //    }
    //    else
    //    {
    //        print("Element manquant");
    //    }
    //}
}
