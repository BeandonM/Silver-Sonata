
using UnityEngine;

public interface IMoveable
{
    float movespeed { get; set; }

    public float getMovespeed();
    public void setMovespeed(float ms);
}
