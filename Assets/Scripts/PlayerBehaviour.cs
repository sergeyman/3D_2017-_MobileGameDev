using UnityEngine;

/// <summary>
/// Responsible for moving the player automatically and
/// reciving input.
/// </summary>

[RequireComponent(typeof(Rigidbody))]
public class PlayerBehaviour : MonoBehaviour
{
    /// <summary>
    /// A reference to the Rigidbody component
    /// </summary>
    private Rigidbody rb;
    
    [Tooltip("How fast the ball moves left/right")]
    public float dodgeSpeed = 5;
    
    [Tooltip("How fast the ball moves forwards automatically")]
    [Range(0, 10)]
    public float rollSpeed = 5;
    
    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // Get access to our Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    // void Update()
    void FixedUpdate()
    {
        // Check if we're moving to the sideBuilding Your Game

        var horizontalSpeed = Input.GetAxis("Horizontal") * dodgeSpeed;
        // Apply our auto-moving and movement forces
        rb.AddForce(horizontalSpeed, 0, rollSpeed);
    }
}

/*
 *   ������� Update ���������� ���� ��� �� ����, �� ������� �������� ����.
 *   ������� ���������, ��� ������� ������ ������� Update �������� ����������,
 *   �� ���� ��� ����� �������� � �������� �������. ��� ������� �� ���� ��������,
 *   � ��� ����� �� ������������� ����������� �����������.
 *    This means that the more times the
 *   Update function is called, the better the computer is. We want a consistent
 *   experience for all of our players and one of the ways that we can do that is by
 *   using the FixedUpdate function.
 *   FixedUpdate ������ �� Update � ���������� ��������� ���������. ������ ����������� � ���, ��� ��� ����������
 *   ����� ������������� ��������� ���������, �� ���� � ���� � �� �� ����� ����� ��������. ����� ����� ��������, ���
 *   ��� ����� ������ FixedUpdate ������������ ���������� �������. ��� ��������, ���
 *   ���, ���������� �������, ���������� �� ������, ������ ����������� ������ ������� FixedUpdate
 *   ������, �� ����������� ������� �������, ����� ��� ������
 * 
 */