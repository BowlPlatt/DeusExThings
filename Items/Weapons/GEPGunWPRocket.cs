using System;
using DeusExThings.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DeusExThings.Items.Weapons
{
    class GEPGunWPRocket : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("GEP Gun Rockets (WP)");
            Tooltip.SetDefault("An even more silent way to take down Manderley.");
        }

        public override void SetDefaults()
        {
            item.damage = 350;
            item.ranged = true;
            item.width = 40;
            item.height = 40;
            item.maxStack = 9999;
            item.consumable = true;                                     //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 5f;
            item.value = 10;
            item.rare = 2;
            item.useStyle = 1;
            item.useAnimation = 25;
            item.useTime = 25;
            item.noMelee = true;
            item.shoot = mod.ProjectileType<GEPGunWPRocketProj>();      //The projectile that shoots when your weapon using this ammo
            item.shootSpeed = 1f;                                       //The speed of the projectile
            item.ammo = AmmoID.Rocket;                                  //The ammo class this ammo belongs to.
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ExplosivePowder, 50);
            recipe.AddIngredient(ItemID.EmptyBullet, 50);
            recipe.AddIngredient(ItemID.Dynamite, 50);
            recipe.AddIngredient(ItemID.CursedFlame, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}
