namespace RoleplayGame.Items
{
    /// <summary>
    /// Crocs. Permite atacar. Su poder aumenta con pines.
    /// </summary>
    public class Crocs : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "Crocs";
        }
    }
}