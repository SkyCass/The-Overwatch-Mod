using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Diagnostics;
using Microsoft.Xna.Framework;

namespace OverwatchMod.Items
{
	public class PulsePistol : ModItem
	{


        public override void SetStaticDefaults() 
		{
			
			Tooltip.SetDefault("Only the first of twenty shots consumes ammo\n'The World Could Always Use More Heroes!' ");
		}
		public override void SetDefaults() 
		{
			item.damage = 2;
			item.ranged = true;
            item.width = 34;
            item.height = 24;
            item.useAnimation = 21;
			item.useTime = 1;
			item.reuseDelay = 20;
            item.useStyle = 5; 
			item.noMelee = true; 
            item.knockBack = 0;
			item.value = 10000;
            item.rare = 1;
			item.autoReuse = true;
            item.shoot = 10; 
            item.shootSpeed = 10f; 
            item.useAmmo = AmmoID.Bullet; 
            
            }
				public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddIngredient(ItemID.SwiftnessPotion, 3);
			recipe.AddIngredient(ItemID.SilverBar, 3);
			recipe.AddIngredient(ItemID.SilverBullet, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenBar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SilverBar, 1);
			recipe.AddRecipe();
		}

		public override bool ConsumeAmmo(Player player)
		{
		
			return !(player.itemAnimation < item.useAnimation - 2);
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(0, 0);

			
		}
		
			public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, -1, 4))
			{
				position += muzzleOffset;
			}

			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(8));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			return true;
		}
		
		
			 
		}
}

	
