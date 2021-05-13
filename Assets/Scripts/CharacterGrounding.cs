using UnityEngine;

public class CharacterGrounding : MonoBehaviour
{
    [SerializeField] Transform _leftFoot;
    [SerializeField] Transform _rightFoot;
    [SerializeField] float _maxDistance;
    [SerializeField] LayerMask _layerMask;
    public bool IsGrounded { get; private set; }

    void Update()
    {
        CheckFootForGrounding(_leftFoot);
        if (IsGrounded == false)
            CheckFootForGrounding(_rightFoot);
    }

    void CheckFootForGrounding(Transform foot)
    {
        var raycastHit = Physics2D.Raycast(foot.position, Vector2.down, _maxDistance, _layerMask);
        Debug.DrawRay(foot.position, Vector3.down * _maxDistance, Color.red);
        if (raycastHit.collider != null)
        {
            IsGrounded = true;
        }
        else
        {
            IsGrounded = false;
        }
    }
}