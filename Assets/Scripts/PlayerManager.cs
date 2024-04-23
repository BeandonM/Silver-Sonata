using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public EntityData playerData;

    private void Awake()
    {
        playerData = new EntityData();
    }
}
