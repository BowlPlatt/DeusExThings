using System;
using DeusExThings.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DeusExThings.Items.Weapons
{
    class GEPGunRocket : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("GEP Gun Rockets (HE)");
            Tooltip.SetDefault("Stop living, scum! WHO SAID YOU COULD KEEP ON LIVING?! -Dr. Hans Volter, PhD.");
        }

        public override void SetDefaults()
        {
            item.damage = 450;
            item.ranged = true;
            item.width = 40;
            item.height = 40;
            item.maxStack = 9999;
            item.consumable = true;                                 //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 10f;
            item.value = 10;
            item.rare = 2;
            item.noMelee = true;
            item.shoot = mod.ProjectileType("GEPGunRocketProj");    //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 16f;                                  //The speed of the projectile
            item.ammo = item.type;                                  //The ammo class this ammo belongs to.
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ExplosivePowder, 50);
            recipe.AddIngredient(ItemID.EmptyBullet, 50);
            recipe.AddIngredient(ItemID.Dynamite, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}
