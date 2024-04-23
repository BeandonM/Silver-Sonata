using UnityEngine;

public class EntityData : IStats, IMoveable
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
    public void move()
    {

    }
}
