namespace Asteroids
{
    public class DamageProvider : ITakeDamage
    {
        public int damage { get; set; }
        public void Hit(float damage)
        {
            //Hp -= damage;

            //if (Hp <= 0)
            //    Destroy(gameObject);
        }
    }
}