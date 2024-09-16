
using System.Xml.Linq;
using UnityEngine;

class CapAmerica

{
    public string Name;
    public int Hp;
    public string SuitColor;
    private float armorStreangth;

    public CapAmerica(string newName, int newHp, string newSuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newSuitColor;

        armorStreangth = 10;
    }

    public void LeapAndJump()
    {
        Debug.Log($"----- {Name} is Leap and jumping");
    }

    public void ThrowShield()
    {
        Debug.Log($"----- {Name} is Throwing sheild");
    }
    public void UpdateArmorStrength(float strength)
    {
        armorStreangth += strength;
        Debug.Log($"----- {Name} updated thier armor to {armorStreangth}");
    }
    public void TakeDamage(int damage)
    {
        Debug.Log($"------ {Name} HP Remaining : {Hp} ");
        IsDead();
    }
    bool IsDead()
    {
        if (Hp <= 0)
        {
            Debug.Log($"------ {Name} Is dead");
            return true; //
        }
        else
        {
            return false; //
        }
    }
}

