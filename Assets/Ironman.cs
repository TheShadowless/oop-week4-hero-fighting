using UnityEngine;

class IronMan
{
    // Attributes
    public string Name;
    public int Hp;
    public string SuitColor;
    private float ArmorStreangth;


    // Constructor
    public IronMan(string newName, int newHp, string newSuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newSuitColor;

        ArmorStreangth = 10;
    }

    public void Fly()
    {
        Debug.Log($"----- {Name} is flying");
    }

    public void ShootLaser()
    {
        Debug.Log($"----- {Name} is shooting lasers");
    }

    public void UpdateArmorStrength(float strength)
    {
        ArmorStreangth += strength;
        Debug.Log($"----- {Name} updated thier armor to {ArmorStreangth}");
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