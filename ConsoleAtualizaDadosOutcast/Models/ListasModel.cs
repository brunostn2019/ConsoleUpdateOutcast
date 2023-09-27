using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatsOutcast.Models
{
    public class ListasModel
    {
        public List<LootModel> Loots { get; set; }
        public List<LootModel> LootsPorBoss { get; set; }
        public List<LootModel> LootsMaisRaros { get; set; }
        public List<LootModel> LootsMenosRaros { get; set; }
        public List<LootModel> LootsRecentes { get; set; }
        public List<BossModel> BossesAndTheirLoots { get; set; }
        public List<PlayerModel> Players { get; set; }

        public int QuantidadePorDia { get; set; }
        public int QuantidadePorMes { get; set; }
        public int QuantidadePorAno { get; set; }
    }
}
