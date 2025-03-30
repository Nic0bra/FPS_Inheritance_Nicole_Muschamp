using UnityEngine;

public class Shotgun : Gun
{
    [SerializeField] float damage = 10;
    [SerializeField] float velocity = 15;
    [SerializeField] float life = 1;
    [SerializeField] float force = 20;
    public override bool AttemptFire()
    {
        if (!base.AttemptFire())
            return false;

        var b = Instantiate(bulletPrefab, gunBarrelEnd.transform.position, gunBarrelEnd.rotation);
        b.GetComponent<Projectile>().Initialize(damage, velocity, life, force, null); // version without special effect

        anim.SetTrigger("shoot");
        elapsed = 0;
        ammo -= 1;

        return true;
    }

}
