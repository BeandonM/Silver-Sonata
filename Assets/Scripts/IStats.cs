using UnityEngine;

public interface IStats : IHealth
{
    int str { get; set; }
    int end { get; set; }
    int wis { get; set; }
    float strMulti { get; set; }
    float endMulti { get; set; }
    float wisMulti { get; set; }

    public int getStr();
    public void setStr(int s);
    public int getEnd();
    public void setEnd(int e);
    public int getWis();
    public void setWis(int w);
    public float getStrMulti();
    public void setStrMulti(float s);
    public float getEndMulti();
    public void setEndMulti(float e);
    public float getWisMulti();
    public void setWisMulti(float w);
}
