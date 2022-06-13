using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_of_Thieves_helper
{
	public static class FishDataBase
	{
		private static readonly string FISH_PHOTO_PATH = "Images\\fishes";
		public static List<Fish> Fishes { get; private set; } = new List<Fish>()
		{
			new Fish("splashtail", "Splashtails are found in most open bodies of water.Does not require Bait to catch.", $"{FISH_PHOTO_PATH}\\Ruby_Splashtail.jpg",
				new Species[]{
					new Species ("rubyqqsplashtail", "Base variant", "",
						new FishCost[]{
							new FishCost(75, 190),
							new FishCost(100, 255),
							new FishCost(115, 285),
							new FishCost(15, 45)
						}
					),
					new Species ("sunny splashtail", "Common variant", "",
						new FishCost[]{
							new FishCost(150, 375),
							new FishCost(205, 505),
							new FishCost(255, 565),
							new FishCost(35, 85)
						}
					),
					new Species ("indigo splashtail", "Uncommon variant", "",
						new FishCost[]{
							new FishCost(255, 565),
							new FishCost(305, 765),
							new FishCost(340, 850),
							new FishCost(50, 130)
						}
					),
					new Species ("umber splashtail", "Rare variant", "",
						new FishCost[]{
							new FishCost(375, 940),
							new FishCost(505, 1270),
							new FishCost(565, 1470),
							new FishCost(80, 210)
						}
					),
					new Species ("seafoam splashtail", "Night variant", "",
						new FishCost[]{
							new FishCost(150, 375),
							new FishCost(205, 505),
							new FishCost(225, 565),
							new FishCost(35, 80)
						}
					),
				}
			),
			new Fish("pondie", "Pondies are found in freshwater Ponds. Does not require Bait to catch.", $"{FISH_PHOTO_PATH}\\Charcoal_Pondie.jpg",
				new Species[]{
					new Species ("charcoal pondie", "Base variant", "",
						new FishCost[]{
							new FishCost(75, 190),
							new FishCost(100, 255),
							new FishCost(115, 285),
							new FishCost(15, 45)
						}
					),
					new Species ("orchid pondie", "Common variant", "",
						new FishCost[]{
							new FishCost(150, 375),
							new FishCost(205, 505),
							new FishCost(255, 565),
							new FishCost(35, 85)
						}
					),
					new Species ("bronze pondie", "Uncommon variant", "",
						new FishCost[]{
							new FishCost(255, 565),
							new FishCost(305, 765),
							new FishCost(340, 850),
							new FishCost(50, 130)
						}
					),
					new Species ("bright pondie", "Rare variant", "",
						new FishCost[]{
							new FishCost(375, 940),
							new FishCost(505, 1270),
							new FishCost(565, 1470),
							new FishCost(80, 210)
						}
					),
					new Species ("moonsky pondie", "Night variant", "",
						new FishCost[]{
							new FishCost(150, 375),
							new FishCost(205, 505),
							new FishCost(225, 565),
							new FishCost(35, 80)
						}
					),
				}
			),
			new Fish("islehopper", "Islehoppers can be found in the waters surrounding Large Islands. Does not require Bait to catch.", $"{FISH_PHOTO_PATH}\\Stone_Islehopper.jpg",
				new Species[]{
					new Species ("Stone Islehopper", "Found at Shipwreck Bay, Shark Bait Cove, Crook's Hollow, Sailor's Bounty, Cannon Cove and Fetcher's Rest.", "",
						new FishCost[]{
							new FishCost(105, 265),
							new FishCost(140, 360),
							new FishCost(160, 400),
							new FishCost(25, 60)
						}
					),
					new Species ("Moss Islehopper", "Found at Ashen Reaches, Thieves' Haven, Marauder's Arch, Lone Cove, Wanderers Refuge and Ruby's Fall.", "",
						new FishCost[]{
							new FishCost(105, 265),
							new FishCost(140, 360),
							new FishCost(160, 400),
							new FishCost(25, 60)
						}
					),
					new Species ("Honey Islehopper", "Found at Discovery Ridge, Plunder Valley, Kraken's Fall, Sunken Grove, Crescent Isle and The Devil's Thirst", "",
						new FishCost[]{
							new FishCost(105, 265),
							new FishCost(140, 360),
							new FishCost(160, 400),
							new FishCost(25, 60)
						}
					),
					new Species ("Raven Islehopper", "A rare sight at any large island. (TIP: Fish for this variant during the day at any island where Amethyst Islehoppers are found. You will only get Splashtails or Raven Islehoppers.)", "",
						new FishCost[]{
							new FishCost(1050, 2625),
							new FishCost(1420, 3545),
							new FishCost(1575, 3940),
							new FishCost(235, 590)
						}
					),
					new Species ("Amethyst Islehopper", "A night time catch found at Devil's Ridge, Smuggler's Bay, Mermaid's Hideaway, The Crooked Masts, Old Faithful Isle, Flintlock Peninsula and Snake Island.", "",
						new FishCost[]{
							new FishCost(105, 265),
							new FishCost(140, 360),
							new FishCost(160, 400),
							new FishCost(25, 60)
						}
					)
				}
			),
			new Fish("ancientscale", "Ancientscales can be found in the open waters of The Ancient Isles. Requires Leeches as Bait to catch.", $"{FISH_PHOTO_PATH}\\Smoke_Ancientscale.jpg",
				new Species[]{
					new Species ("Almond Ancientscale", "Base variant", "",
						new FishCost[]{
							new FishCost(255, 565),
							new FishCost(305, 765),
							new FishCost(340, 850),
							new FishCost(50, 130)
						}
					),
					new Species ("Sapphire Ancientscale", "Common variant", "",
						new FishCost[]{
							new FishCost(300, 750),
							new FishCost(405, 1015),
							new FishCost(450, 1125),
							new FishCost(70, 170)
						}
					),
					new Species ("Smoke Ancientscale", "Uncommon variant", "",
						new FishCost[]{
							new FishCost(375, 940),
							new FishCost(505, 1270),
							new FishCost(565, 1410),
							new FishCost(85, 210)
						}
					),
					new Species ("Bone Ancientscale", "Rare variant", "",
						new FishCost[]{
							new FishCost(3000, 7500),
							new FishCost(4050, 10125),
							new FishCost(4500, 11250),
							new FishCost(675, 1690)
						}
					),
					new Species ("Starshine Ancientscale", "Night variant", "",
						new FishCost[]{
							new FishCost(300, 750),
							new FishCost(405, 1015),
							new FishCost(450, 1125),
							new FishCost(70, 170)
						}
					)
				}
			)
		};
	}
}
