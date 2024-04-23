using UnityEngine;

public class EntityData : IStats, IMoveStats
{
    public float health { get; set; }
    public float maxHealth { get; set; }
    public int str { get; set; }
    public int end { get; set; }
    public int wis { get; set; }
    public float strMulti { get; set; }
    public float endMulti { get; set; }
    public float wisMulti { get; set; }

    public float movespeed { get; set; }
    public EntityData()
    {
        health = 100f;
        maxHealth = 100f;
        str = 1;
        end = 1;
        wis = 1;
        strMulti = 1f;
        endMulti = 1f;
        wisMulti = 1f;
        movespeed = 1f;
    }
    public EntityData(float health, float maxHealth, int str, int end, int wis, float strMulti, float endMulti, float wisMulti, float movespeed)
    {
        this.health = health;
        this.maxHealth = maxHealth;
        this.str = str;
        this.end = end;
        this.wis = wis;
        this.strMulti = strMulti;
        this.endMulti = endMulti;
        this.wisMulti = wisMulti;
        this.movespeed = movespeed;
    }
    
    public int getStr()
    {
        return str;
    }
    public void setStr(int s)
    {
        str = s;
    }
    public int getEnd()
    {
        return end;
    }
    public void setEnd(int e)
    {
        end = e;
    }
    public int getWis()
    {
        return wis;
    }
    public void setWis(int w)
    {
        wis = w;
    }
    public float getStrMulti()
    {
        return strMulti;
    }
    public void setStrMulti(float s)
    {
        strMulti = s;
    }
    public float getEndMulti()
    {
        return endMulti;
    }
    public void setEndMulti(float e)
    {
        endMulti = e;
    }
    public float getWisMulti()
    {
        return wisMulti;
    }
    public void setWisMulti(float w)
    {
        wisMulti = w;
    }
    public float getHealth()
    {
        return health;
    }
    public void setHealth(float hp)
    {
        health = hp;
    }
    public float getMovespeed()
    {
        return movespeed;
    }
    public void setMovespeed(float ms)
    {
        movespeed = ms;
    }
}
