using UnityEngine;

public class Damage
{
    public Vector3 origin;
    public int damagePoints;
    public float pushForce;

    public Damage(Vector3 origin,int damagePoints, float pushForce)
	{
        this.origin = origin;
        this.damagePoints = damagePoints;
        this.pushForce = pushForce;
	}
}
