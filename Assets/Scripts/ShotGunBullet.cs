using UnityEngine;

public class ShotGunBullet : Bullet
{
    [SerializeField] private float _lifeTime;

    private float _passedTime;

    private void Update()
    {
        _passedTime += Time.deltaTime;

        if (_passedTime >= _lifeTime)
            Destroy(gameObject);
    }
}
