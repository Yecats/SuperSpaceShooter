using UnityEngine;
using System.Collections;

/// <summary>
/// Manages the environment game objects (Background texture animations for example)
/// </summary>
public class EnvrionmentManager : MonoBehaviour {

    public float _backgroundStaticSpeed = 0.005f;

    private Renderer _backgroundRenderer;
    private float _movingVerticalMutliplyer = 0; 
    private float _movingHorizontalMutliplyer = 0;

    void Start()
    {
        _backgroundRenderer = GetComponent<Renderer>();
    }

	void Update () {

        _backgroundRenderer.material.SetTextureOffset("_MainTex", new Vector2(
            _backgroundRenderer.material.mainTextureOffset.x, _backgroundRenderer.material.mainTextureOffset.y + _backgroundStaticSpeed));

        if (_movingHorizontalMutliplyer > 0) //left
        {
            _backgroundRenderer.material.SetTextureOffset("_MainTex", new Vector2(
                _backgroundRenderer.material.mainTextureOffset.x + _movingHorizontalMutliplyer, _backgroundRenderer.material.mainTextureOffset.y));

        }
        else if (_movingHorizontalMutliplyer < 0) //right
        {
            _backgroundRenderer.material.SetTextureOffset("_MainTex", new Vector2(
                _backgroundRenderer.material.mainTextureOffset.x + _movingHorizontalMutliplyer, _backgroundRenderer.material.mainTextureOffset.y));

        }
       
        if (_movingVerticalMutliplyer > 0) //Up
        {
            _backgroundRenderer.material.SetTextureOffset("_MainTex", new Vector2(
                _backgroundRenderer.material.mainTextureOffset.x, _backgroundRenderer.material.mainTextureOffset.y + _movingVerticalMutliplyer));

        }

        else if (_movingVerticalMutliplyer < 0) //Down
        {
            _backgroundRenderer.material.SetTextureOffset("_MainTex", new Vector2(
                _backgroundRenderer.material.mainTextureOffset.x, _backgroundRenderer.material.mainTextureOffset.y + _movingVerticalMutliplyer));

        }
    }

    /// <summary>
    /// Sets the direction (if any) that the player is moving in order to adjust the background
    /// </summary>
    /// <param name="multiplyer">Multiplyer amount to apply to the texture offset</param>
    /// 
    public void SetMovingVerticallyMultiplyer(float multiplyer)
    {
        _movingVerticalMutliplyer = multiplyer;
    }

    /// <summary>
    /// Sets the direction (if any) that the player is moving in order to adjust the background
    /// </summary>
    /// <param name="multiplyer">Multiplyer amount to apply to the texture offset</param>
    public void SetMovingHorizontalMultiplyer(float multiplyer)
    {
        _movingHorizontalMutliplyer = multiplyer;
    }

}
