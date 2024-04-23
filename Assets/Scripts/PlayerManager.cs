using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private EntityData playerData;
    [SerializeField] private float startHealth = 100f;
    [SerializeField] private float startMaxHealth = 100f;
    [SerializeField] private int startStr = 1;
    [SerializeField] private int startEnd = 1;
    [SerializeField] private int startWis = 1;
    [SerializeField] private float startStrMulti = 1f;
    [SerializeField] private float startEndMulti = 1f;
    [SerializeField] private float startWisMulti = 1f;
    [SerializeField] private float startMovespeed = 4f;
    private void Awake()
    {
        playerData = new EntityData(startHealth,startMaxHealth,startStr,startEnd,startWis,startStrMulti,startEndMulti,startWisMulti,startMovespeed);
        
    }

    public EntityData getData()
    {
        return playerData;
    }
}
