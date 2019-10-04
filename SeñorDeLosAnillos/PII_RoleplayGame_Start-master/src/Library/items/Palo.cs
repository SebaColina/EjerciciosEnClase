namespace RoleplayGame.Items
{
         /// <summary>
         /// Palo. Permite atacar.
         /// </summary>
         public class Palo : IAttackItem
         {

                  /// <summary>
                  /// El poder de ataque
                  /// </summary>
                  /// <value></value>
                  public int AttackPower
                  {
                           get
                           {
                                    return 100;
                           }
                  }

                  public override string ToString()
                  {
                           return "Palo";
                  }
         }
}