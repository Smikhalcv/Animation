using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadPlayer : MonoBehaviour
{
    private Vector3 _startPosition;
    [SerializeField] private ParticleSystem _deadPlayerParticle;
    [SerializeField] private GameObject _bodyBall;
    private Rigidbody _rgBall;


    private void Awake()
    {
        GlobalEvents.HitToPlayer.AddListener(DeathPlayer);
    }

    private void Start()
    {
        _startPosition = transform.position;
        _rgBall = GetComponent<Rigidbody>();
    }

    private IEnumerator SkipPlayer()
    {
        _rgBall.isKinematic = true;
        _bodyBall.gameObject.SetActive(false);
        _deadPlayerParticle.Play();
        yield return new WaitForSecondsRealtime(_deadPlayerParticle.duration);
        transform.position = _startPosition;
        _bodyBall.gameObject.SetActive(true);
        _rgBall.isKinematic = false;
    }

    private void DeathPlayer()
    {
        StartCoroutine(SkipPlayer());
    }
}
