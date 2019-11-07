using System;
using System.Collections;
using Server.Items;
using Server.Targeting;
using Server.Misc;

namespace Server.Mobiles
{
	[CorpseName( "a bunnies corpse" )]
	public class RogerRabbit : BaseCreature
	{
		public override InhumanSpeech SpeechType{ get{ return InhumanSpeech.Orc; } }

		[Constructable]
		public RogerRabbit() : base( AIType.AI_Melee, FightMode.Closest, 10, 7, 0.2, 0.4 )
		{
			Name = "a Hare";
			Body = 723;
            Hue = 0x800; // snow color
            BaseSoundID = 0x45A;

			SetStr( 96, 120 );
			SetDex( 101, 130 );
			SetInt( 36, 60 );

			SetHits( 58, 72 );
			SetMana( 30, 60 );

			SetDamage( 7, 8 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 25, 35 );
			SetResistance( ResistanceType.Fire, 30, 40 );
			SetResistance( ResistanceType.Cold, 15, 25 );
			SetResistance( ResistanceType.Poison, 15, 20 );
			SetResistance( ResistanceType.Energy, 25, 30 );

			SetSkill( SkillName.MagicResist, 50.1, 75.0 );
			SetSkill( SkillName.Tactics, 55.1, 80.0 );

			SetSkill( SkillName.Fencing, 50.1, 70.0 );
			SetSkill( SkillName.Archery, 80.1, 100.0 );
			SetSkill( SkillName.Parry, 40.1, 60.0 );
			SetSkill( SkillName.Healing, 80.1, 100.0 );
			SetSkill( SkillName.Anatomy, 50.1, 90.0 );
			SetSkill( SkillName.DetectHidden, 100.1, 120.0 );
                   	SetSkill( SkillName.Hiding, 100.0, 120.0 );
			SetSkill( SkillName.Stealth, 80.1, 120.0 );

			Fame = 2500;
			Karma = -2500;

			PackItem( new Apple( Utility.RandomMinMax( 5, 10 ) ) );
			PackItem( new Arrow( Utility.RandomMinMax( 60, 70 ) ) );
			PackItem( new Bandage( Utility.RandomMinMax( 1, 15 ) ) );

			if ( 0.4 > Utility.RandomDouble() )
				AddItem( new OrcishBow() );
			else
				AddItem( new Bow() );
		}
        public void PackMagicItems(int minLevel, int maxLevel, double armorChance, double weaponChance)
        {
            if (!PackArmor(minLevel, maxLevel, armorChance))
                PackWeapon(minLevel, maxLevel, weaponChance);
        }

        public void PackMagicItems(int minLevel, int maxLevel)
        {
            PackMagicItems(minLevel, maxLevel, 0.55, 0.05);
        }

        public override int TreasureMapLevel{ get{ return 2; } }
		

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich );
			// TODO: evil orc helm
		}

		public override OppositionGroup OppositionGroup
		{
			get{ return OppositionGroup.SavagesAndOrcs; }
		}

		public override bool IsEnemy( Mobile m )
		{
			if ( m.Player && m.FindItemOnLayer( Layer.Helm ) is OrcishKinMask )
				return false;
			if ( SolenHelper.CheckRedFriendship( m ) )
                		return false;
            			
			else


			return base.IsEnemy( m );
		}

		public override void AggressiveAction( Mobile aggressor, bool criminal )
		{
			base.AggressiveAction( aggressor, criminal );

			Item item = aggressor.FindItemOnLayer( Layer.Helm );

			if ( item is OrcishKinMask )
			{
				AOS.Damage( aggressor, 50, 0, 100, 0, 0, 0 );
				item.Delete();
				aggressor.FixedParticles( 0x36BD, 20, 10, 5044, EffectLayer.Head );
				aggressor.PlaySound( 0x307 );
			}
		}

		private Mobile FindTarget()
		{
			foreach ( Mobile m in this.GetMobilesInRange( 10 ) )
			{
				if ( m.Player && m.Hidden && m.AccessLevel == AccessLevel.Player )
				{
					return m;
				}
			}

			return null;
		}

		private void TryToDetectHidden()
		{
			Mobile m = FindTarget();

			if ( m != null )
			{
				
					Target targ = this.Target;

					if ( targ != null )
						targ.Invoke( this, this );

					Effects.PlaySound( this.Location, this.Map, 0x340 );
			}
        		
		}

		private void HealSelf()
		{
			if ( BandageContext.GetContext( this ) == null )
			{
				BandageContext.BeginHeal( this, this );
			}

			return;
		}

		public override void OnThink()
		{
			if ( Utility.RandomDouble() < 0.6 && Hits < ( HitsMax - 35 ) && !Hidden )
				HealSelf();

			if ( Utility.RandomDouble() < 0.2 )
				TryToDetectHidden();
		}

		public override bool CanRummageCorpses{ get{ return true; } }
		public override int Meat{ get{ return 1; } }

		public RogerRabbit( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}