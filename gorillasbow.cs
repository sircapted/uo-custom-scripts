using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x13B2, 0x13B1 )]
	public class GorillaBow : BaseRanged
	{
		public override int EffectID{ get{ return 0xF42; } }
		public override Type AmmoType{ get{ return typeof( Arrow ); } }
		public override Item Ammo{ get{ return new Arrow(); } }

		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }
		//public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.MortalStrike; } }

		public override int AosStrengthReq{ get{ return 80; } }
		public override int AosMinDamage{ get{ return Core.ML ? 15 : 16; } }
		public override int AosMaxDamage{ get{ return Core.ML ? 19 : 18; } }
		public override int AosSpeed{ get{ return 45; } }
		public override float MlSpeed{ get{ return 3.05f; } }

		public override int OldStrengthReq{ get{ return 60; } }
		public override int OldMinDamage{ get{ return 89; } }
		public override int OldMaxDamage{ get{ return 91; } }
		public override int OldSpeed{ get{ return 20; } }

		public override int DefMaxRange{ get{ return 15; } }

		public override int InitMinHits{ get{ return 61; } }
		public override int InitMaxHits{ get{ return 100; } }

		public override WeaponAnimation DefAnimation{ get{ return WeaponAnimation.ShootBow; } }

		[Constructable]
		public GorillaBow() : base( 0x13B2 )
		{
			Weight = 6.0;
			Layer = Layer.TwoHanded;
            Name = "GorillaBow";
            Hue = 0xFFF;
            LootType = LootType.Blessed;

            Slayer = SlayerName.Silver;

            //Attributes.WeaponDamage = 50;
            //WeaponAttributes.SelfRepair = 40;
            //WeaponAttributes.LowerStatReq = 100;
            WeaponAttributes.HitLightning = 50;
            //WeaponAttributes.UseBestSkill = 1;


        }

		public GorillaBow( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			
		}
	}
}