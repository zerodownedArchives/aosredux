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
	public class axesouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new axesouthAddonDeed();
			}
		}

		[ Constructable ]
		public axesouthAddon()
		{
			AddComponent( new AddonComponent( 5472 ), 0, 0, 0 );
			AddonComponent ac = null;

		}

		public axesouthAddon( Serial serial ) : base( serial )
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

	public class axesouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new axesouthAddon();
			}
		}

		[Constructable]
		public axesouthAddonDeed()
		{
			Name = "axe south";
		}

		public axesouthAddonDeed( Serial serial ) : base( serial )
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