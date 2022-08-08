
using System;

class MainClass {


  public static void Main (string[] args) {
    Character playerOne = new Character();
    Character playerTwo = new Character();

    playerOne.name="J1";
    playerOne.lifeCounter=100;
    playerOne.attackForce=1000;
    playerOne.defenseForce=50;

    playerOne.name="J2";
    playerOne.lifeCounter=500;
    playerOne.attackForce=80;
    playerOne.defenseForce=500;


    while (playerOne.IsAllive() && playerTwo.isAllive())
    {
      playerOne.Attack(playerTwo);
      playerTwo.Attack(playerOne);
    }

    if(playerOne.IsAllive()){
      Console.Write("Joueur 1 a gagné")
    } else{
        Console.Write("Joueur 2 a gagné")

    }
  }
    public class Character{

    public string name;
    public int lifeCounter;
    public int attackForce;
    public int defenseForce;

    public void IsAllive(){

      return (lifeCounter > 0) 
    }

    void Attack(Character otherChar){

      otherChar.lifeCounter = otherChar.lifeCounter - (attackForce - otherChar.defenseForce)
      ;
    }

    }



  }




