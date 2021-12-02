using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(PasteRenderer), PostProcessEvent.AfterStack, "Custom/Paste")]
public sealed class Paste : PostProcessEffectSettings
{

}

/// <summary>
/// 将剪贴板中的值依据遮罩要求，粘贴到屏幕中
/// </summary>
public class PasteRenderer : PostProcessEffectRenderer<Paste>
{
    static readonly Material material;
    
    static PasteRenderer()
    {
        material = new Material(Shader.Find("Hidden/Paste"));
    }
    
    public override void Render(PostProcessRenderContext context)
    {
        context.command.Blit(context.source, context.destination,material);
    }
}
