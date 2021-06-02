using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Camera gameCam;

    private Vector2 _cursorPos;

    private float _minXpos;
    private float _maxXpos;
    private float _minYpos;
    private float _maxYpos;

    
    void Start()
    {
        gameCam = Camera.main;

        SetScreenEdges();
    }
    void Update()
    {
        UpdatemousePosition();

        SetBoundaries();

        MovePlayer();
    }
    
    private void SetScreenEdges()
    {
        _minXpos = gameCam.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        _maxXpos = gameCam.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        _minYpos = gameCam.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        _maxYpos = gameCam.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
    }
    private void MovePlayer()
    {
        transform.position = new Vector3(_cursorPos.x, _cursorPos.y, transform.position.z);
    }
    private void UpdatemousePosition()
    {
        _cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void SetBoundaries()
    {
        _cursorPos.x = Mathf.Clamp(_cursorPos.x, _minXpos, _maxXpos);
        _cursorPos.y = Mathf.Clamp(_cursorPos.y, _minYpos, _maxYpos);
    }

}
