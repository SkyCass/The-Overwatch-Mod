using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Diagnostics;
using Microsoft.Xna.Framework;

namespace OverwatchMod.Items
{
	public class PeacekeeperRevolver : ModItem
	{


        public override void SetStaticDefaults() 
		{
			
			Tooltip.SetDefault("Only the first of twenty shots consumes ammo\n'The World Could Always Use More Heroes!' ");
		}
		public override void SetDefaults() 
		{
			item.damage = 70;
			item.ranged = true;
            item.width = 34;
            item.height = 24;
            item.useAnimation = 26;
			item.useTime = 26;
			item.crit = 26;
            item.useStyle = 5; 
			item.noMelee = true; 
            item.knockBack = 6;
			item.value = 50000;
            item.rare = 1;
			item.autoReuse = true;
            item.shoot = 10; 
            item.shootSpeed = 18f; 
            item.useAmmo = AmmoID.Bullet; 
            // useSoundName = mySoundName;
            }
				public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddIngredient(ItemID.FlintlockPistol, 1);
			recipe.AddIngredient(ItemID.SilverBullet, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
    }
}
