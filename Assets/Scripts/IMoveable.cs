using UnityEngine;

public interface IMoveable
{
    float movespeed { get; set; }

    public void move();
    public float getMovespeed();
    public void setMovespeed(float ms);
}
