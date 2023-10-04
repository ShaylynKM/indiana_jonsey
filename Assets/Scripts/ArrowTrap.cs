using UnityEngine;

public class ArrowTrap : MonoBehaviour
{
    [SerializeField] private float attackCoolDown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] arrows;
    private float cooldownTimer;
    [SerializeField]private bool active; //if set to active it will be firing

    private void Attack()
    {
        cooldownTimer = 0;
        arrows[FindArrow()].transform.position = firePoint.position;
        arrows[FindArrow()].GetComponent<EnemyProjectile>().ActiveProjectile();
    }
    private int FindArrow()
    {
        for (int i = 0; i < arrows.Length; i++)
        {
            if (!arrows[i].activeInHierarchy)
                return i;
        }
        return 0;
    }
    private void Update()
    {   
        if (active)
        {
            cooldownTimer += Time.deltaTime;
            if (cooldownTimer >= attackCoolDown)
            {
                Attack();
            }
        }
        
    }

    public void Activate()
    {
        active = !active;
    }
}
