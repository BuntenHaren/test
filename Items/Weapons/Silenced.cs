using Terraria.ID;
using Terraria.ModLoader;

namespace test.Items.Weapons
{
    public class Silenced : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kaboom");
            Tooltip.SetDefault("This bad boi has a silencer on it");
        }
        public override void SetDefaults()
        {
            item.damage = 1;
            item.ranged = true;
            item.width = 50;
            item.height = 28;
            item.useTime = 10;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 240;
            item.value = 10000;
            item.rare = 4;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shoot = 10;
            item.shootSpeed = 16f;
            item.useAmmo = ProjectileID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}