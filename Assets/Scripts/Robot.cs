using UnityEngine;
using UnityEngine.AI;

public class Robot : MonoBehaviour
{
    private NavMeshAgent _agent;
    private Animator _animator;
    private Transform _target;
    private bool _hasShoot;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float range;
    private void Start()
    {
        _target = GameObject.FindGameObjectWithTag("RobotTarget").GetComponent<Transform>();
        _agent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        _agent.SetDestination(_target.position);
        _animator.SetFloat("Speed", _agent.velocity.magnitude);
        if((_target.position - transform.position).magnitude >= range || _hasShoot) return;
        Shoot();
    }
    
    private void Shoot()
    {
        _target.tag = "target";
        Instantiate(bullet, transform.position, Quaternion.identity);
        _hasShoot = true;
        EVENT.ZvonokSobitie(2);
        _target.tag = "RobotTarget";
    }
}
