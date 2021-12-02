using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

/// <summary>
/// 赶在后处理开始之前，将相机的原始图像复制一份到用做剪贴板的贴图中
/// </summary>
public class Copy : MonoBehaviour
{
    [SerializeField] new Camera camera;
    [SerializeField] RenderTexture clipboard;

    void OnPostRender()
    {
        Graphics.Blit(camera.activeTexture, clipboard);
    }
}
