using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_of_Thieves_helper
{
	public static class FishDataBase
	{
		public static List<Fish> Fishes { get; private set; } = new List<Fish>()
		{
			new Fish("Splashtails", "Splashtails are found in most open bodies of water.Does not require Bait to catch.",
				new Species[]{
					new Species ("Ruby Splashtail", "Base variant", "",
						new FishCost[]{
							new FishCost(75, 190),
							new FishCost(100, 255),
							new FishCost(115, 285),
							new FishCost(15, 45)
						}
					),
					new Species ("Sunny Splashtail", "Common variant", "",
						new FishCost[]{
							new FishCost(150, 375),
							new FishCost(205, 505),
							new FishCost(255, 565),
							new FishCost(35, 85)
						}
					),
					new Species ("Indigo Splashtail", "Uncommon variant", "",
						new FishCost[]{
							new FishCost(255, 565),
							new FishCost(305, 765),
							new FishCost(340, 850),
							new FishCost(50, 130)
						}
					),
					new Species ("Umber Splashtail", "Rare variant", "",
						new FishCost[]{
							new FishCost(375, 940),
							new FishCost(505, 1270),
							new FishCost(565, 1470),
							new FishCost(80, 210)
						}
					),
					new Species ("Seafoam Splashtail", "Night variant", "",
						new FishCost[]{
							new FishCost(150, 375),
							new FishCost(205, 505),
							new FishCost(225, 565),
							new FishCost(35, 80)
						}
					),
				}
			),
			new Fish("Pondies", "Pondies are found in freshwater Ponds. Does not require Bait to catch.",
				new Species[]{
					new Species ("Charcoal Pondie", "Base variant", "",
						new FishCost[]{
							new FishCost(75, 190),
							new FishCost(100, 255),
							new FishCost(115, 285),
							new FishCost(15, 45)
						}
					),
					new Species ("Orchid Pondie", "Common variant", "",
						new FishCost[]{
							new FishCost(150, 375),
							new FishCost(205, 505),
							new FishCost(255, 565),
							new FishCost(35, 85)
						}
					),
					new Species ("Bronze Pondie", "Uncommon variant", "",
						new FishCost[]{
							new FishCost(255, 565),
							new FishCost(305, 765),
							new FishCost(340, 850),
							new FishCost(50, 130)
						}
					),
					new Species ("Bright Pondie", "Rare variant", "",
						new FishCost[]{
							new FishCost(375, 940),
							new FishCost(505, 1270),
							new FishCost(565, 1470),
							new FishCost(80, 210)
						}
					),
					new Species ("Moonsky Pondie", "Night variant", "",
						new FishCost[]{
							new FishCost(150, 375),
							new FishCost(205, 505),
							new FishCost(225, 565),
							new FishCost(35, 80)
						}
					),
				}
			)
		};
	}
}
