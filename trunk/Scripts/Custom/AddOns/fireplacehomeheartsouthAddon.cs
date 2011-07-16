/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class fireplacehomeheartsouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new fireplacehomeheartsouthAddonDeed();
			}
		}

		[ Constructable ]
		public fireplacehomeheartsouthAddon()
		{
			AddComponent( new AddonComponent( 9056 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 9054 ), 0, 0, 0 );
			AddonComponent ac = null;

		}

		public fireplacehomeheartsouthAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class fireplacehomeheartsouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new fireplacehomeheartsouthAddon();
			}
		}

		[Constructable]
		public fireplacehomeheartsouthAddonDeed()
		{
			Name = "fireplace homeheart south";
		}

		public fireplacehomeheartsouthAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}