using System;
using Server;

namespace Server.Items
{
	public class PiratesSword : Longsword
	{
		//public override int LabelNumber{ get{ return 1062921; } } // The Holy Sword

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public PiratesSword()
		{
			Hue = 0x402;
			LootType = LootType.Blessed;

			Slayer = SlayerName.Silver;

			Attributes.WeaponDamage = 50;
			WeaponAttributes.SelfRepair = 25;
			WeaponAttributes.LowerStatReq = 75;
			WeaponAttributes.UseBestSkill = 2;
		}

		public PiratesSword( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( (int) 0 ); // version
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}