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
	public class miniregalrugnorthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new miniregalrugnorthAddonDeed();
			}
		}

		[ Constructable ]
		public miniregalrugnorthAddon()
		{
			AddComponent( new AddonComponent( 2765 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 2763 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 2768 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 2762 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 2761 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 2766 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 2764 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 2767 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 2759 ), 0, 0, 0 );
			AddonComponent ac = null;
			ac = new AddonComponent( 2762 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 2765 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 2766 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 2759 );
			AddComponent( ac, 0, 0, 0 );

		}

		public miniregalrugnorthAddon( Serial serial ) : base( serial )
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

	public class miniregalrugnorthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new miniregalrugnorthAddon();
			}
		}

		[Constructable]
		public miniregalrugnorthAddonDeed()
		{
			Name = "mini regal rug north";
		}

		public miniregalrugnorthAddonDeed( Serial serial ) : base( serial )
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