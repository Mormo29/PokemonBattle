using UnityEngine;

[CreateAssetMenu(fileName = "FighterData", menuName = "Scriptable Objects/FighterData")]
public class FighterData : ScriptableObject
{
    public float maxHealth;
    public string fightername;
    public AttackData[] attacks;
}
[System.Serializable]
public class AttackData
{
    public string name;
    public string animationName;
    public float minDamage;
    public float maxDamage;
    public GameObject chargeParticles;
    public GameObject attackParticles;
}
