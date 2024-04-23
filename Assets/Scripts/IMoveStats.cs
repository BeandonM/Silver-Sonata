using UnityEngine;

public interface IMoveStats
{
    float movespeed { get; set; }
    public float getMovespeed();
    public void setMovespeed(float ms);
}
