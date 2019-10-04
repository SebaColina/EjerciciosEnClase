namespace RoleplayGame.Items
{
    /// <summary>
    /// Cadena. Permite atacar.
    /// </summary>
    public class Cadena : IAttackItem
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
            return "Cadena";
        }
    }
}