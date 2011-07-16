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
	public class smallbedsouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new smallbedsouthAddonDeed();
			}
		}

		[ Constructable ]
		public smallbedsouthAddon()
		{
			AddComponent( new AddonComponent( 2652 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 2659 ), 0, 0, 0 );
			AddonComponent ac = null;

		}

		public smallbedsouthAddon( Serial serial ) : base( serial )
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

	public class smallbedsouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new smallbedsouthAddon();
			}
		}

		[Constructable]
		public smallbedsouthAddonDeed()
		{
			Name = "small bed south";
		}

		public smallbedsouthAddonDeed( Serial serial ) : base( serial )
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