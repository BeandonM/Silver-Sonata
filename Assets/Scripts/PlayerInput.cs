using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerInput : MonoBehaviour, IInput
{
    public Vector2 getMove()
    {
        return new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }
}
