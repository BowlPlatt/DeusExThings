using System;
using Microsoft.Xna.Framework;
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
            item.damage = 300;
            item.ranged = true;
            item.width = 40;
            item.height = 40;
            item.maxStack = 9999;
            item.consumable = true;                                     //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 5f;
            item.value = 10;
            item.rare = 2;
            item.noMelee = true;
            item.shoot = mod.ProjectileType("GEPGunRocketWPProj");      //The projectile that shoots when your weapon using this ammo
            item.shootSpeed = 16f;                                      //The speed of the projectile
            item.ammo = mod.ItemType("GEPGunRocket");                   //The ammo class this ammo belongs to.
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
