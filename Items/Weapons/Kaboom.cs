using Terraria.ID;
using Terraria.ModLoader;

namespace test.Items.Weapons
{
	public class Kaboom : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kaboom");
			Tooltip.SetDefault("Go ham N I B B A  !");
		}
		public override void SetDefaults()
		{
			item.damage = 100;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 5;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 160;
			item.value = 10000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("Projectile");
            item.shootSpeed = 4f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
