using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

/// <summary>
/// 创建一个用以拍摄场景中的遮罩标记情况的摄像机，并将拍摄结果存放在贴图中
/// </summary>
[RequireComponent(typeof(Camera))]
public class MakeMask : MonoBehaviour
{
    [SerializeField] new Camera camera;
    [SerializeField] RenderTexture mask;
    void Start()
    {
        //创建拍摄相机
        GameObject renderCameraObject = new GameObject("BufferMaskCamera");
        renderCameraObject.transform.SetParent(camera.transform);
        //初始化相机
        Camera renderCamera = renderCameraObject.AddComponent<Camera>();
        renderCamera.CopyFrom(camera);

        renderCamera.clearFlags = CameraClearFlags.SolidColor;
        renderCamera.backgroundColor = Color.black;
        renderCamera.targetTexture = mask;
        renderCamera.SetReplacementShader(Shader.Find("Unlit/MakeMask"), "RenderType");
    }
}
