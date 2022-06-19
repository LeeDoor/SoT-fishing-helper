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
		private static readonly Rectangle WHOLE_MAP = new Rectangle(0, 0, 458, 358);
		
		public static List<Fish> Fishes { get; private set; } = new List<Fish>()
		{
			new Fish("splashtail", "everywhere", BaitType.None, $"{FISH_PHOTO_PATH}\\Ruby_Splashtail.jpg",
				new Species[]{
					new Species ("ruby splashtail", "Base variant", "",
						new FishCost[]{
							new FishCost(75, 190),
							new FishCost(100, 255),
							new FishCost(115, 285),
							new FishCost(15, 45)
						},
						new Rectangle[]
                        {
							WHOLE_MAP
						}
					),
					new Species ("sunny splashtail", "Common variant", "",
						new FishCost[]{
							new FishCost(150, 375),
							new FishCost(205, 505),
							new FishCost(255, 565),
							new FishCost(35, 85)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("indigo splashtail", "Uncommon variant", "",
						new FishCost[]{
							new FishCost(255, 565),
							new FishCost(305, 765),
							new FishCost(340, 850),
							new FishCost(50, 130)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("umber splashtail", "Rare variant", "",
						new FishCost[]{
							new FishCost(375, 940),
							new FishCost(505, 1270),
							new FishCost(565, 1470),
							new FishCost(80, 210)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("seafoam splashtail", "Night variant", "",
						new FishCost[]{
							new FishCost(150, 375),
							new FishCost(205, 505),
							new FishCost(225, 565),
							new FishCost(35, 80)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
				}
			),
			new Fish("pondie", "Freshwater Ponds", BaitType.None, $"{FISH_PHOTO_PATH}\\Charcoal_Pondie.jpg",
				new Species[]{
					new Species ("charcoal pondie", "Base variant", "",
						new FishCost[]{
							new FishCost(75, 190),
							new FishCost(100, 255),
							new FishCost(115, 285),
							new FishCost(15, 45)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("orchid pondie", "Common variant", "",
						new FishCost[]{
							new FishCost(150, 375),
							new FishCost(205, 505),
							new FishCost(255, 565),
							new FishCost(35, 85)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("bronze pondie", "Uncommon variant", "",
						new FishCost[]{
							new FishCost(255, 565),
							new FishCost(305, 765),
							new FishCost(340, 850),
							new FishCost(50, 130)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("bright pondie", "Rare variant", "",
						new FishCost[]{
							new FishCost(375, 940),
							new FishCost(505, 1270),
							new FishCost(565, 1470),
							new FishCost(80, 210)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("moonsky pondie", "Night variant", "",
						new FishCost[]{
							new FishCost(150, 375),
							new FishCost(205, 505),
							new FishCost(225, 565),
							new FishCost(35, 80)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
				}
			),
			new Fish("islehopper", "Large Islands", BaitType.None, $"{FISH_PHOTO_PATH}\\Stone_Islehopper.jpg",
				new Species[]{
					new Species ("Stone Islehopper", "Found at Shipwreck Bay, Shark Bait Cove, Crook's Hollow, Sailor's Bounty, Cannon Cove and Fetcher's Rest.", "",
						new FishCost[]{
							new FishCost(105, 265),
							new FishCost(140, 360),
							new FishCost(160, 400),
							new FishCost(25, 60)
						},
						new Rectangle[]
						{
							new Rectangle (211, 132, 30, 30),
							new Rectangle (120, 275, 30, 30),
							new Rectangle (214, 217, 30, 30),
							new Rectangle (36, 39, 30, 30),
							new Rectangle (101, 124, 30, 30),
							new Rectangle (360, 159, 30, 30)
						}
					),
					new Species ("Moss Islehopper", "Found at Ashen Reaches, Thieves' Haven, Marauder's Arch, Lone Cove, Wanderers Refuge and Ruby's Fall.", "",
						new FishCost[]{
							new FishCost(105, 265),
							new FishCost(140, 360),
							new FishCost(160, 400),
							new FishCost(25, 60)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Honey Islehopper", "Found at Discovery Ridge, Plunder Valley, Kraken's Fall, Sunken Grove, Crescent Isle and The Devil's Thirst", "",
						new FishCost[]{
							new FishCost(105, 265),
							new FishCost(140, 360),
							new FishCost(160, 400),
							new FishCost(25, 60)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Raven Islehopper", "A rare sight at any large island. (TIP: Fish for this variant during the day at any island where Amethyst Islehoppers are found. You will only get Splashtails or Raven Islehoppers.)", "",
						new FishCost[]{
							new FishCost(1050, 2625),
							new FishCost(1420, 3545),
							new FishCost(1575, 3940),
							new FishCost(235, 590)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Amethyst Islehopper", "A night time catch found at Devil's Ridge, Smuggler's Bay, Mermaid's Hideaway, The Crooked Masts, Old Faithful Isle, Flintlock Peninsula and Snake Island.", "",
						new FishCost[]{
							new FishCost(105, 265),
							new FishCost(140, 360),
							new FishCost(160, 400),
							new FishCost(25, 60)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					)
				}
			),
			new Fish("ancientscale", "The Ancient\nIsles", BaitType.Leech, $"{FISH_PHOTO_PATH}\\Smoke_Ancientscale.jpg",
				new Species[]{
					new Species ("Almond Ancientscale", "Base variant", "",
						new FishCost[]{
							new FishCost(255, 565),
							new FishCost(305, 765),
							new FishCost(340, 850),
							new FishCost(50, 130)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Sapphire Ancientscale", "Common variant", "",
						new FishCost[]{
							new FishCost(300, 750),
							new FishCost(405, 1015),
							new FishCost(450, 1125),
							new FishCost(70, 170)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Smoke Ancientscale", "Uncommon variant", "",
						new FishCost[]{
							new FishCost(375, 940),
							new FishCost(505, 1270),
							new FishCost(565, 1410),
							new FishCost(85, 210)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Bone Ancientscale", "Rare variant", "",
						new FishCost[]{
							new FishCost(3000, 7500),
							new FishCost(4050, 10125),
							new FishCost(4500, 11250),
							new FishCost(675, 1690)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Starshine Ancientscale", "Night variant", "",
						new FishCost[]{
							new FishCost(300, 750),
							new FishCost(405, 1015),
							new FishCost(450, 1125),
							new FishCost(70, 170)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					)
				}
			),
			new Fish("plentfin", "The Shores\nof Plenty", BaitType.Earthworm, $"{FISH_PHOTO_PATH}\\Olive_Plentifin.jpg",
				new Species[]{
					new Species ("Olive Plentifin", "Base variant", "",
						new FishCost[]{
							new FishCost(255, 565),
							new FishCost(305, 765),
							new FishCost(340, 850),
							new FishCost(50, 130)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Amber Plentifin", "Common variant", "",
						new FishCost[]{
							new FishCost(300, 750),
							new FishCost(405, 1015),
							new FishCost(450, 1125),
							new FishCost(70, 170)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Cloudy Plentifin", "Uncommon variant", "",
						new FishCost[]{
							new FishCost(375, 940),
							new FishCost(505, 1270),
							new FishCost(565, 1410),
							new FishCost(85, 210)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Bonedust Plentifin", "Rare variant", "",
						new FishCost[]{
							new FishCost(3000, 7500),
							new FishCost(4050, 10125),
							new FishCost(4500, 11250),
							new FishCost(675, 1690)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Watery Plentifin", "Night variant", "",
						new FishCost[]{
							new FishCost(300, 750),
							new FishCost(405, 1015),
							new FishCost(450, 1125),
							new FishCost(70, 170)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					)
				}
			),
			new Fish("wildsplash", "The Wilds", BaitType.Earthworm, $"{FISH_PHOTO_PATH}\\Russet_Wildsplash.jpg",
				new Species[]{
					new Species ("Russet Wildsplash", "Base variant", "",
						new FishCost[]{
							new FishCost(255, 565),
							new FishCost(305, 765),
							new FishCost(340, 850),
							new FishCost(50, 130)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Sandy Wildsplash", "Common variant", "",
						new FishCost[]{
							new FishCost(300, 750),
							new FishCost(405, 1015),
							new FishCost(450, 1125),
							new FishCost(70, 170)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Ocean Wildsplash", "Uncommon variant", "",
						new FishCost[]{
							new FishCost(375, 940),
							new FishCost(505, 1270),
							new FishCost(565, 1410),
							new FishCost(85, 210)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Muddy Wildsplash", "Rare variant", "",
						new FishCost[]{
							new FishCost(3000, 7500),
							new FishCost(4050, 10125),
							new FishCost(4500, 11250),
							new FishCost(675, 1690)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Coral Wildsplash", "Night variant", "",
						new FishCost[]{
							new FishCost(300, 750),
							new FishCost(405, 1015),
							new FishCost(450, 1125),
							new FishCost(70, 170)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					)
				}
			),
			new Fish("devilfish", "The Devil's\nRoar", BaitType.Grub, $"{FISH_PHOTO_PATH}\\Ashen_Devilfish.jpg",
				new Species[]{
					new Species ("Ashen Devilfish", "Base variant", "",
						new FishCost[]{
							new FishCost(255, 565),
							new FishCost(305, 765),
							new FishCost(340, 850),
							new FishCost(50, 130)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Seashell Devilfish", "Common variant", "",
						new FishCost[]{
							new FishCost(300, 750),
							new FishCost(405, 1015),
							new FishCost(450, 1125),
							new FishCost(70, 170)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Lava Devilfish", "Uncommon variant", "",
						new FishCost[]{
							new FishCost(375, 940),
							new FishCost(505, 1270),
							new FishCost(565, 1410),
							new FishCost(85, 210)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Forsaken Devilfish", "Rare variant", "",
						new FishCost[]{
							new FishCost(3000, 7500),
							new FishCost(4050, 10125),
							new FishCost(4500, 11250),
							new FishCost(675, 1690)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Firelight Devilfish", "Night variant", "",
						new FishCost[]{
							new FishCost(300, 750),
							new FishCost(405, 1015),
							new FishCost(450, 1125),
							new FishCost(70, 170)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					)
				}
			),
			new Fish("battlegill", "near Skeleton\nShips, Fort", BaitType.Grub, $"{FISH_PHOTO_PATH}\\Jade_Battlegill.jpg",
				new Species[]{
					new Species ("Jade Battlegill", "Base variant", "",
						new FishCost[]{
							new FishCost(375, 940),
							new FishCost(505, 1270),
							new FishCost(565, 1410),
							new FishCost(85, 210)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Sky Battlegill", "Common variant", "",
						new FishCost[]{
							new FishCost(450, 1125),
							new FishCost(610, 1520),
							new FishCost(675, 1690),
							new FishCost(100, 225)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Rum Battlegill", "Uncommon variant", "",
						new FishCost[]{
							new FishCost(525, 1315),
							new FishCost(710, 1775),
							new FishCost(790, 1975),
							new FishCost(120, 295)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Sand Battlegill", "Rare variant", "",
						new FishCost[]{
							new FishCost(3750, 9375),
							new FishCost(5065, 12655),
							new FishCost(5625, 14065),
							new FishCost(845, 2110)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Bittersweet Battlegill", "Night variant", "",
						new FishCost[]{
							new FishCost(450, 1125),
							new FishCost(610, 1520),
							new FishCost(675, 1690),
							new FishCost(100, 225)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					)
				}
			),
			new Fish("stormfish", "inside heavy\nStorms", BaitType.Leech, $"{FISH_PHOTO_PATH}\\Ancient_Stormfish.jpg",
				new Species[]{
					new Species ("Ancient Stormfish", "The Ancient Isles variant", "",
						new FishCost[]{
							new FishCost(450, 1125),
							new FishCost(610, 1520),
							new FishCost(675, 1690),
							new FishCost(100, 225)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Shores Stormfish", "The Shores of Plenty variant", "",
						new FishCost[]{
							new FishCost(450, 1125),
							new FishCost(610, 1520),
							new FishCost(675, 1690),
							new FishCost(100, 225)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Wild Stormfish", "The Wilds variant", "",
						new FishCost[]{
							new FishCost(450, 1125),
							new FishCost(610, 1520),
							new FishCost(675, 1690),
							new FishCost(100, 225)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Shadow Stormfish", "Rare variant", "",
						new FishCost[]{
							new FishCost(4500, 11250),
							new FishCost(6075, 15190),
							new FishCost(6750, 16875),
							new FishCost(1015, 1400)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Twilight Stormfish", "Night variant", "",
						new FishCost[]{
							new FishCost(450, 1125),
							new FishCost(610, 1520),
							new FishCost(675, 1690),
							new FishCost(100, 225)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					)
				}
			),
			new Fish("wreckers", "near Shipwrecks", BaitType.Earthworm, $"{FISH_PHOTO_PATH}\\Rose_Wrecker.jpg",
				new Species[]{
					new Species ("Rose Wrecker", "Base variant", "",
						new FishCost[]{
							new FishCost(375, 940),
							new FishCost(505, 1270),
							new FishCost(565, 1410),
							new FishCost(85, 210)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Sun Wrecker", "Common variant", "",
						new FishCost[]{
							new FishCost(450, 1125),
							new FishCost(610, 1520),
							new FishCost(675, 1690),
							new FishCost(100, 225)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Blackcloud Wrecker", "Uncommon variant", "",
						new FishCost[]{
							new FishCost(525, 1315),
							new FishCost(710, 1775),
							new FishCost(790, 1975),
							new FishCost(120, 295)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Snow Wrecker", "Rare variant", "",
						new FishCost[]{
							new FishCost(3750, 9375),
							new FishCost(5065, 12655),
							new FishCost(5625, 14065),
							new FishCost(845, 2110)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					),
					new Species ("Moon Wrecker", "Night variant", "",
						new FishCost[]{
							new FishCost(450, 1125),
							new FishCost(610, 1520),
							new FishCost(675, 1690),
							new FishCost(100, 225)
						},
						new Rectangle[]
						{
							WHOLE_MAP
						}
					)
				}
			)
		}; 
		
		public static Dictionary<BaitType, string> BaitPicturePath = new Dictionary<BaitType, string>()
		{
			[BaitType.None] =		"Images\\baits\\Empty.png",
			[BaitType.Grub] =		"Images\\baits\\Grubs.png",
			[BaitType.Leech] =		"Images\\baits\\Leeches.png",
			[BaitType.Earthworm] =	"Images\\baits\\Earthworms.png",
		};
	}
}
