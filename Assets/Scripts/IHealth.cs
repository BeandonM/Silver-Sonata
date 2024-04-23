public interface IHealth
{
    float health { get; set; }
    float maxHealth { get; set; }

    public float getHealth();
    public void setHealth(float hp);
}
