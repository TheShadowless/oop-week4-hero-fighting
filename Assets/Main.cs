using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
   
    void Start()
    {
        IronMan IronMan = new IronMan("Tony Stark", 100 ,"Red");
        Debug.Log($"IronMan Name: {IronMan.Name}, HP: {IronMan.Hp}, Suit Color: {IronMan.SuitColor}");

        CapAmerica CapAmerica = new CapAmerica("Steve Roger", 100, "Green");
        Debug.Log($"Captan america Name: {CapAmerica.Name}, HP: {CapAmerica.Hp}, Suit Color: {CapAmerica.SuitColor}");
        //fighting loop
        while ( IronMan.Hp > 0 && CapAmerica.Hp > 0)
        {   //ironman random skill to use
            int ironmanRand = Random.Range(1, 3); 
            if ( ironmanRand == 1 )
            {
                CapAmerica.Hp -= 10;
                IronMan.ShootLaser();
                CapAmerica.TakeDamage(CapAmerica.Hp);
            }
            else
            {
                CapAmerica.Hp -= 20;
                IronMan.ShootLaser();
                CapAmerica.TakeDamage(CapAmerica.Hp);
            }

            if (CapAmerica.Hp <= 0) //if ca
            {
                break;
            }
            //captan random skill to use 
            int CapAmericaRand = Random.Range(1, 3);
            if (CapAmericaRand == 1)// rand = 1 use throwshield
            {
                IronMan.Hp -= 10;
                CapAmerica.ThrowShield();
                IronMan.TakeDamage(IronMan.Hp);
            }
            else
            { //if not
                IronMan.Hp -= 20;
                CapAmerica.ThrowShield();
                IronMan.TakeDamage(IronMan.Hp);
            }

            if (IronMan.Hp <= 0)
            {
                break;
            }
        }
        

    }
}
