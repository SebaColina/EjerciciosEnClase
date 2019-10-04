namespace RoleplayGame.Items
{
    /// <summary>
    /// Gorra magica. Permite atacar y defender. Elemento compuesto por Gorra y Magia
    /// </summary>
    public class GorraMagica : IAttackItem, IDefenseItem
    {
        public Gorra gorra = new Gorra();
        public Magic magic = new Magic();

        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        
        public int AttackPower
        {
            get
            {
                return magic.AttackPower + gorra.AttackPower;
            }
        }

        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return gorra.DefensePower + magic.DefensePower;
            }
        }

        public override string ToString()
        {
            return "Gorra magica";
        }
    }
}