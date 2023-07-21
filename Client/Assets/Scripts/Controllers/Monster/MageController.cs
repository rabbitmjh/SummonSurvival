using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageController : MonsterController
{
    protected override void Start()
    {
        base.Start();
        _attRange = (float)Define.MonsterAttRange.Mage;
        _range = _attRange * 2;
    }

    protected override void Attack()
    {

    }
    IEnumerator CoStartAttack()
    {
        _character.Animator.SetTrigger("Attack");
        GameObject ball = Managers.Resource.Instantiate("Creature/Fireballs/BallTailRed");
        ball.tag = "Monster";
        ball.transform.rotation = AttackAngle();
        ball.transform.position = transform.position;
        
        Destroy(ball, _lifeTime);
        yield return new WaitForSeconds(1.0f);
        _coAttack = null;
    }
}
