using System;
using RoleplayGame.Characters;
using RoleplayGame.Items;
using RoleplayGame.Encounters;

namespace RoleplayGame.Scenarios
{
    /// <summary>
    /// Interfaz para crear Escenarios
    /// </summary>
    public class ScenarioMiddleEarth : IScenario
    {
        /// <summary>
        /// Creación de los elementos del escenario.
        /// </summary>
        Character colina;
        Character santi;
        Character dlsantos;
        public void Setup(){
            colina = new Troll("Colina");
            santi = new Elf("Santi");
            dlsantos = new Wizard("De los Santos");

            colina.AddItem(new Palo());
            colina.AddItem(new Coraza());
            santi.AddItem(new Cadena());
            santi.AddItem(new Fierro());
            dlsantos.AddItem(new GorraMagica());
            dlsantos.AddItem(new Robes());
        }

        /// <summary>
        /// Ejecución del escenario.
        /// </summary>
        public void Run(){
            EncounterFactory encounterfactory = new EncounterFactory();
            Encounter encounter = EncounterFactory.GetEncounter(EncounterType.Attack, colina, santi);
            encounter.DoEncounter();

            encounter.Reporter.ReportDead(colina);

            
        }
    }
}