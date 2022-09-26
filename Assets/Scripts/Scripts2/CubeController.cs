using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float _rollSpeed = 10;
    private bool _isMoving;
    public void ResetPosition()
            {
                transform.position = new Vector3(0.0f, 1.05f, 1f);
            }

    public enum Direction
            {
                Left = -1,
                Right = 1
            }

    public void Turn(Direction direction) {
        if (_isMoving) return;
        if (direction == Direction.Left) 
                Assemble(Vector3.left);
        
        if (direction == Direction.Right)
                Assemble(Vector3.right);
    }

    private IEnumerator Roll(Vector3 anchor, Vector3 axis) {
        _isMoving = true;
        for (var i = 0; i < 90 / _rollSpeed; i++) {
            transform.RotateAround(anchor, axis, _rollSpeed);
            yield return new WaitForSeconds(0.01f);
        }
        _isMoving = false;
    }

    void Assemble(Vector3 dir) {
            var anchor = transform.position + (Vector3.down + dir) * 0.5f;
            var axis = Vector3.Cross(Vector3.up, dir);
            StartCoroutine(Roll(anchor, axis));
        }
}
