using UnityEngine;
using System.Collections;

public class Envrionment : MonoBehaviour {

    private Renderer _backgroundRenderer;
    private int _movingVertical = 0; 

    void Start()
    {
        _backgroundRenderer = GetComponent<Renderer>();
    }

	void Update () {



        _backgroundRenderer.material.SetTextureOffset("_MainTex", new Vector2(_backgroundRenderer.material.mainTextureOffset.x, _backgroundRenderer.material.mainTextureOffset.y + 0.005f));

        if (_movingVertical == -1) //left
        {
            _backgroundRenderer.material.SetTextureOffset("_MainTex", new Vector2(_backgroundRenderer.material.mainTextureOffset.x + 0.005f, _backgroundRenderer.material.mainTextureOffset.y + 0.005f));

        }
        else if (_movingVertical == 1) //right
        {
            _backgroundRenderer.material.SetTextureOffset("_MainTex", new Vector2(_backgroundRenderer.material.mainTextureOffset.x - 0.005f, _backgroundRenderer.material.mainTextureOffset.y + 0.005f));

        }
    }

    /// <summary>
    /// Sets the direction (if any) that the player is moving in order to adjust the background
    /// </summary>
    /// <param name="direction">0 == no; -1 == left; 1 == right</param>
    public void SetPlayerMovingVertically(int direction)
    {
        _movingVertical = direction;
    }

}
