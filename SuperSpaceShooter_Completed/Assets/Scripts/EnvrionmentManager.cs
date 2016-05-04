using UnityEngine;
using System.Collections;

/// <summary>
/// Manages the environment game objects (Background texture animations for example)
/// </summary>
public class EnvrionmentManager : MonoBehaviour {

    public float _backgroundStaticSpeed = 0.005f;

    private Renderer _backgroundRenderer;
    private float _movingVerticalMutliplier = 0; 
    private float _movingHorizontalMutliplier = 0;

    void Start()
    {
        _backgroundRenderer = GetComponent<Renderer>();
    }

	void Update () {

        _backgroundRenderer.material.SetTextureOffset("_MainTex", new Vector2(
            _backgroundRenderer.material.mainTextureOffset.x, _backgroundRenderer.material.mainTextureOffset.y + _backgroundStaticSpeed));

        if (_movingHorizontalMutliplier != 0)
        {
            _backgroundRenderer.material.SetTextureOffset("_MainTex", new Vector2(
                _backgroundRenderer.material.mainTextureOffset.x + _movingHorizontalMutliplier, _backgroundRenderer.material.mainTextureOffset.y));

        }
       
        if (_movingVerticalMutliplier != 0) //Up
        {
            _backgroundRenderer.material.SetTextureOffset("_MainTex", new Vector2(
                _backgroundRenderer.material.mainTextureOffset.x, _backgroundRenderer.material.mainTextureOffset.y + _movingVerticalMutliplier));

        }

    }

    /// <summary>
    /// Sets the direction (if any) that the player is moving in order to adjust the background
    /// </summary>
    /// <param name="multiplier">Multiplier amount to apply to the texture offset</param>
    /// 
    public void SetMovingVerticallyMultiplyer(float multiplier)
    {
        _movingVerticalMutliplier = multiplier;
    }

    /// <summary>
    /// Sets the direction (if any) that the player is moving in order to adjust the background
    /// </summary>
    /// <param name="multiplier">Multiplier amount to apply to the texture offset</param>
    public void SetMovingHorizontalMultiplyer(float multiplier)
    {
        _movingHorizontalMutliplier = multiplier;
    }

}
