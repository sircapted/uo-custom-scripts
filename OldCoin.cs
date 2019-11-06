
using System;
using Server.Misc;

namespace Server.Items
{
    public class OldCoin : Item
    {
        public override double DefaultWeight
        {
            get { return (Core.ML ? (0.02 / 3) : 0.02); }
        }

        [Constructable]

        public OldCoin() : this(1)
        {
        }

        [Constructable]
        public OldCoin(int amountFrom, int amountTo) : this(Utility.Random(amountFrom, amountTo))
        {
        }

        [Constructable]
        public OldCoin(int amount) : base(0xEED)
        {
            Name = "OldCoin";
            Stackable = true;
            Weight = 1;
            
            Hue = 2553;//dull silver like
            //Hue = 1153;//black coin
            ItemID = 0xEED;
            Amount = amount;
        }



        public OldCoin(Serial serial) : base(serial)
        {
        }

        public override int GetDropSound()
        {
            if (Amount <= 1)
                return 0x2E4;
            else if (Amount <= 5)
                return 0x2E5;
            else
                return 0x2E6;
        }
        






        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version 
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}

