using System; 
using Server; 
using Server.Items;

namespace Server.Items
{ 
	public class RaresBag : Bag 
	{ 
		[Constructable] 
		public RaresBag() : this( 1000 ) 
		{ 
		} 

		[Constructable] 
		public RaresBag( int amount ) 
		{ 
            //RaresBag tool
            DropItem( new RunicHammer( CraftResource.DullCopper, amount ) );
			DropItem( new RunicHammer( CraftResource.ShadowIron, amount ) );
			DropItem( new RunicHammer( CraftResource.Copper, amount ) );
			DropItem( new RunicHammer( CraftResource.Bronze, amount ) );
			DropItem( new RunicHammer( CraftResource.Gold, amount ) );
			DropItem( new RunicHammer( CraftResource.Agapite, amount ) );
			DropItem( new RunicHammer( CraftResource.Verite, amount ) );
			DropItem( new RunicHammer( CraftResource.Valorite, amount ) );

			DropItem( new RunicSewingKit( CraftResource.SpinedLeather, amount ) );
			DropItem( new RunicSewingKit( CraftResource.HornedLeather, amount ) );
			DropItem( new RunicSewingKit( CraftResource.BarbedLeather, amount ) );
            //Rares weps
            DropItem( new TitansHammer());
            DropItem( new InquisitorsResolution());
            DropItem( new BladeOfTheRighteous());
            DropItem( new ZyronicClaw() );
            DropItem( new GauntletsOfNobility());
            DropItem( new MidnightBracers());
            DropItem( new VoiceOfTheFallenKing());
            DropItem( new OrnateCrownOfTheHarrower());
            DropItem( new HelmOfInsight());
            DropItem( new HolyKnightsBreastplate());
            DropItem( new ArmorOfFortune());
            DropItem( new TunicOfFire());
            DropItem( new LeggingsOfBane());
            DropItem( new ArcaneShield());
            DropItem( new Aegis());
            DropItem( new RingOfTheVile());
            DropItem( new BraceletOfHealth());
            DropItem( new RingOfTheElements());
            DropItem( new OrnamentOfTheMagician());
            DropItem( new DivineCountenance());
            DropItem( new JackalsCollar());
            DropItem( new HuntersHeaddress());
            DropItem( new HatOfTheMagi());
            DropItem( new ShadowDancerLeggings());
            DropItem( new SpiritOfTheTotem());
            DropItem( new BladeOfInsanity());
            DropItem( new AxeOfTheHeavens());
            DropItem( new TheBeserkersMaul());
            DropItem( new Frostbringer());
            DropItem( new BreathOfTheDead());
            DropItem( new TheDragonSlayer());
            DropItem( new BoneCrusher());
            DropItem( new StaffOfTheMagi());
            DropItem( new SerpentsFang());
            DropItem( new LegacyOfTheDreadLord());
            DropItem( new TheTaskmaster());
            DropItem( new TheDryadBow());
            DropItem( new LunaLance());
            DropItem( new VioletCourage());
            DropItem( new CavortingClub());
            DropItem( new CaptainQuacklebushsCutlass());
            DropItem( new NightsKiss());
            DropItem( new ShipModelOfTheHMSCape());
            DropItem( new AdmiralsHeartyRum());
            DropItem( new CandelabraOfSouls());
            DropItem( new IolosLute());
            DropItem( new GwennosHarp());
            DropItem( new ArcticDeathDealer());
            DropItem( new EnchantedTitanLegBone());
            DropItem( new NoxRangersHeavyCrossbow());
            DropItem( new BlazeOfDeath());
            DropItem( new DreadPirateHat());
            DropItem( new BurglarsBandana());
            DropItem( new GoldBricks());
            DropItem( new AlchemistsBauble());
            DropItem( new PhillipsWoodenSteed());
            DropItem( new PolarBearMask());
            DropItem( new BowOfTheJukaKing());
            DropItem( new GlovesOfThePugilist());
            DropItem( new OrcishVisage());
            DropItem( new StaffOfPower());
            DropItem( new ShieldOfInvulnerability());
            DropItem( new HeartOfTheLion());
            DropItem( new ColdBlood());
            DropItem( new GhostShipAnchor());
            DropItem( new SeahorseStatuette());
            DropItem( new WrathOfTheDryad());
            DropItem( new PixieSwatter());
            DropItem( new Exiler());
            DropItem( new HanzosBow());
            DropItem( new TheDestroyer());
            DropItem( new DragonNunchaku());
            DropItem( new PeasantsBokuto());
            DropItem( new TomeOfEnlightenment());
            DropItem( new ChestOfHeirlooms());
            DropItem( new HonorableSwords());
            DropItem( new AncientUrn());
            DropItem( new FluteOfRenewal());
            DropItem( new PigmentsOfTokuno());
            DropItem( new AncientSamuraiDo());
            DropItem( new LegsOfStability());
            DropItem( new GlovesOfTheSun());
            DropItem( new AncientFarmersKasa());
            DropItem( new ArmsOfTacticalExcellence());
            DropItem( new DaimyosHelm());
            DropItem( new BlackLotusHood());
            DropItem( new DemonForks());
            DropItem( new PilferedDancerFans());













        }


		public RaresBag( Serial serial ) : base( serial ) 
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
